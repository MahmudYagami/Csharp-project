using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class LeavesForm : Form
    {
        Functions Con;
        public LeavesForm()
        {
            InitializeComponent();
            Con = new Functions();
            ShowLeaveForm();
            GetEmployees();
            GetCategories();
        }

        private void ShowLeaveForm()
        {
            string Query = "select * from LeaveTbl";
            LeaveList.DataSource = Con.GetData(Query);

        }

        private void FilterLeaves()
        {
            string Query = "select * from LeaveTbl where Status='{0}'";
            Query = string.Format(Query, SearchCb.SelectedItem.ToString());
            LeaveList.DataSource = Con.GetData(Query);

        }

        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmployeeCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmployeeCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmployeeCb.DataSource = Con.GetData(Query);
        }
        private void GetCategories()
        {
            string Query = "select * from CategoryTbl";
            CategoriesCb.DisplayMember = Con.GetData(Query).Columns["CatName"].ToString();
            CategoriesCb.ValueMember = Con.GetData(Query).Columns["CatId"].ToString();
            CategoriesCb.DataSource = Con.GetData(Query);
        }
        private void EmpSaveBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesCb.SelectedIndex == -1 || EmployeeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    int Emp = Convert.ToInt32(EmployeeCb.SelectedValue.ToString());
                    int Category = Convert.ToInt32(CategoriesCb.SelectedValue.ToString());
                    string DateStart = DateStartCalender.Value.Date.ToString("yyyy-MM-dd");  
                    string DateEnd = DateEndCalender.Value.Date.ToString("yyyy-MM-dd");    


                    string DateApplied = DateTime.Today.Date.ToString();
                    //string Status = StatusCb.SelectedItem.ToString();
                    string Status = "Pending";

                    string Query = "insert into LeaveTbl values({0},{1},'{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, Emp, Category, DateStart, DateEnd, DateApplied,Status);
                    Con.SetData(Query);
                    ShowLeaveForm();
                    MessageBox.Show("Leave Added!!!");
                    



                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int Key = 0;
        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeCb.Text = LeaveList.SelectedRows[0].Cells[1].Value.ToString();
            CategoriesCb.Text = LeaveList.SelectedRows[0].Cells[2].Value.ToString();
            DateStartCalender.Text = LeaveList.SelectedRows[0].Cells[3].Value.ToString();
            DateEndCalender.Text = LeaveList.SelectedRows[0].Cells[4].Value.ToString();
            StatusCb.Text = LeaveList.SelectedRows[0].Cells[5].Value.ToString();


            if (EmployeeCb.SelectedIndex == -1)
            {
                Key = 0;

            }

            else
            {
                Key = Convert.ToInt32(LeaveList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpEditBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesCb.SelectedIndex == -1 || EmployeeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    int Emp = Convert.ToInt32(EmployeeCb.SelectedValue.ToString());
                    int Category = Convert.ToInt32(CategoriesCb.SelectedValue.ToString());
                    string DateStart = DateStartCalender.Value.Date.ToString("yyyy-MM-dd");
                    string DateEnd = DateEndCalender.Value.Date.ToString("yyyy-MM-dd");
                    string DateApplied = DateTime.Today.Date.ToString("yyyy-MM-dd");

                     string Status = StatusCb.SelectedItem.ToString();
                    //string Status = "Pending";

                    string Query = "Update LeaveTbl set Employee={0}, Category={1},DateStart='{2}',DateEnd='{3}',Status='{4}' where LId={5}";
                    Query = string.Format(Query, Emp, Category, DateStart, DateEnd, Status,Key);
                    Con.SetData(Query);
                    ShowLeaveForm();
                    MessageBox.Show("Leave Updated!!!");
                    /*EmpNameTb.Text = "";
                    EmpPhoneTb.Text = "";
                    EmpPassTb.Text = "";


                    EmpAddressTb.Text = "";*/



                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpDltBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesCb.SelectedIndex == -1 || EmployeeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Datails!!!");
                }
                else
                {
                    

                    string Query = "Delete from LeaveTbl where LId={0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowLeaveForm();
                    MessageBox.Show("Leave Deleted!!!");
                    



                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ShowLeaveForm();

        }

        private void SearchCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterLeaves();


        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            StaffForm sf = new StaffForm();
            sf.Show();
            this.Hide();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
            this.Hide();
        }
    }
}
