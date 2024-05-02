using Modern_Pharmacy_Managment_System.Database;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Modern_Pharmacy_Managment_System
{
    public partial class AdminMainDashboard : Form
    {
        public AdminMainDashboard()
        {
            InitializeComponent();
            PopulateRevenueChart();
            DisplayTotalRevenueAndOrders();
            PopulateEmployeeCount();
            PopulateUnpaidEmployeeCount();
            PopulateLeaveCount();
        }

        private void PopulateRevenueChart(bool filterToday = false, bool filterLast7Days = false)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(Revenue) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                    // If filtering for today, add WHERE clause to filter data for today's date
                    if (filterToday)
                    {
                        query += " AND CONVERT(date, Date) = CONVERT(date, GETDATE())";
                    }

                    // If filtering for last 7 days, add WHERE clause to filter data for the last 7 days
                    if (filterLast7Days)
                    {
                        query += " AND Date >= DATEADD(day, -6, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }

                    query += " GROUP BY Date ORDER BY Date";

                    SqlCommand cm = new SqlCommand(query, con);
                    SqlDataReader reader = cm.ExecuteReader();

                    // Clear existing data points
                    RevenueChart.Series["Revenue"].Points.Clear();

                    // Variable to hold total revenue for the last 7 days
                    double totalRevenueLast7Days = 0;

                    while (reader.Read())
                    {
                        DateTime date;
                        double totalRevenue;

                        // Check if the Date field is DBNull
                        if (!reader.IsDBNull(reader.GetOrdinal("Date")))
                        {
                            date = Convert.ToDateTime(reader["Date"]);
                        }
                        else
                        {
                            // Skip adding this record to the chart
                            continue;
                        }

                        // Check if the TotalRevenue field is DBNull
                        if (!reader.IsDBNull(reader.GetOrdinal("TotalRevenue")))
                        {
                            totalRevenue = Convert.ToDouble(reader["TotalRevenue"]);
                        }
                        else
                        {
                            // Skip adding this record to the chart
                            continue;
                        }

                        // Add data point to the chart
                        RevenueChart.Series["Revenue"].Points.AddXY(date, totalRevenue);

                        // Accumulate total revenue for the last 7 days
                        totalRevenueLast7Days += totalRevenue;
                    }

                    reader.Close();

                    

                }

                // Set custom interval and label format for x-axis
                RevenueChart.ChartAreas[0].AxisX.Interval = 1; // Interval of 1 day
                RevenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "d MMM yyyy"; // Custom date format (e.g., "1 Jan 2024")
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void TodayBtn_Click_1(object sender, EventArgs e)
        {
            DisplayTotalRevenueAndOrders(filterToday: true);
            PopulateRevenueChart(filterToday: true);

        }

        private void Last7Btn_Click(object sender, EventArgs e)
        {

            // Call PopulateRevenueChart with filterLast7Days parameter set to true
            DisplayTotalRevenueAndOrders(filterLast7Days: true);
            PopulateRevenueChart(filterLast7Days: true);

        }

        private void DisplayTotalRevenueAndOrders(bool filterToday = false, bool filterLast7Days = false)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT SUM(Revenue) AS TotalRevenue, SUM(TotalOrders) AS TotalOrders FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                    // If filtering for today, add WHERE clause to filter data for today's date
                    if (filterToday)
                    {
                        query += " AND CONVERT(date, Date) = CONVERT(date, GETDATE())";
                    }

                    // If filtering for last 7 days, add WHERE clause to filter data for the last 7 days
                    if (filterLast7Days)
                    {
                        query += " AND Date >= DATEADD(day, -6, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }

                    SqlCommand cm = new SqlCommand(query, con);
                    SqlDataReader reader = cm.ExecuteReader();

                    // Read the result set
                    if (reader.Read())
                    {
                        // Retrieve total revenue and total orders from the result set
                        double totalRevenue = reader.IsDBNull(reader.GetOrdinal("TotalRevenue")) ? 0 : reader.GetDouble(reader.GetOrdinal("TotalRevenue"));
                        int totalOrders = reader.IsDBNull(reader.GetOrdinal("TotalOrders")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalOrders"));

                        // Update the TotalRevenue label with the formatted total revenue and total orders
                        TotalRevenue.Text =totalRevenue.ToString("C");
                        TotalOrders.Text =totalOrders.ToString();
                    }
                    else
                    {
                        // If no data is returned, set the labels to indicate zero revenue and orders
                        TotalRevenue.Text = "Total Revenue: $0.00";
                        TotalOrders.Text = "Total Orders: 0";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Display any error messages encountered during execution
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        //EMPLOYEE MANAGEMENT


        private void PopulateEmployeeCount()
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT Count(*) From EmployeeTbl", con);
                var totalEmployee = cm.ExecuteScalar();
                lblEmployeeCnt.Text = totalEmployee.ToString();
                con.Close();
            }
        }

        private void PopulateLeaveCount()
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT Count(*) From LeaveTbl  WHERE status = 'Approved'", con);
                var totalLeave = cm.ExecuteScalar();
                lblLeaveCnt.Text = totalLeave.ToString();
                con.Close();
            }
        }

        private void PopulateUnpaidEmployeeCount()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cm = new SqlCommand(@"
                        SELECT 
                            (SELECT COUNT(DISTINCT EmpId) FROM EmployeeTbl) - 
                            (SELECT COUNT(DISTINCT EmpId) FROM SalaryTbl) AS UnpaidEmployeeCount;", con);
                    object unpaidEmployeeCount = cm.ExecuteScalar();
                    if (unpaidEmployeeCount != null)
                    {
                        UnpaidEmpCnt.Text = unpaidEmployeeCount.ToString();
                    }
                    else
                    {
                        UnpaidEmpCnt.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblEmployeeCnt_Click(object sender, EventArgs e)
        {

        }
    }
}
