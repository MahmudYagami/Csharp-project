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
        public Bkash(string Amount)
        {
            InitializeComponent();       
            lblAmount.Text = Amount;
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

                        // Insert into the accountTbl
                        string insertAccountQuery = "INSERT INTO accountTbl (Revenue, Date) VALUES (@Revenue, @Date)";
                        SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery, con); // Pass connection to the command
                        insertAccountCmd.Parameters.AddWithValue("@Revenue", grandTotal);
                        insertAccountCmd.Parameters.AddWithValue("@Date", currentDate);

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

            if (!Customer.IsValidPhoneNumber(phoneNumber))
            {
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
