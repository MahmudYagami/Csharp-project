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
        public Bkash(string Amount, int totalUnit)
        {
            InitializeComponent();       
            lblAmount.Text = Amount;
            lblUnit.Text = totalUnit.ToString();
            lblUnit.Visible = false;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void addRevenue()
        {
            try
            {
                // Initialize SqlConnection with the connection string
                using (var con = DatabaseConnection.databaseConnect())
                {
                    // Convert lblAmount text to double
                    double grandTotal;

                    // Check if lblAmount text is not empty and contains valid data
                    if (double.TryParse(lblAmount.Text, out grandTotal))
                    {
                        // Get the current date
                        DateTime currentDate = DateTime.Now;

                        // Open the connection
                        con.Open();

                        int totalUnit = int.Parse(lblUnit.Text);
                        // Insert into the accountTbl
                        int EmployeeID = Login.EmpId;

                        string insertAccountQuery = "INSERT INTO AccountTbl (TotalOrders, Revenue, Date, EmpId) VALUES (@TotalOrders, @Revenue, @Date, @EmpId)";
                        SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery);
                        insertAccountCmd.Parameters.AddWithValue("@TotalOrders", totalUnit);
                        insertAccountCmd.Parameters.AddWithValue("@Revenue", grandTotal);
                        insertAccountCmd.Parameters.AddWithValue("@Date", currentDate);
                        insertAccountCmd.Parameters.AddWithValue("@EmpId", EmployeeID);

                        // Execute the insert query
                        insertAccountCmd.ExecuteNonQuery();
                        // Close the connection
                        //con.Close();

                        // Clear the order table

                        try
                        {
                            
                              //con.Open();
                                SqlCommand clearOrderCmd = new SqlCommand("DELETE FROM OrderTbl", con); // Pass the connection to the SqlCommand constructor
                                clearOrderCmd.ExecuteNonQuery();
                                con.Close();

                                MessageBox.Show("Payment successful! Order cleared.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {

                            con.Close();
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
            /*
            Login login = new Login();
            login.Show();
            this.Hide();
            */
            StaffDashboard of=  new StaffDashboard();
            of.Show();
            this.Close();

        }
    }
}
