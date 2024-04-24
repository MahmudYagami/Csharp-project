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
        private string DataConnection = @"Data Source=DESKTOP-VQFABNK;Initial Catalog=PMSNew;Integrated Security=True";
        private bool rewardUsed = false;
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



        private void getRewards()
        {

            try
            {
                // Get the customer phone number from txtCPhone
                string customerPhoneNumber = txtCPhone.Text.Trim();
                

                // SQL query to select cpoints for the customer
                string query = "SELECT cpoints FROM tbCustomer WHERE cphone = @customerPhoneNumber";

                // Create a new instance of SqlConnection
                using (SqlConnection con = new SqlConnection(DataConnection))
                {
                    // Open the connection
                    con.Open();

                    // Create a new SqlCommand object
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the customerPhoneNumber parameter
                        cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                        // Execute the command to retrieve the cpoints
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Get the value of cpoints
                            int rewards = Convert.ToInt32(result);

                            // Display rewards in txtRewards
                            txtRewards.Text = rewards.ToString();
 
                        
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtCustomerName.Text.Trim();
            string query = "SELECT cname FROM tbCustomer WHERE cphone LIKE @searchText";

            try
            {
                using (SqlConnection con = new SqlConnection(DataConnection))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtCName.Text = result.ToString();
                            txtCPhone.Text = searchText;
                            getRewards();

                        }
                        else
                        {
                            txtCName.Text = "No matching customer found";
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnPay_Click_1(object sender, EventArgs e)
        {

            // Check if there are any items in the order
            if (dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("There are no items in the order to pay for.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ///////////////////////////           Rewards Points add                 ///////////////////////////

            try
            {
                // Convert totalAmount to int
                txtGrandTotal.Text = txtTotalAmount.Text;
                int totalAmount = Convert.ToInt32(txtGrandTotal.Text);

                // Calculate rewards
                int rewards = totalAmount / 2;

                // Get the customer phone number from txtCPhone
                string customerPhoneNumber = txtCPhone.Text.Trim();

                // SQL query to update cpoints for the customer
                string query = "UPDATE tbCustomer SET cpoints = cpoints + @rewards WHERE cphone = @customerPhoneNumber";

                // Create a new instance of Functions class
                Functions functions = new Functions();

                // Create a SqlCommand object and add parameters
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@rewards", rewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                // Call the insertData method to execute the query
                int rowsAffected = functions.insertData(cmd);

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    getRewards();
                    txtCustomerName.Text = "";
                    txtCName.Text = "";
                    txtCPhone.Text = "";
                    txtRewards.Text = "";
                    txtGrandTotal.Text = "";
                    txtTotalAmount.Text = "";
                    


                    MessageBox.Show("Rewards added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add rewards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // customer side panel
        }

        private void btnUseReward_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the rewards points from txtRewards
                int rewards = Convert.ToInt32(txtRewards.Text);

                // Check if rewards points is greater than or equal to 100
                if (rewards >= 100)
                {
                    // Convert txtTotalAmount to double
                    double totalAmount = Convert.ToDouble(txtTotalAmount.Text);

                    // Calculate the discount amount based on rewards points
                    double discountAmount = rewards * 0.10;

                    // Check if totalAmount is less than discountAmount
                    if (totalAmount < discountAmount)
                    {
                        // Set txtGrandTotal to 0
                        txtGrandTotal.Text = "0";


                        // Update the rewards points in the database
                        double newRewards = rewards - (totalAmount * 10);
                        UpdateRewardsPoints(newRewards);
                        txtRewards.Text = newRewards.ToString();
                    }
                    else if(totalAmount >= discountAmount)
                    {
                        // Calculate the grand total after discount
                        double grandTotal = totalAmount - discountAmount;

                        // Set txtGrandTotal to grandTotal
                        txtGrandTotal.Text = grandTotal.ToString();

                        // Update the rewards points in the database
                       
                        UpdateRewardsPoints(0);
                        txtRewards.Text = "0.0";
                    }
                }
                else
                {
                    // Insufficient rewards points
                    MessageBox.Show("Insufficient rewards points. Minimum 100 points required to use rewards.", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateRewardsPoints(double newRewards)
        {
            try
            {
                /*
                // Get the customer phone number from txtCPhone
                string customerPhoneNumber = txtCPhone.Text.Trim();

                // SQL query to update cpoints for the customer
                string query = "UPDATE tbCustomer SET cpoints = @newRewards WHERE cphone = @customerPhoneNumber";

                // Create a new instance of Functions class
                Functions functions = new Functions();

                // Create a SqlCommand object and add parameters
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@newRewards", newRewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                // Call the insertData method to execute the query
                int rowsAffected = functions.insertData(cmd);

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    // Update txtRewards with newRewards
                    txtRewards.Text = newRewards.ToString();
                }
                else
                {
                    MessageBox.Show("Failed to update rewards points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
                string customerPhoneNumber = txtCPhone.Text;

                // SQL query to update cpoints for the customer
                string query = "UPDATE tbCustomer SET cpoints =  @newRewards WHERE cphone = @customerPhoneNumber";

                // Create a new instance of Functions class
                Functions functions = new Functions();

                // Create a SqlCommand object and add parameters
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@newRewards", newRewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                // Call the insertData method to execute the query
                int rowsAffected = functions.insertData(cmd);

                if(rowsAffected > 0)
                {

                    MessageBox.Show("Rewards Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Update rewards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
