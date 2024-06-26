﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using Modern_Pharmacy_Managment_System.Database;



namespace Modern_Pharmacy_Managment_System

{
    public partial class EmployeeSalary : Form

    {

        Functions Con;
        int Key = 0;

        public EmployeeSalary()
        {
            InitializeComponent();
            Con = new Functions();
            LoadSalaryData();
            PayDateCalender.Value = DateTime.Today;
        }

        private void LoadSalaryData()
        {
            try
            {
                string query = "SELECT * FROM SalaryTbl";
                SalaryView.DataSource = Con.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void NotificationImage_Click(object sender, EventArgs e)
        {
            try
            {

                // Query to retrieve unpaid employee IDs and their joining dates
                string query = "SELECT EmpId, EmpJoiningDate FROM EmployeeTbl WHERE EmpId NOT IN (SELECT DISTINCT EmpId FROM SalaryTbl)";

                // Retrieve unpaid employees and their joining dates
                DataTable dtUnpaidEmployees = Con.GetData(query);

                // Check if there are unpaid employees
                if (dtUnpaidEmployees.Rows.Count > 0)
                {
                    // Generate the message with unpaid employee IDs, per month salary, due months, and due amount
                    string unpaidEmployeeMessage = "Unpaid Employees:\n\n";
                    foreach (DataRow row in dtUnpaidEmployees.Rows)
                    {
                        // Get the employee ID
                        int empId = Convert.ToInt32(row["EmpId"]);

                        // Get the joining date
                        DateTime joiningDate = Convert.ToDateTime(row["EmpJoiningDate"]);

                        // Calculate the number of days since joining
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeSinceJoining = currentDate - joiningDate;
                        int daysSinceJoining = (int)timeSinceJoining.TotalDays;

                        // Calculate the number of months due (if more than 30 days since joining)
                        int monthsDue = daysSinceJoining > 30 ? ((currentDate.Year - joiningDate.Year) * 12) + currentDate.Month - joiningDate.Month : 0;

                        // Exclude employees with no due months
                        if (monthsDue > 0)
                        {
                            float perMonthSalary = GetPerMonthSalary(empId);

                            float totalDue = monthsDue * perMonthSalary;

                            // Append employee details to the message
                            unpaidEmployeeMessage += $"Employee ID: {empId}\n  - Per Month Salary: {perMonthSalary}\n  - Due Months: {monthsDue}\n  - Due Amount: {totalDue}\n\n";
                        }
                    }

                    // Create a custom form for the message box
                    Form messageForm = new Form();
                    messageForm.Text = "Unpaid Employees";
                    messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    messageForm.StartPosition = FormStartPosition.Manual;
                    messageForm.Location = new Point(100, 100);
                    messageForm.Size = new Size(700, 500);
                    Panel panel = new Panel();
                    panel.Dock = DockStyle.Right;
                    panel.AutoScroll = true;
                    messageForm.Controls.Add(panel);

                    // Create a rich text box to display the message
                    RichTextBox messageTextBox = new RichTextBox();
                    messageTextBox.Text = unpaidEmployeeMessage;
                    messageTextBox.ReadOnly = true;
                    messageTextBox.Dock = DockStyle.Fill; // Dock the text box to fill the form
                    messageTextBox.Font = new Font("Arial", 10, FontStyle.Regular); // Set the font style
                    messageTextBox.ForeColor = Color.Black; // Set the font color
                    messageTextBox.BackColor = Color.LightBlue; // Set the background color


                    // Add the text box to the form
                    messageForm.Controls.Add(messageTextBox);

                    int buttonTop = 20;
                    foreach (DataRow row in dtUnpaidEmployees.Rows)
                    {
                        // Get the employee ID
                        int empId = Convert.ToInt32(row["EmpId"]);

                        // Get the joining date
                        DateTime joiningDate = Convert.ToDateTime(row["EmpJoiningDate"]);

                        // Calculate the number of days since joining
                        DateTime currentDate = DateTime.Now;
                        TimeSpan timeSinceJoining = currentDate - joiningDate;
                        int daysSinceJoining = (int)timeSinceJoining.TotalDays;

                        // Calculate the number of months due (if more than 30 days since joining)
                        int monthsDue = daysSinceJoining > 30 ? ((currentDate.Year - joiningDate.Year) * 12) + currentDate.Month - joiningDate.Month : 0;

                        // Exclude employees with no due months
                        if (monthsDue > 0)
                        {
                            // Create a button for the employee
                            Button employeeButton = new Button();
                            employeeButton.Text = $"Employee ID: {empId}\nDue Amount: {monthsDue} months";
                            employeeButton.Tag = empId;
                            employeeButton.Width = 200;
                            employeeButton.Height = 60;
                            employeeButton.Top = buttonTop;
                            employeeButton.Left = 20;
                            employeeButton.Click += EmployeeButton_Click; // Attach click event handler

                            // Add the button to the panel
                            panel.Controls.Add(employeeButton);

                            // Update the top position for the next button
                            buttonTop += employeeButton.Height + 10;
                        }
                    }

                    // Show the custom message box
                    messageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("All employees have been paid.", "No Unpaid Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the clicked button
                Button clickedButton = (Button)sender;

                // Retrieve the employee ID from the button's Tag property
                int empId = (int)clickedButton.Tag;

                // Display the employee ID in EmpIdTxt
                EmpIdTxt.Text = empId.ToString();

                // Parse due amount from the button's text
                string buttonText = clickedButton.Text;
                string dueAmountString = buttonText.Split(new string[] { "Due Amount: " }, StringSplitOptions.None)[1].Trim().Split(' ')[0];
                int dueAmountMonths = int.Parse(dueAmountString);

                // Calculate total due amount
                float perMonthSalary = GetPerMonthSalary(empId);
                float totalDue = dueAmountMonths * perMonthSalary;

                // Display due amount in SalaryAmountTxt
                SalaryAmountTxt.Text = totalDue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }













        private float GetPerMonthSalary(int empId)
        {
            try
            {
                string query = "SELECT EmpSalary FROM EmployeeTbl WHERE EmpId = " + empId;
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToSingle(dt.Rows[0]["EmpSalary"]);
                }
                else
                {
                    throw new Exception("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching per month salary: " + ex.Message);
            }
        }

        private void SalaryPaidButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the employee ID, salary amount, and payment date from the text boxes
                int empId = int.Parse(EmpIdTxt.Text);
                float salaryAmount = float.Parse(SalaryAmountTxt.Text);
                DateTime payDate = PayDateCalender.Value;

                if (payDate.Date != DateTime.Today)
                {
                    MessageBox.Show("Salary can only be paid on the present date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the employee has already been paid on the same day
                if (IsEmployeePaidOnSameDay(empId, payDate))
                {
                    MessageBox.Show($"Employee ID: {empId} has already been paid on {payDate.ToShortDateString()}.", "Duplicate Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the joining date of the employee
                DateTime joiningDate = GetJoiningDate(empId);

                // Calculate the number of months due
                int monthsDue = ((DateTime.Now.Year - joiningDate.Year) * 12) + DateTime.Now.Month - joiningDate.Month;

                // Get the per month salary of the employee
                float perMonthSalary = GetPerMonthSalary(empId);

                // Calculate the total due amount
                float totalDue = monthsDue * perMonthSalary;

                // Check if the total due amount is greater than 0 or if the due months are less than 1
                if (totalDue <= 0 || monthsDue < 1)
                {
                    MessageBox.Show($"Employee ID: {empId} - Due is clear", "No Due", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Check if the paid amount matches the total due amount
                if (salaryAmount != totalDue)
                {
                    MessageBox.Show("Paid amount does not match the total due amount. Please pay the correct amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert salary payment into SalaryTbl
                string insertQuery = "INSERT INTO SalaryTbl (EmpId, SalaryPaidAmount, SalaryPaidDate) VALUES ({0}, {1}, '{2}')";
                insertQuery = string.Format(insertQuery, empId, salaryAmount, payDate.ToString("yyyy-MM-dd"));
                Con.SetData(insertQuery);

                // Insert salary payment details into AccountTbl
                string accountInsertQuery = "INSERT INTO AccountTbl (SalaryId, Expense, Date) VALUES ((SELECT SCOPE_IDENTITY()), {0}, '{1}')";
                accountInsertQuery = string.Format(accountInsertQuery, salaryAmount, payDate.ToString("yyyy-MM-dd"));
                Con.SetData(accountInsertQuery);

                MessageBox.Show("Salary paid successfully!", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the salary data
                LoadSalaryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEmployeePaidOnSameDay(int empId, DateTime payDate)
        {
            // Query the database to check if the employee has already been paid on the same day
            string query = "SELECT COUNT(*) FROM SalaryTbl WHERE EmpId = @EmpId AND SalaryPaidDate = @PayDate";

            int count = 0;

            try
            {
                using (var connection = DatabaseConnection.databaseConnect())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpId", empId);
                        command.Parameters.AddWithValue("@PayDate", payDate);

                        // Execute the command and get the count
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception, e.g., log or display an error message
                MessageBox.Show("Error while checking duplicate payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If count is greater than 0, it means the employee has already been paid on the same day
            return count > 0;
        }






        private DateTime GetJoiningDate(int empId)
        {
            try
            {
                string query = "SELECT EmpJoiningDate FROM EmployeeTbl WHERE EmpId = " + empId;
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToDateTime(dt.Rows[0]["EmpJoiningDate"]);
                }
                else
                {
                    throw new Exception("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching joining date: " + ex.Message);
            }
        }

        private void DeleteSalaryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EmpIdTxt.Text) || string.IsNullOrEmpty(SalaryAmountTxt.Text))
                {
                    MessageBox.Show("Please select a record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (SalaryView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = SalaryView.SelectedRows[0];
                    int salaryId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    string deleteQuery = "DELETE FROM SalaryTbl WHERE SalaryId = " + salaryId;
                    Con.SetData(deleteQuery);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete the record " + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete corresponding entry from AccountTbl
                        string deleteAccountQuery = "DELETE FROM AccountTbl WHERE SalaryId = " + salaryId;
                        Con.SetData(deleteAccountQuery);

                        MessageBox.Show("Salary record deleted successfully!", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSalaryData();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       
        private void SalaryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SalaryView.Rows[e.RowIndex];
                EmpIdTxt.Text = row.Cells[1].Value.ToString();



                SalaryAmountTxt.Text = row.Cells[2].Value.ToString();


                Key = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchTextBox.Text.Trim();

                // Check if search text is provided
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Construct the SQL query with a parameter
                    string query = "SELECT SalaryId, EmpId, SalaryPaidAmount, SalaryPaidDate " +
                                   $"FROM SalaryTbl WHERE EmpId LIKE '%{searchText}%'";

                    // Create an instance of the Functions class
                    Functions functions = new Functions();

                    // Call the GetData method from the Functions instance with the query string
                    DataTable searchResult = functions.GetData(query);

                    // Check if any employees were found
                    if (searchResult.Rows.Count > 0)
                    {
                        // Update the DataGridView with the search results
                        SalaryView.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No employees found with the provided Id.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // If search text is empty, display a message asking for input
                    MessageBox.Show("Please provide a Employee Id number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

