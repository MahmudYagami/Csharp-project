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
            LoadSalaryData(); // Reload data when the "Salary Paid" button is clicked
        }
    }
}
