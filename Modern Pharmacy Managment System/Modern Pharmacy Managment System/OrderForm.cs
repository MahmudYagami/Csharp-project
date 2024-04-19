using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Modern_Pharmacy_Managment_System
{
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFABNK;Initial Catalog=hello;Integrated Security=True");

        public OrderForm()
        {
            InitializeComponent();

            
        }
       
        private void OrderForm_Load(object sender, EventArgs e)
        {
            showProduct();
            showOrder();
            UpdateTotalAmount();

        }

        private void showProduct()
        {
           
            SqlCommand cm = new SqlCommand("SELECT PId, PName, PSellingPrice, PStock FROM InventoryTbl", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cm.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvProduct.DataSource = dt;

        }       
        
        private void showOrder()
        {
           
            SqlCommand cm = new SqlCommand("SELECT OId, OName, OUnit, OPrice, OTotalCost FROM OrderTbl", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cm.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dgvOrder.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerManagementForm moduleForm = new CustomerManagementForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
            
            // showCustomer();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count > 0)
            {/*
                if (InsertOrderInfo())
                {
                  //  txtBoxTotalPurchage.Text = null;
                 //   cartProducts.Clear();
                    dgvOrder.Rows.Clear();
                }
                */
            }
            else
            {
                MessageBox.Show("Please add products to the cart first", "No Items in Cart!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTotalAmount()
        {
            // Calculate the total amount
            decimal totalAmount = CalculateTotalAmount();

            // Display the total amount in the txtTotalAmount textbox
            txtTotalAmount.Text = totalAmount.ToString();
        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            // Iterate through each row in dgvOrder and sum up the OTotalCost
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["OTotalCost"].Value);
            }

            return totalAmount;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];

                    // Extract the required information
                    int productId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string productName = selectedRow.Cells[1].Value.ToString();
                    decimal sellingPrice = Convert.ToDecimal(selectedRow.Cells[2].Value);
                    int unit = Convert.ToInt32(txtUnit.Text); // Assuming txtUnit is the textBox for unit

                    // Calculate the total cost
                    decimal totalCost = sellingPrice * unit;

                    // Define a default date value
                    DateTime defaultDate = DateTime.Now;

                    // Insert into the OrderTbl
                    SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl (OName, OPrice, OUnit, OTotalCost, ODate) VALUES (@OName, @OPrice, @OUnit, @OTotalCost, @ODate)", con);
                    cmd.Parameters.AddWithValue("@OName", productName);
                    cmd.Parameters.AddWithValue("@OPrice", sellingPrice);
                    cmd.Parameters.AddWithValue("@OUnit", unit);
                    cmd.Parameters.AddWithValue("@OTotalCost", totalCost);
                    cmd.Parameters.AddWithValue("@ODate", defaultDate);

                    // Decrease stock in the InventoryTbl
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock - @Unit WHERE PId = @ProductId", con);
                    cmdUpdate.Parameters.AddWithValue("@Unit", unit);
                    cmdUpdate.Parameters.AddWithValue("@ProductId", productId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product added to cart successfully!");

                    // Refresh the product list
                    showProduct();
                    showOrder();

                   
                    // clearing txtUnit

                    txtUnit.Text = "";

                    // Update the total amount

                    UpdateTotalAmount();

                }
                else
                {
                    MessageBox.Show("Please select a product to add to cart!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected in the dgvOrder
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a medicine to remove.", "No Medicine Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dgvOrder.SelectedRows[0];

            // Extract the order details
            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string productName = Convert.ToString(selectedRow.Cells[1].Value);
            int orderUnit = Convert.ToInt32(selectedRow.Cells[2].Value);

            // Remove the order from OrderTbl
            SqlCommand removeCmd = new SqlCommand("DELETE FROM OrderTbl WHERE OId = @OrderId", con);
            removeCmd.Parameters.AddWithValue("@OrderId", orderId);

            // Update PStock in InventoryTbl
            SqlCommand updateCmd = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock + @OrderUnit WHERE PName = @ProductName", con);
            updateCmd.Parameters.AddWithValue("@OrderUnit", orderUnit);
            updateCmd.Parameters.AddWithValue("@ProductName", productName);

            try
            {
                con.Open();
                removeCmd.ExecuteNonQuery();
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Medicine removed from the order.", "Medicine Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            // Refresh the dgvOrder
            showOrder();
            showProduct();
            UpdateTotalAmount();

        }

        private void txtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMedicine.Text.Trim();
            string query = "SELECT PId, PName, PSellingPrice, PStock FROM InventoryTbl WHERE PName LIKE @searchText";
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFABNK;Initial Catalog=hello;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cm = new SqlCommand(query, con))
                    {
                        cm.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        SqlDataReader sdr = cm.ExecuteReader();
                        dt.Load(sdr);
                    }
                }

                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtCustomerName.Text.Trim();
            string query = "SELECT cname FROM tbCustomer WHERE cphone LIKE @searchText";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFABNK;Initial Catalog=hello;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            lblSuggestionName.Text = result.ToString();
                        }
                        else
                        {
                            lblSuggestionName.Text = "No matching customer found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void lblSuggestionName_Click_1(object sender, EventArgs e)
        {
            // When lblSuggestionName is clicked, populate txtCustomerPhone with the full phone number
            txtCustomerName.Text = lblSuggestionName.Text;
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Convert the txtTotalAmount text to a decimal value
                decimal totalAmount = decimal.Parse(txtTotalAmount.Text);

                // Update the income in the AccountTbl
                string updateQuery = "UPDATE AccountTbl SET Income = Income + @totalAmount";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VQFABNK;Initial Catalog=hello;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Income updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update income.");
                        }
                    }
                }

                dgvOrder.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
