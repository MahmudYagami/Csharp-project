using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class EmployeeSalary : Form
    {
        Functions Con;
        Timer SalaryNotificationTimer;

        public EmployeeSalary()
        {
            InitializeComponent();
            Con = new Functions();
            LoadSalaryData();
            InitializeTimer();
            SalaryView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Set selection mode to full row select
            SalaryView.MultiSelect = false; // Allow only single row selection
            SalaryView.ReadOnly = true; // Make DataGridView read-only
            SalaryView.SelectionChanged += SalaryView_SelectionChanged; // Handle selection changed event
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

        private void SalaryView_SelectionChanged(object sender, EventArgs e)
        {
            if (SalaryView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = SalaryView.SelectedRows[0];
                EmpIdTxt.Text = selectedRow.Cells["EmpId"].Value.ToString();
                SalaryAmountTxt.Text = selectedRow.Cells["SalaryPaidAmount"].Value.ToString();
                PayDateCalender.Value = Convert.ToDateTime(selectedRow.Cells["SalaryPaidDate"].Value);
            }
        }

        private void SalaryPaidButton_Click(object sender, EventArgs e)
        {
            try
            {
                int empId = int.Parse(EmpIdTxt.Text);
                float salaryAmount = float.Parse(SalaryAmountTxt.Text);
                DateTime payDate = PayDateCalender.Value;

                // Check if it's been more than 30 days since joining
                DateTime joiningDate = GetJoiningDate(empId);
                TimeSpan daysSinceJoining = payDate - joiningDate;
                if (daysSinceJoining.TotalDays < 30)
                {
                    MessageBox.Show("Salary can only be paid after 30 days of joining.");
                    return;
                }

                // Check if the employee exists
                if (!EmployeeExists(empId))
                {
                    MessageBox.Show("Employee with ID " + empId + " does not exist.");
                    return;
                }

                // Check if the salary amount matches the expected amount
                float expectedSalary = GetExpectedSalary(empId);
                if (salaryAmount != expectedSalary)
                {
                    MessageBox.Show("Salary amount does not match with the expected amount.");
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

                MessageBox.Show("Salary paid successfully!");
                LoadSalaryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private float GetExpectedSalary(int empId)
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
                throw new Exception("Error fetching expected salary: " + ex.Message);
            }
        }

        private bool EmployeeExists(int empId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpId = " + empId;
                int count = Convert.ToInt32(Con.GetData(query).Rows[0][0]);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if employee exists: " + ex.Message);
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
                    // Generate the message with unpaid employee IDs and months due
                    string unpaidEmployeeMessage = "Unpaid Employees:\n";
                    foreach (DataRow row in dtUnpaidEmployees.Rows)
                    {
                        // Calculate the number of months due
                        DateTime joiningDate = Convert.ToDateTime(row["EmpJoiningDate"]);
                        int monthsDue = ((DateTime.Now.Year - joiningDate.Year) * 12) + DateTime.Now.Month - joiningDate.Month;

                        // Append employee ID and months due to the message
                        unpaidEmployeeMessage += "Employee ID: " + row["EmpId"].ToString() + " (Months Due: " + monthsDue + ")\n";
                    }

                    // Show message box with unpaid employee details
                    MessageBox.Show(unpaidEmployeeMessage, "Unpaid Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteSalaryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalaryView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = SalaryView.SelectedRows[0];
                    int salaryId = Convert.ToInt32(selectedRow.Cells["SalaryId"].Value);

                    string deleteQuery = "DELETE FROM SalaryTbl WHERE SalaryId = " + salaryId;
                    Con.SetData(deleteQuery);

                    // Delete corresponding entry from AccountTbl
                    string deleteAccountQuery = "DELETE FROM AccountTbl WHERE SalaryId = " + salaryId;
                    Con.SetData(deleteAccountQuery);

                    MessageBox.Show("Salary record deleted successfully!");
                    LoadSalaryData();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeTimer()
        {
            SalaryNotificationTimer = new Timer();
            SalaryNotificationTimer.Interval = 24 * 60 * 60 * 1000; // 24 hours
            SalaryNotificationTimer.Tick += SalaryNotificationTimer_Tick;
            SalaryNotificationTimer.Start();
        }

        private void SalaryNotificationTimer_Tick(object sender, EventArgs e)
        {
            CheckUnpaidSalaries();
        }

        private void CheckUnpaidSalaries()
        {
            try
            {
                string query = "SELECT EmpName FROM EmployeeTbl WHERE EmpId NOT IN (SELECT DISTINCT EmpId FROM SalaryTbl)";
                DataTable dtUnpaidSalaries = Con.GetData(query);

                if (dtUnpaidSalaries.Rows.Count > 0)
                {
                    string unpaidEmployees = "";
                    foreach (DataRow row in dtUnpaidSalaries.Rows)
                    {
                        unpaidEmployees += row["EmpName"].ToString() + ", ";
                    }
                    unpaidEmployees = unpaidEmployees.TrimEnd(',', ' ');

                    //NotificationTxt.Text = "Unpaid salaries for: " + unpaidEmployees;
                    //NotificationTxt.Visible = true;
                }
                else
                {
                    //NotificationTxt.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for unpaid salaries: " + ex.Message);
            }
        }

    }
}
