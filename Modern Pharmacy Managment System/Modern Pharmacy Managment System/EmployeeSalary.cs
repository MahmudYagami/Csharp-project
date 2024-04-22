using System;
using System.Data;
using System.Windows.Forms;

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

        private void PaySalaryBtn_Click(object sender, EventArgs e)
        {
            // Reload data when the "Salary Paid" button is clicked
        }

        private void DeleteSalaryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = SalaryView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = SalaryView.Rows[selectedRowIndex];
                int salaryId = Convert.ToInt32(selectedRow.Cells["SalaryId"].Value);

                string deleteQuery = "DELETE FROM SalaryTbl WHERE SalaryId = " + salaryId;
                Con.SetData(deleteQuery);

                MessageBox.Show("Salary record deleted successfully!");
                LoadSalaryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {

            try
            {
                string searchText = SearchTextBox.Text.Trim();

                // If the search text is empty, reload the original table data
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadSalaryData();
                    return;
                }

                int empId = int.Parse(searchText);

                // Cast the DataSource of the DataGridView to a DataTable
                DataTable dataTable = (DataTable)SalaryView.DataSource;

                // Filter the DataTable to select rows where EmpId matches the input empId
                DataRow[] filteredRows = dataTable.Select($"EmpId = {empId}");

                // Create a new DataTable with the same schema as the original DataTable
                DataTable filteredDataTable = dataTable.Clone();

                // Add the filtered rows to the new DataTable
                foreach (DataRow row in filteredRows)
                {
                    filteredDataTable.ImportRow(row);
                }

                // Set the DataSource of the DataGridView to the filtered DataTable
                SalaryView.DataSource = filteredDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching employee: " + ex.Message);
            }
        }
    }
}
