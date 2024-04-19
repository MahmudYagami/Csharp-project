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
        Functions con;

        public OrderForm()
        {
            InitializeComponent();
            con = new Functions();
        }
       
        private void OrderForm_Load(object sender, EventArgs e)
        {
            showProduct();
            showOrder();
            UpdateTotalAmount();

        }

        private void showProduct()
        {
            string Query = "SELECT PId, PName, PSellingPrice, PStock FROM InventoryTbl";
            dgvProduct.DataSource = con.GetData(Query);
        }       
        
        private void showOrder()
        {
            string Query = "SELECT OId, OName, OUnit, OPrice, OTotalCost FROM OrderTbl";
            dgvOrder.DataSource = con.GetData(Query);
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
                    int availableStock = Convert.ToInt32(selectedRow.Cells[3].Value);
                    decimal sellingPrice = Convert.ToDecimal(selectedRow.Cells[2].Value);
                    int unit = Convert.ToInt32(txtUnit.Text);

                    if (unit > availableStock)
                    {
                        MessageBox.Show("Not Enough available stock!!");
                        return;
                    }

                    // Calculate the total cost
                    decimal totalCost = sellingPrice * unit;

                    // Define a default date value
                    DateTime defaultDate = DateTime.Now;

                    // Insert into the OrderTbl
                    string insertOrderQuery = "INSERT INTO OrderTbl (OName, OPrice, OUnit, OTotalCost, ODate) VALUES (@OName, @OPrice, @OUnit, @OTotalCost, @ODate)";
                    SqlCommand insertCmd = new SqlCommand(insertOrderQuery);
                    insertCmd.Parameters.AddWithValue("@OName", productName);
                    insertCmd.Parameters.AddWithValue("@OPrice", sellingPrice);
                    insertCmd.Parameters.AddWithValue("@OUnit", unit);
                    insertCmd.Parameters.AddWithValue("@OTotalCost", totalCost);
                    insertCmd.Parameters.AddWithValue("@ODate", defaultDate);

                    // Execute the insert query using Functions class
                    int rowsAffectedInsert = con.insertData(insertCmd);

                    // Check if the insert was successful
                    if (rowsAffectedInsert > 0)
                    {
                        //  MessageBox.Show("Product added to cart successfully!");

                        // Refresh the product list
                        showProduct();
                        showOrder();

                        // Clear txtUnit
                        txtUnit.Text = "";

                        // Update the total amount
                        UpdateTotalAmount();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    // Decrease stock in the InventoryTbl

                    SqlCommand cmdUpdate = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock - @Unit WHERE PId = @ProductId");
                    cmdUpdate.Parameters.AddWithValue("@Unit", unit);
                    cmdUpdate.Parameters.AddWithValue("@ProductId", productId);
                    con.insertData(cmdUpdate);

                    showProduct();
                    showOrder();

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
            SqlCommand removeCmd = new SqlCommand("DELETE FROM OrderTbl WHERE OId = @OrderId");
            removeCmd.Parameters.AddWithValue("@OrderId", orderId);

            // Update PStock in InventoryTbl
            SqlCommand updateCmd = new SqlCommand("UPDATE InventoryTbl SET PStock = PStock + @OrderUnit WHERE PName = @ProductName");
            updateCmd.Parameters.AddWithValue("@OrderUnit", orderUnit);
            updateCmd.Parameters.AddWithValue("@ProductName", productName);

            try
            {
                con.insertData(removeCmd);
                con.insertData(updateCmd);
                MessageBox.Show("Medicine removed from the order.", "Medicine Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the dgvOrder
            showOrder();
            showProduct();
            UpdateTotalAmount();

        }

        private void txtSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchMedicine.Text.Trim();

            // Get the DataTable schema to find the name of the second column
            DataTable tableSchema = con.GetData("SELECT TOP 1 * FROM InventoryTbl");
            string columnName = tableSchema.Columns[1].ColumnName;

            // Build the SQL query dynamically with the column name
            string Query = $"SELECT PId, PName, PSellingPrice, PStock FROM InventoryTbl WHERE [{columnName}] LIKE '%{searchText}%'";

            // Retrieve data from the database using the dynamically generated query
            dgvProduct.DataSource = con.GetData(Query);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtCustomerName.Text.Trim();
            string query = "SELECT cname FROM tbCustomer WHERE cphone LIKE @searchText";

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ES6IRGF\MSSQLSERVER01;Initial Catalog=helloUpdated;Integrated Security=True"))
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

            // Check if there are any items in the order
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the order to pay for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ///////////////////////////// PAYMENT METHOD


            ///////////////////////////

            // Clear the order table
            SqlCommand clearOrderCmd = new SqlCommand("DELETE FROM OrderTbl");
            try
            {
                con.insertData(clearOrderCmd);
                MessageBox.Show("Payment successful! Order cleared.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the dgvOrder and product list
            showOrder();
            showProduct();
            UpdateTotalAmount();
        }
    }
}
