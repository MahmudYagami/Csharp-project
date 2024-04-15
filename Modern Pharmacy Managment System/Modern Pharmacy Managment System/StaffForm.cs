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

namespace Modern_Pharmacy_Managment_System
{
    public partial class StaffForm : Form
    {
        Functions Con;
        public StaffForm()
        {
            InitializeComponent();
        
            Con = new Functions();
            
            ShowStaffForm();
            
        }
        private void ShowStaffForm()
        {
            string Query = "select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void StaffFormEmployeesBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmpSaveBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == ""||EmpPhoneTb.Text==""||EmpPassTb.Text==""||EmpGenderCb.SelectedIndex==-1)
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenderCb.SelectedItem.ToString();
                    string phone = EmpPhoneTb.Text;
                    string pass = EmpPassTb.Text;
                    string Add = EmpAddressTb.Text;
                    
                    string Query = "insert into EmployeeTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Name,Gender,phone,pass,Add);
                    Con.SetData(Query);
                    ShowStaffForm();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    EmpPassTb.Text = "";
                    
                  
                    EmpAddressTb.Text = "";
                    


                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenderCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            EmpPhoneTb.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            EmpPassTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            EmpAddressTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
          
            
            if (EmpNameTb.Text == "")
            {
                Key = 0;

            }

            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }


        }

        



        private void EmpEditBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpPassTb.Text == "" || EmpGenderCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenderCb.SelectedItem.ToString();
                    string phone = EmpPhoneTb.Text;
                    string pass = EmpPassTb.Text;
                    string Add = EmpAddressTb.Text;
                    
                    string Query = "update EmployeeTbl set EmpName='{0}',EmpGen='{1}',EmpPhone='{2}',EmpPass='{3}',EmpAdd='{4}' where EmpId={5}";
                    Query = string.Format(Query, Name, Gender, phone, pass, Add,Key);
                    Con.SetData(Query);
                    ShowStaffForm();
                    MessageBox.Show("Employee Updated!!!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    EmpPassTb.Text = "";


                    EmpAddressTb.Text = "";
                    


                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void EmpDltBtnStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpPassTb.Text == "" || EmpGenderCb.SelectedIndex == -1 )
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {

                    string Query = "delete from EmployeeTbl where EmpId={0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowStaffForm();
                    MessageBox.Show("Employee Deleted!!!");
                    EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    EmpPassTb.Text = "";


                    EmpAddressTb.Text = "";
                    


                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            LeavesForm lf = new LeavesForm();
            lf.Show();
            this.Hide();
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {

            Category ct = new Category();
            ct.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
