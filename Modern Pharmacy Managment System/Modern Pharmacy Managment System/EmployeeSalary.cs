﻿using System;
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

        private void PaySalaryBtn_Click(object sender, EventArgs e)
        {
            
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

        private void SearchButton_Click(object sender, EventArgs e)
        {

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
    }
}