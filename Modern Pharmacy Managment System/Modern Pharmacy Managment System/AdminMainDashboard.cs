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
            DisplayTotalRevenueOrdersAndExpense();
            PopulateRevenueChart();
            PopulateLeaveCount();
            PopulateEmployeeCount();
            //PopulateUnpaidEmployeeCount();
        }

        

        private void PopulateRevenueChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(Revenue) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                    // Add date filters if required
                    if (filterToday)
                    {
                        query += " AND CONVERT(date, Date) = CONVERT(date, GETDATE())";
                    }
                    else if (filterLast7Days)
                    {
                        query += " AND Date >= DATEADD(day, -6, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLast30Days)
                    {
                        query += " AND Date >= DATEADD(day, -29, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLastYear)
                    {
                        query += " AND Date >= DATEADD(year, -1, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (startDate != null && endDate != null)
                    {
                        query += $" AND Date >= @StartDate AND Date <= @EndDate";
                    }

                    query += " GROUP BY Date ORDER BY Date";

                    SqlCommand cm = new SqlCommand(query, con);

                    if (startDate != null && endDate != null)
                    {
                        cm.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cm.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                    }

                    SqlDataReader reader = cm.ExecuteReader();

                    // Clear existing data points
                    RevenueChart.Series["Revenue"].Points.Clear();

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


        private void DisplayTotalRevenueOrdersAndExpense(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT SUM(Revenue) AS TotalRevenue, SUM(TotalOrders) AS TotalOrders, SUM(Expense) AS TotalExpense FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

                    // Add date filters based on the filter options
                    if (filterToday)
                    {
                        query += " AND CONVERT(date, Date) = CONVERT(date, GETDATE())";
                    }
                    else if (filterLast7Days)
                    {
                        query += " AND Date >= DATEADD(day, -6, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLast30Days)
                    {
                        query += " AND Date >= DATEADD(day, -29, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (filterLastYear)
                    {
                        query += " AND Date >= DATEADD(year, -1, CONVERT(date, GETDATE())) AND Date <= CONVERT(date, GETDATE())";
                    }
                    else if (startDate != null && endDate != null)
                    {
                        query += $" AND Date >= @StartDate AND Date <= @EndDate";
                    }

                    SqlCommand cm = new SqlCommand(query, con);

                    if (startDate != null && endDate != null)
                    {
                        cm.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cm.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                    }

                    SqlDataReader reader = cm.ExecuteReader();

                    // Read the result set
                    if (reader.Read())
                    {
                        // Retrieve total revenue, total orders, and total expense from the result set
                        double totalRevenue = reader.IsDBNull(reader.GetOrdinal("TotalRevenue")) ? 0 : reader.GetDouble(reader.GetOrdinal("TotalRevenue"));
                        int totalOrders = reader.IsDBNull(reader.GetOrdinal("TotalOrders")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalOrders"));
                        double totalExpense = reader.IsDBNull(reader.GetOrdinal("TotalExpense")) ? 0 : reader.GetDouble(reader.GetOrdinal("TotalExpense"));

                        // Update the labels with the formatted values
                        TotalRevenue.Text = totalRevenue.ToString("C");
                        TotalOrders.Text = totalOrders.ToString();
                        ExpenseLbl.Text = totalExpense.ToString("C");
                    }
                    else
                    {
                        // If no data is returned, set the labels to indicate zero values
                        TotalRevenue.Text = "Total Revenue: $0.00";
                        TotalOrders.Text = "Total Orders: 0";
                        ExpenseLbl.Text = "Total Expense: $0.00";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void TodayBtn_Click(object sender, EventArgs e)
        {
            // Call PopulateRevenueChart with filterToday parameter set to true
            PopulateRevenueChart(filterToday: true);

            // Call DisplayTotalRevenueAndOrders with filterToday parameter set to true to update total revenue and orders label
            DisplayTotalRevenueOrdersAndExpense(filterToday: true);
        }

        private void Last7Btn_Click(object sender, EventArgs e)
        {
            // Call PopulateRevenueChart with filterLast7Days parameter set to true
            PopulateRevenueChart(filterLast7Days: true);

            // Call DisplayTotalRevenueAndOrders with filterLast7Days parameter set to true to update total revenue and orders label
            DisplayTotalRevenueOrdersAndExpense(filterLast7Days: true);
        }

       
        private void Last30Btn_Click_1(object sender, EventArgs e)
        {
            PopulateRevenueChart(filterLast30Days: true);
            DisplayTotalRevenueOrdersAndExpense(filterLast30Days: true);

        }

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

        /*private void PopulateUnpaidEmployeeCount()
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
*/
        private void LastYearBtn_Click(object sender, EventArgs e)
        {
            PopulateRevenueChart(filterLastYear: true);

            // Call DisplayTotalRevenueOrdersAndExpense with filterLastYear parameter set to true
            DisplayTotalRevenueOrdersAndExpense(filterLastYear: true);
        }

        private void UseBtn_Click(object sender, EventArgs e)
        {
            // Get the selected start and end dates from Calender1 and Calender2
            DateTime startDate = Calender1.Value.Date;
            DateTime endDate = Calender2.Value.Date;

            // Call method to display total revenue, orders, and expense for the selected date range
            DisplayTotalRevenueOrdersAndExpense(startDate: startDate, endDate: endDate);

            // Call method to populate revenue chart for the selected date range
            PopulateRevenueChart(startDate: startDate, endDate: endDate);
        }

    }
}
