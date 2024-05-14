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
using System.Data;

namespace Modern_Pharmacy_Managment_System
{
    public partial class reqCustomerProduct : Form
    {
        private string connectionString = @"Data Source=Akid\SQLEXPRESS;Initial Catalog=PMSnew;Integrated Security=True";
        public reqCustomerProduct()
        {
            InitializeComponent();
        }

        private void sendReqbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any of the required fields are empty
                if (string.IsNullOrWhiteSpace(reqCustomerName.Text) ||
                    string.IsNullOrWhiteSpace(reqCustomerNum.Text) ||
                    string.IsNullOrWhiteSpace(reqPrdtname.Text) ||
                    string.IsNullOrWhiteSpace(reqQuantityprd.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL command to insert data into the table
                    string insertQuery = @"INSERT INTO MedicineRequestTbl (CustomerName, CustomerPhone, MedicineName, MedicineQuantity) 
                                           VALUES (@CustomerName, @CustomerPhone, @MedicineName, @MedicineQuantity)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@CustomerName", reqCustomerName.Text);
                        command.Parameters.AddWithValue("@CustomerPhone", reqCustomerNum.Text);
                        command.Parameters.AddWithValue("@MedicineName", reqPrdtname.Text);
                        command.Parameters.AddWithValue("@MedicineQuantity", reqQuantityprd.Text);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Request submited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally, clear the text boxes after successful insertion
                            reqCustomerName.Clear();
                            reqCustomerNum.Clear();
                            reqPrdtname.Clear();
                            reqQuantityprd.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to send data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
