﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        }
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmployeeList.Rows[e.RowIndex];
                EmpNameTb.Text = row.Cells["EmpName"].Value.ToString();


                EmpGenderCb.SelectedItem = row.Cells["EmpGen"].Value.ToString();
                EmpPhoneTb.Text = row.Cells["EmpPhone"].Value.ToString();
                EmpPassTb.Text = row.Cells["EmpPass"].Value.ToString();
                EmpAddressTb.Text = row.Cells["EmpAdd"].Value.ToString();
                EmployeeJoiningCalender.Value = Convert.ToDateTime(row.Cells["EmpJoiningDate"].Value);
                EmpSalaryBox.Text = row.Cells["EmpSalary"].Value.ToString();

                Key = Convert.ToInt32(row.Cells["EmpId"].Value);
            }
        }

        private void EmpSaveBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                string name = EmpNameTb.Text;
                string gender = EmpGenderCb.SelectedItem != null ? EmpGenderCb.SelectedItem.ToString() : "";
                string phone = EmpPhoneTb.Text;
                string pass = EmpPassTb.Text;
                string add = EmpAddressTb.Text;
                DateTime joiningDate = EmployeeJoiningCalender.Value;
                float salary = float.Parse(EmpSalaryBox.Text);

                string query = "insert into EmployeeTbl (EmpName, EmpGen, EmpPhone, EmpPass, EmpAdd, EmpJoiningDate, EmpSalary) " +
                               "values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})";
                query = string.Format(query, name, gender, phone, pass, add, joiningDate.ToString("yyyy-MM-dd"), salary);
                Con.SetData(query);

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
                    string name = EmpNameTb.Text;
                    string gender = EmpGenderCb.SelectedItem != null ? EmpGenderCb.SelectedItem.ToString() : "";
                    string phone = EmpPhoneTb.Text;
                    string pass = EmpPassTb.Text;
                    string add = EmpAddressTb.Text;
                    DateTime joiningDate = EmployeeJoiningCalender.Value;
                    float salary = float.Parse(EmpSalaryBox.Text);

                    string query = "update EmployeeTbl set EmpName='{0}', EmpGen='{1}', EmpPhone='{2}', EmpPass='{3}', " +
                                   "EmpAdd='{4}', EmpJoiningDate='{5}', EmpSalary={6} where EmpId={7}";
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

        private void EmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmployeeList.Rows[e.RowIndex];
                EmpNameTb.Text = row.Cells["EmpName"].Value.ToString();
                EmpGenderCb.SelectedItem = row.Cells["EmpGen"].Value.ToString();
                EmpPhoneTb.Text = row.Cells["EmpPhone"].Value.ToString();
                EmpPassTb.Text = row.Cells["EmpPass"].Value.ToString();
                EmpAddressTb.Text = row.Cells["EmpAdd"].Value.ToString();
                EmployeeJoiningCalender.Value = Convert.ToDateTime(row.Cells["EmpJoiningDate"].Value);
                EmpSalaryBox.Text = row.Cells["EmpSalary"].Value.ToString();

                Key = Convert.ToInt32(row.Cells["EmpId"].Value);
            }
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
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


    }
}
