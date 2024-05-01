using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Modern_Pharmacy_Managment_System.Classes;
using Modern_Pharmacy_Managment_System.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Modern_Pharmacy_Managment_System
{
    public partial class Bkash : Form
    {
        private string userType;
        private string customerPhone;
        public Bkash(string Amount, int totalUnit, string type)
        {
            InitializeComponent();       
            lblAmount.Text = Amount;
            lblUnit.Text = totalUnit.ToString();
            lblUnit.Visible = false;
            Login login = Login.GetInstance();
            customerPhone = login.getCustomerPhone();
            userType = type;
             

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void addRevenue()
        {
            try
            {
                // Convert lblAmount text to double
                double grandTotal;

                // Check if lblAmount text is not empty and contains valid data
                if (double.TryParse(lblAmount.Text, out grandTotal))
                {
                    // Get the current date
                    DateTime currentDate = DateTime.Now;

                    // Initialize SqlConnection with the connection string
                    using (var con = DatabaseConnection.databaseConnect())
                    {
                        // Open the connection
                        con.Open();

                        int totalUnit = int.Parse(lblUnit.Text);

                        if(userType == "Employee")
                        {
                            // Insert into the accountTbl
                            int EmployeeID = Login.EmpId;
                            string customerPhone = txtPhone.Text;
                            string insertAccountQuery = "INSERT INTO AccountTbl (TotalOrders, Revenue, Date, EmpId,CustomerPhone) VALUES (@TotalOrders, @Revenue, @Date, @EmpId,@CustomerPhone)";
                            SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery, con); // Pass the connection to the SqlCommand constructor
                            insertAccountCmd.Parameters.AddWithValue("@TotalOrders", totalUnit);
                            insertAccountCmd.Parameters.AddWithValue("@Revenue", grandTotal);
                            insertAccountCmd.Parameters.AddWithValue("@Date", currentDate);
                            insertAccountCmd.Parameters.AddWithValue("@EmpId", EmployeeID);
                            insertAccountCmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);

                            // Execute the insert query
                            insertAccountCmd.ExecuteNonQuery();
                        }
                        else
                        {                          
                            string insertAccountQuery = "INSERT INTO AccountTbl (TotalOrders, Revenue, Date, CustomerPhone) VALUES (@TotalOrders, @Revenue, @Date, @CustomerPhone)";
                            SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery, con); // Pass the connection to the SqlCommand constructor
                            insertAccountCmd.Parameters.AddWithValue("@TotalOrders", totalUnit);
                            insertAccountCmd.Parameters.AddWithValue("@Revenue", grandTotal);
                            insertAccountCmd.Parameters.AddWithValue("@Date", currentDate);
                            insertAccountCmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);

                            // Execute the insert query
                            insertAccountCmd.ExecuteNonQuery();
                        }
                        

                        // Clear the order table
                        SqlCommand clearOrderCmd = new SqlCommand("DELETE FROM OrderTbl", con); // Pass the connection to the SqlCommand constructor
                        clearOrderCmd.ExecuteNonQuery();

                        MessageBox.Show("Payment successful! Order cleared.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Clear TextBox
                    OrderForm orderForm = new OrderForm();

                    orderForm.txtCustomerName.Text = "";
                    orderForm.txtCName.Text = "";
                    orderForm.txtCPhone.Text = "";
                    orderForm.txtRewards.Text = "";
                    orderForm.txtGrandTotal.Text = "";
                    orderForm.txtTotalAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Total amount is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;
            string pinNumber = txtPin.Text;

            OrderForm odf = new OrderForm();
            StaffInfoPanel sif = new StaffInfoPanel();

            if (!Customer.IsValidPhoneNumber(phoneNumber))
            {
                odf.RemoveOrder();
                sif.refreshInfo();

                return;
            }

            addRevenue();
            lblAmount.Text = "";
            txtPhone.Text = "";
            txtPin.Text = "";
            /*
            Login login = new Login();
            login.Show();
            this.Hide();
            */
            // StaffDashboard of=  new StaffDashboard();
            //   of.Show();
            //   this.Close();

        }
    }
}
