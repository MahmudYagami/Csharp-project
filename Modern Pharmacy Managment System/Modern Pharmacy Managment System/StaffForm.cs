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
    public partial class StaffForm : Form
    {
        Functions Con;
        int Key = 0; // For storing the selected employee's key

        public StaffForm()
        {
            InitializeComponent();
            Con = new Functions();
            ShowStaffForm();
        }

        private void ShowStaffForm()
        {
            try
            {
                string query = "select * from EmployeeTbl";
                EmployeeList.DataSource = Con.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after use
                Con.CloseConnection();
            }
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmployeeList.Rows[e.RowIndex];
                EmpNameTb.Text = row.Cells[1].Value.ToString();


                EmpGenderCb.SelectedItem = row.Cells[2].Value.ToString();
                EmpPhoneTb.Text = row.Cells[3].Value.ToString();
                EmpPassTb.Text = row.Cells[4].Value.ToString();
                EmpAddressTb.Text = row.Cells[5].Value.ToString();
                EmployeeJoiningCalender.Value = Convert.ToDateTime(row.Cells[6].Value);
                EmpSalaryBox.Text = row.Cells[7].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void EmpSaveBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all required fields are filled
                if (string.IsNullOrWhiteSpace(EmpNameTb.Text) ||
                    string.IsNullOrWhiteSpace(EmpPhoneTb.Text) ||
                    string.IsNullOrWhiteSpace(EmpPassTb.Text) ||
                    string.IsNullOrWhiteSpace(EmpAddressTb.Text) ||
                    EmpGenderCb.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(EmpSalaryBox.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve values from the textboxes and other controls
                string name = EmpNameTb.Text;
                string gender = EmpGenderCb.SelectedItem.ToString();
                string phone = EmpPhoneTb.Text;
                string pass = EmpPassTb.Text;
                string add = EmpAddressTb.Text;
                DateTime joiningDate = EmployeeJoiningCalender.Value;
                float salary = float.Parse(EmpSalaryBox.Text);

                // Continue with the save operation
                // Check if the phone number already exists in the database
                string checkPhoneQuery = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpPhone = '{0}'";
                checkPhoneQuery = string.Format(checkPhoneQuery, phone);
                int existingPhoneCount = (int)Con.ExecuteScalar(checkPhoneQuery);

                if (existingPhoneCount > 0)
                {
                    MessageBox.Show("Phone number already exists. Please enter a different phone number.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If the phone number is unique, proceed with insertion
                string insertQuery = "INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary) " +
                                     "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})";
                insertQuery = string.Format(insertQuery, name, gender, phone, pass, add, joiningDate.ToString("yyyy-MM-dd"), salary);
                Con.SetData(insertQuery);

                ShowStaffForm();
                MessageBox.Show("Employee Added!!!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void EmpEditBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key != 0)
                {
                    // Check if all required fields are filled
                    if (string.IsNullOrWhiteSpace(EmpNameTb.Text) ||
                        string.IsNullOrWhiteSpace(EmpPhoneTb.Text) ||
                        string.IsNullOrWhiteSpace(EmpPassTb.Text) ||
                        string.IsNullOrWhiteSpace(EmpAddressTb.Text) ||
                        EmpGenderCb.SelectedItem == null ||
                        string.IsNullOrWhiteSpace(EmpSalaryBox.Text))
                    {
                        MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Retrieve values from the textboxes and other controls
                    string name = EmpNameTb.Text;
                    string gender = EmpGenderCb.SelectedItem.ToString();
                    string phone = EmpPhoneTb.Text;
                    string pass = EmpPassTb.Text;
                    string add = EmpAddressTb.Text;
                    DateTime joiningDate = EmployeeJoiningCalender.Value;
                    float salary = float.Parse(EmpSalaryBox.Text);

                    // Check if the phone number is being changed to an existing number
                    string checkPhoneQuery = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpPhone = '{0}' AND EmpId != {1}";
                    checkPhoneQuery = string.Format(checkPhoneQuery, phone, Key);
                    int existingPhoneCount = (int)Con.ExecuteScalar(checkPhoneQuery);

                    if (existingPhoneCount > 0)
                    {
                        MessageBox.Show("Phone number already exists. Please enter a different phone number.", "Duplicate Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // If the phone number is unique, proceed with update
                    string query = "UPDATE EmployeeTbl SET EmpName='{0}', EmpGen='{1}', EmpPhone='{2}', EmpPass='{3}', " +
                                   "EmpAdd='{4}', EmpJoiningDate='{5}', EmpSalary={6} WHERE EmpId={7}";
                    query = string.Format(query, name, gender, phone, pass, add, joiningDate.ToString("yyyy-MM-dd"), salary, Key);
                    Con.SetData(query);

                    ShowStaffForm();
                    MessageBox.Show("Employee Updated!!!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select an employee to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void EmpDltBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key != 0)
                {
                    // Display a confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // If the user confirms deletion, proceed with deletion
                    if (result == DialogResult.Yes)
                    {
                        // Delete related rows from SalaryTbl first
                        string deleteSalaryQuery = "DELETE FROM SalaryTbl WHERE EmpId = {0}";
                        deleteSalaryQuery = string.Format(deleteSalaryQuery, Key);
                        Con.SetData(deleteSalaryQuery);

                        // Now delete from EmployeeTbl
                        string deleteEmployeeQuery = "DELETE FROM EmployeeTbl WHERE EmpId = {0}";
                        deleteEmployeeQuery = string.Format(deleteEmployeeQuery, Key);
                        Con.SetData(deleteEmployeeQuery);

                        ShowStaffForm();
                        MessageBox.Show("Employee Deleted!!!");
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void ClearFields()
        {
            EmpNameTb.Text = "";
            EmpPhoneTb.Text = "";
            EmpPassTb.Text = "";
            EmpAddressTb.Text = "";
            EmpGenderCb.SelectedIndex = -1;
            EmployeeJoiningCalender.Value = DateTime.Now;
            EmpSalaryBox.Text = "";
        }

        

       

        private void EmpDltBtnStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Key != 0)
                {
                    string query = "delete from EmployeeTbl where EmpId={0}";
                    query = string.Format(query, Key);
                    Con.SetData(query);
                    ShowStaffForm();
                    MessageBox.Show("Employee Deleted!!!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Please select an employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

       

        private void EmpGenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void LeaveNotification_Click(object sender, EventArgs e)
        {
            try
            {
                // Query to retrieve employees with pending leave requests along with their names, ids, and leave dates
                string query = @"
            SELECT EmployeeTbl.EmpId, EmployeeTbl.EmpName, LeaveTbl.Reason, LeaveTbl.DateStart, LeaveTbl.DateEnd
            FROM LeaveTbl 
            INNER JOIN EmployeeTbl ON LeaveTbl.Employee = EmployeeTbl.EmpId
            WHERE LeaveTbl.Status = 'Pending'";

                // Retrieve employees with pending leave requests, their names, and leave dates
                DataTable dtPendingLeaves = Con.GetData(query);

                // Check if there are employees with pending leave requests
                if (dtPendingLeaves.Rows.Count > 0)
                {
                    // Generate the message with employees' leave requests
                    string leaveRequestMessage = "Pending Leave Requests:\n\n";
                    foreach (DataRow row in dtPendingLeaves.Rows)
                    {
                        // Get the employee id, name, reason for leave, start date, and end date
                        int empId = Convert.ToInt32(row["EmpId"]);
                        string employeeName = row["EmpName"].ToString();
                        string reason = row["Reason"].ToString();
                        string startDate = Convert.ToDateTime(row["DateStart"]).ToString("yyyy-MM-dd");
                        string endDate = Convert.ToDateTime(row["DateEnd"]).ToString("yyyy-MM-dd");

                        // Append employee's leave request to the message
                        leaveRequestMessage += $"Employee ID: {empId}\n  - Name: {employeeName}\n  - Reason: {reason}\n  - Start Date: {startDate}\n  - End Date: {endDate}\n\n";
                    }

                    // Create a custom form for the message box
                    Form messageForm = new Form();
                    messageForm.Text = "Pending Leave Requests";
                    messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    messageForm.StartPosition = FormStartPosition.Manual;
                    messageForm.Location = new Point(100, 100); // Adjust the coordinates as needed
                    messageForm.Size = new Size(500, 400); // Set the size of the form

                    // Create a label to display the message
                    Label messageLabel = new Label();
                    messageLabel.Text = leaveRequestMessage;
                    messageLabel.AutoSize = false;
                    messageLabel.Size = new Size(480, 320); // Set the size of the label
                    messageLabel.Location = new Point(10, 10);
                    messageLabel.Font = new Font("Arial", 10, FontStyle.Regular); // Set the font style
                    messageLabel.ForeColor = Color.Black; // Set the font color
                    messageLabel.BackColor = Color.LightBlue; // Set the background color

                    // Add the label to the form
                    messageForm.Controls.Add(messageLabel);

                    // Show the custom message box
                    messageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There are no pending leave requests.", "No Pending Leaves");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void LeaveNotification2_Click(object sender, EventArgs e)
        {
           /* try
            {
                // Query to retrieve employees with pending leave requests along with their names
                string query = @"SELECT EmployeeTbl.EmpName, LeaveTbl.Reason 
                         FROM LeaveTbl 
                         INNER JOIN EmployeeTbl ON LeaveTbl.Employee = EmployeeTbl.EmpId
                         WHERE LeaveTbl.Status = 'Pending'";

                // Retrieve employees with pending leave requests and their names
                DataTable dtPendingLeaves = Con.GetData(query);

                // Check if there are employees with pending leave requests
                if (dtPendingLeaves.Rows.Count > 0)
                {
                    // Generate the message with employees' leave requests
                    string leaveRequestMessage = "Pending Leave Requests:\n\n";
                    foreach (DataRow row in dtPendingLeaves.Rows)
                    {
                        // Get the employee name and reason for leave
                        string employeeName = row["EmpName"].ToString();
                        string reason = row["Reason"].ToString();

                        // Append employee's leave request to the message
                        leaveRequestMessage += $"Employee: {employeeName}\n  - Reason: {reason}\n\n";
                    }

                    // Show MessageBox with pending leave requests
                    MessageBox.Show(leaveRequestMessage, "Pending Leave Requests", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There are no pending leave requests.", "No Pending Leaves", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }

        private void LeaveBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                LeavesForm lf = new LeavesForm();
                Point location = new Point(553, 220); // Adjust the coordinates as needed

                // Show the LeavesForm
                lf.StartPosition = FormStartPosition.Manual;
                lf.Location = location;
                lf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void SearchButton_Click_1(object sender, EventArgs e)
        {
           
        }







        

       

        private void LeaveMng_Click(object sender, EventArgs e)
        {
            try
            {
                LeavesForm lf = new LeavesForm();
                Point location = new Point(598, 250); // Adjust the coordinates as needed

                // Show the LeavesForm
                lf.StartPosition = FormStartPosition.Manual;
                lf.Location = location;
                lf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBoxGif1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           

            
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
                    string query = "SELECT EmpId, EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary " +
                                   $"FROM EmployeeTbl WHERE EmpPhone LIKE '%{searchText}%'";

                    // Create an instance of the Functions class
                    Functions functions = new Functions();

                    // Call the GetData method from the Functions instance with the query string
                    DataTable searchResult = functions.GetData(query);

                    // Check if any employees were found
                    if (searchResult.Rows.Count > 0)
                    {
                        // Update the DataGridView with the search results
                        EmployeeList.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No employees found with the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // If search text is empty, display a message asking for input
                    MessageBox.Show("Please provide a phone number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SearchButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchTextBox2.Text.Trim();

                // Check if search text is provided
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Construct the SQL query with a parameter
                    string query = "SELECT EmpId, EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary " +
                                   $"FROM EmployeeTbl WHERE EmpPhone LIKE '%{searchText}%'";

                    // Create an instance of the Functions class
                    Functions functions = new Functions();

                    // Call the GetData method from the Functions instance with the query string
                    DataTable searchResult = functions.GetData(query);

                    // Check if any employees were found
                    if (searchResult.Rows.Count > 0)
                    {
                        // Update the DataGridView with the search results
                        EmployeeList.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No employees found with the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // If search text is empty, display a message asking for input
                    MessageBox.Show("Please provide a phone number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Notification2_Click(object sender, EventArgs e)
        {
            try
            {
                // Query to retrieve employees with pending leave requests along with their names, ids, and leave dates
                string query = @"
            SELECT EmployeeTbl.EmpId, EmployeeTbl.EmpName, LeaveTbl.Reason, LeaveTbl.DateStart, LeaveTbl.DateEnd
            FROM LeaveTbl 
            INNER JOIN EmployeeTbl ON LeaveTbl.Employee = EmployeeTbl.EmpId
            WHERE LeaveTbl.Status = 'Pending'";

                // Retrieve employees with pending leave requests, their names, and leave dates
                DataTable dtPendingLeaves = Con.GetData(query);

                // Check if there are employees with pending leave requests
                if (dtPendingLeaves.Rows.Count > 0)
                {
                    // Generate the message with employees' leave requests
                    string leaveRequestMessage = "Pending Leave Requests:\n\n";
                    foreach (DataRow row in dtPendingLeaves.Rows)
                    {
                        // Get the employee id, name, reason for leave, start date, and end date
                        int empId = Convert.ToInt32(row["EmpId"]);
                        string employeeName = row["EmpName"].ToString();
                        string reason = row["Reason"].ToString();
                        string startDate = Convert.ToDateTime(row["DateStart"]).ToString("yyyy-MM-dd");
                        string endDate = Convert.ToDateTime(row["DateEnd"]).ToString("yyyy-MM-dd");

                        // Append employee's leave request to the message
                        leaveRequestMessage += $"Employee ID: {empId}\n  - Name: {employeeName}\n  - Reason: {reason}\n  - Start Date: {startDate}\n  - End Date: {endDate}\n\n";
                    }

                    // Create a custom form for the message box
                    Form messageForm = new Form();
                    messageForm.Text = "Pending Leave Requests";
                    messageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    messageForm.StartPosition = FormStartPosition.Manual;
                    messageForm.Location = new Point(100, 100); // Adjust the coordinates as needed
                    messageForm.Size = new Size(500, 400); // Set the size of the form

                    // Create a label to display the message
                    Label messageLabel = new Label();
                    messageLabel.Text = leaveRequestMessage;
                    messageLabel.AutoSize = false;
                    messageLabel.Size = new Size(480, 320); // Set the size of the label
                    messageLabel.Location = new Point(10, 10);
                    messageLabel.Font = new Font("Arial", 10, FontStyle.Regular); // Set the font style
                    messageLabel.ForeColor = Color.Black; // Set the font color
                    messageLabel.BackColor = Color.LightBlue; // Set the background color

                    // Add the label to the form
                    messageForm.Controls.Add(messageLabel);

                    // Show the custom message box
                    messageForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There are no pending leave requests.", "No Pending Leaves");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Addpanel.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                LeavesForm lf = new LeavesForm();
                Point location = new Point(553, 220); // Adjust the coordinates as needed

                // Show the LeavesForm
                lf.StartPosition = FormStartPosition.Manual;
                lf.Location = location;
                lf.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
    

