using Modern_Pharmacy_Managment_System.Database;
using Modern_Pharmacy_Managment_System.Classes;
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



        private bool rewardUsed = false;
        private bool isCustomer = false;
        public OrderForm()
        {
            InitializeComponent();
            con = new Functions();
            Login login = Login.GetInstance();
            string customerPhone = login.getCustomerPhone();
            customerPanel.Visible = false;

            if (!string.IsNullOrEmpty(customerPhone))
            {
                // customerPhone is not empty
                lblCustomerPhone.Text = customerPhone;
                txtCustomerName.Visible = false;
                btnAdd.Visible = false;
                btnPay.Visible = false;
                customerPanel.Visible = true;
                txtCPhone.Text = customerPhone;
                isCustomer = true;
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    string query = "SELECT cname FROM tbCustomer WHERE cphone = @cphone";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@cphone", txtCPhone.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {

                        txtCName.Text = result.ToString();

                    }
                    else
                    {
                        txtCName.Text = "";
                    }
                }


            }
            else
            {
                // customerPhone is empty
                //lblCustomerPhone.Text = "Employee";
                customerPanel.Visible = false;
            }
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

        private void UpdateTotalAmount()
        {
            // Calculate the total amount
            decimal totalAmount = CalculateTotalAmount();

            // Display the total amount in the txtTotalAmount textbox
            txtTotalAmount.Text = totalAmount.ToString();
            txtGrandTotal.Text = totalAmount.ToString();

        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            // Iterate through each row in dgvOrder and sum up the OTotalCost
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells[4].Value); // OTotalCost
            }

            return totalAmount;
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
                using (var con = DatabaseConnection.databaseConnect())
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

        private void UpdateRewardsPoints(double newRewards)
        {
            try
            {
                string customerPhoneNumber = txtCPhone.Text;

                // SQL query to update cpoints for the customer
                string query = "UPDATE tbCustomer SET cpoints =  @newRewards WHERE cphone = @customerPhoneNumber";

                // Create a SqlCommand object and add parameters
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@newRewards", newRewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                // Call the insertData method to execute the query
                int rowsAffected = con.insertData(cmd);

                if (rowsAffected > 0)
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


        private int CalculateTotalUnits()
        {
            int totalUnits = 0;

            // Iterate through each row in dgvOrder and sum up the OUnit
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                totalUnits += Convert.ToInt32(row.Cells[2].Value); // OUnit
            }

            return totalUnits;
        }

        public void RemoveOrder()
        {
            try
            {
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();

                    // Fetch all rows from OrderTbl
                    string selectOrdersQuery = "SELECT OName, OUnit FROM OrderTbl";
                    SqlCommand selectOrdersCmd = new SqlCommand(selectOrdersQuery, con);

                    // Create a list to store the data
                    List<Tuple<string, int>> orders = new List<Tuple<string, int>>();

                    // Execute the query and store the results
                    using (SqlDataReader reader = selectOrdersCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString(0);
                            int orderUnit = reader.GetInt32(1);
                            orders.Add(new Tuple<string, int>(productName, orderUnit));
                        }
                    }

                    // Close the SqlDataReader before executing the next command
                    selectOrdersCmd.Dispose();

                    // Restock each medicine in InventoryTbl
                    foreach (var order in orders)
                    {
                        string productName = order.Item1;
                        int orderUnit = order.Item2;

                        // Restock the medicine in InventoryTbl
                        string restockQuery = "UPDATE InventoryTbl SET PStock = PStock + @OrderUnit WHERE PName = @ProductName";
                        SqlCommand restockCmd = new SqlCommand(restockQuery, con);
                        restockCmd.Parameters.AddWithValue("@OrderUnit", orderUnit);
                        restockCmd.Parameters.AddWithValue("@ProductName", productName);
                        restockCmd.ExecuteNonQuery();
                    }

                    // Remove all records from OrderTbl
                    string clearOrderQuery = "DELETE FROM OrderTbl";
                    SqlCommand clearOrderCmd = new SqlCommand(clearOrderQuery, con);
                    clearOrderCmd.ExecuteNonQuery();

                    MessageBox.Show("All medicines removed from the order and restocked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            CustomerManagementForm moduleForm = new CustomerManagementForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {


            int unit;
            if (!int.TryParse(txtUnit.Text, out unit))
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            if (string.IsNullOrEmpty(txtUnit.Text) || txtUnit.Text == "Amount want to buy" || unit <= 0)
            {
                MessageBox.Show("Please enter the quantity");
                return;
            }

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
                        errorMessage.Show("Failed to add product to cart.");
                        //MessageBox.Show("Failed to add product to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    warningMessage.Show("Please select a product to add to cart!");
                    // MessageBox.Show("Please select a product to add to cart!", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                using (var con = DatabaseConnection.databaseConnect())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
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
                        txtCName.Text = "Customer not found!";
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
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
                double totalAmount;
                if (rewardUsed == false)
                {
                    txtGrandTotal.Text = txtTotalAmount.Text;
                    totalAmount = Convert.ToDouble(txtGrandTotal.Text);
                }
                else
                {
                    totalAmount = Convert.ToDouble(txtGrandTotal.Text);
                }

                // Calculate rewards
                int rewards = (int)totalAmount / 2;

                // Get the customer phone number from txtCPhone
                string customerPhoneNumber = txtCPhone.Text.Trim();

                // SQL query to update cpoints for the customer
                string query = "UPDATE tbCustomer SET cpoints = cpoints + @rewards WHERE cphone = @customerPhoneNumber";
                // Create a SqlCommand object and add parameters
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@rewards", rewards);
                cmd.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);

                // Call the insertData method to execute the query
                int rowsAffected = con.insertData(cmd);

                // Check if the update was successful
                if (rowsAffected > 0)
                {
                    getRewards();

                   // MessageBox.Show("Rewards added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Failed to add rewards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /////////////////////////////                  PAYMENT METHOD         ///////////////////////////

            int totalUnits = CalculateTotalUnits();

            try
            {
                // Convert txtGrandTotal to double
                double grandTotal;

                // Check if txtGrandTotal is not empty and contains valid data
                if (double.TryParse(txtGrandTotal.Text, out grandTotal))
                {
                    // Get the current date
                    DateTime currentDate = DateTime.Now;

                    // Insert into the accountTbl

                    int EmployeeID = Login.EmpId;

                    string insertAccountQuery = "INSERT INTO AccountTbl (TotalOrders, Revenue, Date, EmpId) VALUES (@TotalOrders, @Revenue, @Date, @EmpId)";
                    SqlCommand insertAccountCmd = new SqlCommand(insertAccountQuery);
                    insertAccountCmd.Parameters.AddWithValue("@TotalOrders", totalUnits);
                    insertAccountCmd.Parameters.AddWithValue("@Revenue", grandTotal);
                    insertAccountCmd.Parameters.AddWithValue("@Date", currentDate);
                    insertAccountCmd.Parameters.AddWithValue("@EmpId", EmployeeID);

                    // Execute the insert query using Functions class
                    int rowsAffectedInsertAccount = con.insertData(insertAccountCmd);

                    // Check if the insert was successful
                    if (rowsAffectedInsertAccount > 0)
                    {
                      //  MessageBox.Show("Revenue added to account successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       // MessageBox.Show("Failed to add revenue to account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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


            /////////////////////////////////////////////////////////////////////////////////////////////////


            // Clear the order table
            SqlCommand clearOrderCmd = new SqlCommand("DELETE FROM OrderTbl");
            try
            {
                con.insertData(clearOrderCmd);
               // informationMessage.Show("Payment successful!");
                ShowCustomMessageBox("Payment successful! Order cleared.", "Neuron Pharma");

                // MessageBox.Show("Payment successful! Order cleared.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear TextBox
            txtCustomerName.Text = "";
            txtCName.Text = "";
            txtCPhone.Text = "";
            txtRewards.Text = "";
            txtGrandTotal.Text = "";
            txtTotalAmount.Text = "";

            // Refresh the dgvOrder and product list
            showOrder();
            showProduct();
            //UpdateTotalAmount();

            // update new order form
            rewardUsed = false;
        }

        private void btnUseReward_Click_1(object sender, EventArgs e)
        {
            rewardUsed = true;
               
            if (txtRewards.Text == "")
            {
                //MessageBox.Show("Choose a ")
                //informationMessage.Show("Invalid Phone Number");
                MessageBox.Show("Invalid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    else if (totalAmount >= discountAmount)
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
              //  MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBkash_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrder.SelectedRows.Count == 0)
                {
                    MessageBox.Show("There is no medicine .", "Neuron Pharma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (isCustomer == false)
                {
                    // Get the parent form (StaffDashboard)
                    StaffDashboard staffDashboard = (StaffDashboard)this.ParentForm;
                    int totalUnit = CalculateTotalUnits();

                    // Call the LoadBkashFormIntoMainPanel method of the StaffDashboard form
                    staffDashboard.LoadBkashFormIntoMainPanel(new Bkash(txtGrandTotal.Text, totalUnit, "Employee"));

                    // Hide the current form (OrderForm)
                    this.Hide();
                }
                else
                {
                    // Get the parent form (StaffDashboard)
                    CustomerDashboard db = (CustomerDashboard)this.ParentForm;
                    int totalUnit = CalculateTotalUnits();
                    // Call the LoadBkashFormIntoMainPanel method of the StaffDashboard form
                    db.LoadBkashFormIntoMainPanel(new Bkash(txtGrandTotal.Text, totalUnit, "Customer"));

                    // Hide the current form (OrderForm)
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowCustomMessageBox(string message, string title)
        {
            Form customMessageBox = new Form();
            customMessageBox.StartPosition = FormStartPosition.CenterParent;
            customMessageBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            customMessageBox.BackColor = Color.DodgerBlue;

            // Set the size of the custom message box
            customMessageBox.Size = new Size(300, 150);

            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Location = new Point(20, 20);
            label.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            customMessageBox.Controls.Add(label);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.BackColor = Color.DodgerBlue;
            okButton.ForeColor = Color.Black;
            okButton.Location = new Point(140, 60);
            okButton.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            customMessageBox.Controls.Add(okButton);

            customMessageBox.Text = title;

            customMessageBox.AcceptButton = okButton;

            DialogResult result = customMessageBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                customMessageBox.Close();
            }
        }




    }
}
