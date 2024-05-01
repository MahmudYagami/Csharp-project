using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Modern_Pharmacy_Managment_System.Database;

namespace Modern_Pharmacy_Managment_System
{
    public partial class StaffInfoPanel : Form

    {  
        public StaffInfoPanel()
        {
            InitializeComponent();
            MedicineInfo();
            refreshInfo();
        }


        public void refreshInfo()
        {         

            ShowTodaysMedicineSale();

            CountTotalInvoices();

            DateTimeLabel();

            showInformation();

            todaysSale();

            MedicineInfo();

            paymentType();

        }

        public void showInformation()
        {
            using (var con = DatabaseConnection.databaseConnect())
            {
                con.Open();

                // count total customer.
                SqlCommand cm = new SqlCommand("SELECT Count(*) From tbCustomer", con);
                var totalCustomer = cm.ExecuteScalar();
                if (int.Parse(totalCustomer.ToString()) < 10)
                {
                    totalCustomer = "0" + totalCustomer;
                }
                lblCustomerCount.Text = totalCustomer.ToString();
            
    
                // Check total medicine count
                SqlCommand cm2 = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl", con);
                int totalMedicineCount = (int)cm2.ExecuteScalar();
                string totalMedicineDisplay = totalMedicineCount < 10 ? "0" + totalMedicineCount.ToString() : totalMedicineCount.ToString();
                lblMadiniceCount.Text = totalMedicineDisplay;
                con.Close();           
            }
        }

        public void MedicineInfo()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Check for medicine shortage
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM InventoryTbl WHERE PStock < 50", con);
                    int shortageCount = (int)cmd.ExecuteScalar();
                    string shortageCountDisplay = shortageCount < 10 ? "0" + shortageCount.ToString() : shortageCount.ToString();
                    lblMadicineShortage.Text = shortageCountDisplay;

                    // If shortage, insert details into MedicineShortageTbl if not already there
                    if (shortageCount > 0)
                    {
                        SqlCommand insertCmd = new SqlCommand(@"INSERT INTO MedicineShortageTbl (SId, SName, SQuantity, SBuyingPrice)
                                                    SELECT PId, PName, PStock, PBuyingPrice 
                                                    FROM InventoryTbl 
                                                    WHERE PStock < 50 AND PId NOT IN (SELECT SId FROM MedicineShortageTbl)", con);
                        int rowsInserted = insertCmd.ExecuteNonQuery();
                        //MessageBox.Show(rowsInserted + " medicine(s) added to MedicineShortageTbl.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void ShowTodaysMedicineSale()
        {
            try
            {
                // Get today's date
                DateTime today = DateTime.Today;

                // Get the employee ID
                int empId = Login.EmpId;

                // Open a connection to the database
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Query to select the sum of TotalOrders for today's date and the specified employee ID, excluding NULL values
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(TotalOrders), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND EmpId = @EmpId", con);
                    cmd.Parameters.AddWithValue("@Today", today);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    // Execute the query to get the sum
                    object result = cmd.ExecuteScalar();
                    int todaysTotalMedicineSale = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Display the result in lblTodaysMedicineSale
                    lblTodaysMedicineSale.Text = todaysTotalMedicineSale.ToString();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void CountTotalInvoices()
        {
            try
            {
                // Total invoices count
                int totalInvoicesCount = 0;

                // Todays total invoices count
                int todaysTotalInvoicesCount = 0;

                // Get today's date
                DateTime today = DateTime.Today;

                // Get the employee ID
                int empId = Login.EmpId;

                // Open a connection to the database
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Query to count total invoices (excluding NULL TotalOrders and considering Date is not NULL)
                    SqlCommand totalInvoicesCmd = new SqlCommand("SELECT COUNT(*) FROM AccountTbl WHERE TotalOrders IS NOT NULL AND Date IS NOT NULL AND EmpId = @EmpId", con);
                    totalInvoicesCmd.Parameters.AddWithValue("@EmpId", empId);
                    totalInvoicesCount = (int)totalInvoicesCmd.ExecuteScalar();

                    // Query to count today's total invoices
                    SqlCommand todaysTotalInvoicesCmd = new SqlCommand("SELECT COUNT(*) FROM AccountTbl WHERE TotalOrders IS NOT NULL AND Date = @Today AND EmpId = @EmpId", con);
                    todaysTotalInvoicesCmd.Parameters.AddWithValue("@Today", today);
                    todaysTotalInvoicesCmd.Parameters.AddWithValue("@EmpId", empId);
                    todaysTotalInvoicesCount = (int)todaysTotalInvoicesCmd.ExecuteScalar();
                }
                lblTotalInvoices.Text = todaysTotalInvoicesCount.ToString();
                // Display total invoices count and today's total invoices count
                // MessageBox.Show($"Total Invoices: {totalInvoicesCount}\nToday's Total Invoices: {todaysTotalInvoicesCount}", "Invoice Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void todaysSale()
        {
            try
            {
                // Get today's date
                DateTime today = DateTime.Today;

                // Get the employee ID
                int empId = Login.EmpId;

                // Open a connection to the database
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Query to select the sum of Revenue for today's date, excluding NULL values and matching EmpId
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(Revenue), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND EmpId = @EmpId", con);
                    cmd.Parameters.AddWithValue("@Today", today);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    // Execute the query to get the sum
                    object result = cmd.ExecuteScalar();
                    int todaysTotalMedicineSale = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    // Display the result in lblTodaysMedicineSale
                    lblSellingAmount.Text = todaysTotalMedicineSale.ToString();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paymentType()
        {
            try
            {
                // Get today's date
                DateTime today = DateTime.Today;

                // Initialize the sums for cash and bkash
                double cashSum = 0;
                double bkashSum = 0;

                // Open a connection to the database
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Query for cash sum (where CustomerPhone is null)
                    SqlCommand cashCmd = new SqlCommand("SELECT ISNULL(SUM(Revenue), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND CustomerPhone IS NULL AND EmpId = @EmpId", con);
                    cashCmd.Parameters.AddWithValue("@Today", today);
                    cashCmd.Parameters.AddWithValue("@EmpId", Login.EmpId);
                    object cashResult = cashCmd.ExecuteScalar();
                    cashSum = cashResult != DBNull.Value ? Convert.ToDouble(cashResult) : 0;

                    // Query for bkash sum (where CustomerPhone is not null)
                    SqlCommand bkashCmd = new SqlCommand("SELECT ISNULL(SUM(Revenue), 0) FROM AccountTbl WHERE CONVERT(date, Date) = @Today AND CustomerPhone IS NOT NULL AND EmpId = @EmpId", con);
                    bkashCmd.Parameters.AddWithValue("@Today", today);
                    bkashCmd.Parameters.AddWithValue("@EmpId", Login.EmpId);
                    object bkashResult = bkashCmd.ExecuteScalar();
                    bkashSum = bkashResult != DBNull.Value ? Convert.ToDouble(bkashResult) : 0;

                    // Update the labels
                    lblCash.Text = cashSum.ToString();
                    lblBkash.Text = bkashSum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DateTimeLabel()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new addproductPha());
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
            staffDashboard.LoadBkashFormIntoMainPanel(new CustomerForm());
            this.Hide();
        }

        private void btnMedicineShortage_Click(object sender, EventArgs e)
        {
            /*          
             StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
             staffDashboard.LoadBkashFormIntoMainPanel(new MedicineShortage());
             this.Hide();
           */

            MedicineShortage ms = new MedicineShortage();
            ms.Show();

        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {
            //pnale
        }

    }
}
