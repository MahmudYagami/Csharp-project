using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace Modern_Pharmacy_Managment_System
{
    public partial class EmployeeSalary : Form
    {
        Functions Con;

        public EmployeeSalary()
        {
            InitializeComponent();
            Con = new Functions();
            LoadSalaryData();
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

                        // Calculate the number of months due
                        int monthsDue = ((DateTime.Now.Year - joiningDate.Year) * 12) + DateTime.Now.Month - joiningDate.Month;

                        // Exclude employees with no due months
                        if (monthsDue > 0)
                        {
                            // Get the per month salary
                            float perMonthSalary = GetPerMonthSalary(empId);

                            // Calculate the total due amount
                            float totalDue = monthsDue * perMonthSalary;

                            // Append employee details to the message
                            unpaidEmployeeMessage += $"Employee ID: {empId}\n  - Per Month Salary: {perMonthSalary}\n  - Due Months: {monthsDue}\n  - Due Amount: {totalDue}\n\n";
                        }
                    }

                    // Show styled MessageBox with unpaid employee details if there are any
                    if (unpaidEmployeeMessage != "Unpaid Employees:\n\n")
                    {
                        MessageBox.Show(unpaidEmployeeMessage, "Unpaid Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("All employees have been paid.", "No Unpaid Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

                // Get the joining date of the employee
                DateTime joiningDate = GetJoiningDate(empId);

                // Calculate the number of months due
                int monthsDue = ((DateTime.Now.Year - joiningDate.Year) * 12) + DateTime.Now.Month - joiningDate.Month;

                // Get the per month salary of the employee
                float perMonthSalary = GetPerMonthSalary(empId);

                // Calculate the total due amount
                float totalDue = monthsDue * perMonthSalary;

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
                if (SalaryView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = SalaryView.SelectedRows[0];
                    int salaryId = Convert.ToInt32(selectedRow.Cells["SalaryId"].Value);

                    string deleteQuery = "DELETE FROM SalaryTbl WHERE SalaryId = " + salaryId;
                    Con.SetData(deleteQuery);

                    // Delete corresponding entry from AccountTbl
                    string deleteAccountQuery = "DELETE FROM AccountTbl WHERE SalaryId = " + salaryId;
                    Con.SetData(deleteAccountQuery);

                    MessageBox.Show("Salary record deleted successfully!", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSalaryData();
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

    }
}
