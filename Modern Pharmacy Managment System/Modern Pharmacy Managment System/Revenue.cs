using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modern_Pharmacy_Managment_System.Database;

namespace Modern_Pharmacy_Managment_System
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
            PopulateExpenseChart();
            PopulateProfitChart();
            PopulateOnlineOfflineChart();

        }
        private void PopulateExpenseChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(Expense) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

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
                    ExpenseChart.Series["Expense"].Points.Clear();

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
                        ExpenseChart.Series["Expense"].Points.AddXY(date, totalRevenue);
                    }

                    reader.Close();
                }

                // Set custom interval and label format for x-axis
                ExpenseChart.ChartAreas[0].AxisX.Interval = 1; // Interval of 1 day
                ExpenseChart.ChartAreas[0].AxisX.LabelStyle.Format = "d MMM yyyy"; // Custom date format (e.g., "1 Jan 2024")
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //  SUM((Revenue - Expense) + NetIncome)

        private void PopulateProfitChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT Date, SUM(TotalOrders) AS TotalRevenue FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";


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
                    ProfitChart.Series["Profit"].Points.Clear();

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
                        ProfitChart.Series["Profit"].Points.AddXY(date, totalRevenue);
                    }

                    reader.Close();
                }

                // Set custom interval and label format for x-axis
                ProfitChart.ChartAreas[0].AxisX.Interval = 1; // Interval of 1 day
                ProfitChart.ChartAreas[0].AxisX.LabelStyle.Format = "d MMM yyyy"; // Custom date format (e.g., "1 Jan 2024")
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateOnlineOfflineChart(bool filterToday = false, bool filterLast7Days = false, bool filterLast30Days = false, bool filterLastYear = false, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT SUM(TotalOrders) AS TotalOrders, " +
                                   "CASE " +
                                   "WHEN EmpId IS NULL AND CustomerPhone IS NOT NULL THEN 'Online' " +
                                   "WHEN EmpId IS NOT NULL AND CustomerPhone IS NULL THEN 'Offline' " +
                                   "END AS OrderType " +
                                   "FROM [PMSnew].[dbo].[AccountTbl] WHERE 1 = 1";

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
                        query += " AND Date >= @StartDate AND Date <= @EndDate";
                    }

                    query += " GROUP BY CASE " +
                             "WHEN EmpId IS NULL AND CustomerPhone IS NOT NULL THEN 'Online' " +
                             "WHEN EmpId IS NOT NULL AND CustomerPhone IS NULL THEN 'Offline' " +
                             "END";

                    SqlCommand cm = new SqlCommand(query, con);

                    if (startDate != null && endDate != null)
                    {
                        cm.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                        cm.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                    }

                    SqlDataReader reader = cm.ExecuteReader();

                    // Clear existing data points
                    OnlineOfflineChart.Series["OnlineOffline"].Points.Clear();

                    while (reader.Read())
                    {
                        double totalOrders;
                        string orderType;

                        // Check if the TotalOrders field is DBNull
                        if (!reader.IsDBNull(reader.GetOrdinal("TotalOrders")))
                        {
                            totalOrders = Convert.ToDouble(reader["TotalOrders"]);
                        }
                        else
                        {
                            // Skip adding this record to the chart
                            continue;
                        }

                        // Check if the OrderType field is DBNull
                        if (!reader.IsDBNull(reader.GetOrdinal("OrderType")))
                        {
                            orderType = reader["OrderType"].ToString();
                        }
                        else
                        {
                            // Skip adding this record to the chart
                            continue;
                        }

                        // Add data point to the chart
                        OnlineOfflineChart.Series["OnlineOffline"].Points.AddXY(orderType, totalOrders);
                    }

                    reader.Close();
                }

                // Show data point values
                OnlineOfflineChart.Series["OnlineOffline"].IsValueShownAsLabel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }







        private void Today_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterToday: true);
            PopulateProfitChart(filterToday: true);
            PopulateOnlineOfflineChart(filterToday: true);
        }

        private void Last7Btn_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterLast7Days: true);
            PopulateProfitChart(filterLast7Days: true);
            PopulateOnlineOfflineChart(filterLast7Days: true);
        }

        private void UseBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = Calender1.Value.Date;
            DateTime endDate = Calender2.Value.Date;
            PopulateOnlineOfflineChart(startDate: startDate, endDate: endDate);

        }

        private void Last30Btn_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterLast30Days: true);
            PopulateProfitChart(filterLast30Days: true);
            PopulateOnlineOfflineChart(filterLast30Days: true);

        }

        private void LastYearBtn_Click(object sender, EventArgs e)
        {
            PopulateExpenseChart(filterLastYear: true);
            PopulateProfitChart(filterLastYear:true) ;
            PopulateOnlineOfflineChart(filterLastYear: true);

        }
    }
}

