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
using Modern_Pharmacy_Managment_System.Properties;

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
        }

        private void ShowLeaveForm()
        {
            string Query = "SELECT * FROM LeaveTbl";
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void FilterLeaves()
        {
            string Query = "SELECT * FROM LeaveTbl WHERE Status = '{0}'";
            Query = string.Format(Query, SearchCb.SelectedItem.ToString());
            LeaveList.DataSource = Con.GetData(Query);
        }

        private void GetEmployees()
        {
            string Query = "SELECT * FROM EmployeeTbl";
            EmployeeCb.DisplayMember = "EmpName";
            EmployeeCb.ValueMember = "EmpId";
            EmployeeCb.DataSource = Con.GetData(Query);
        }

        private void EmpSaveBtnLeave_Click(object sender, EventArgs e)
        {
            EmpEditBtnLeave_Click(sender, e);
        }

        int Key = 0;

        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = LeaveList.Rows[e.RowIndex];

                    // Get the value of the Reason column from the selected row
                    string reason = row.Cells["Reason"].Value.ToString();

                    // Populate the ReasonBox textbox with the reason
                    ReasonBox.Text = reason;

                    // Get the DateStart and DateEnd values from the selected row
                    DateTime dateStart = Convert.ToDateTime(row.Cells["DateStart"].Value);
                    DateTime dateEnd = Convert.ToDateTime(row.Cells["DateEnd"].Value);

                    // Set the values of the DateStartCalender and DateEndCalender controls
                    DateStartCalender.Value = dateStart;
                    DateEndCalender.Value = dateEnd;
                }

                // Get the selected employee ID from the LeaveList
                string selectedEmployeeId = LeaveList.SelectedRows[0].Cells[1].Value.ToString(); // Assuming employee ID is in the second column

                // Search for the employee ID in the ComboBox items and set the selected item accordingly
                foreach (var item in EmployeeCb.Items)
                {
                    DataRowView rowView = item as DataRowView;
                    if (rowView != null)
                    {
                        string employeeId = rowView.Row["EmpId"].ToString(); // Assuming employee ID column name is "EmpId"
                        if (employeeId == selectedEmployeeId)
                        {
                            EmployeeCb.SelectedItem = item;
                            break;
                        }
                    }
                }

                // Set the status ComboBox with the value from the LeaveList
                StatusCb.Text = LeaveList.SelectedRows[0].Cells[4].Value.ToString();

                // Set the Key for the selected row
                if (EmployeeCb.SelectedIndex == -1)
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(LeaveList.SelectedRows[0].Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void EmpEditBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Details!!!");
                }
                else
                {
                    int empId = Convert.ToInt32(EmployeeCb.SelectedValue);
                    string dateStart = DateStartCalender.Value.Date.ToString("yyyy-MM-dd");
                    string dateEnd = DateEndCalender.Value.Date.ToString("yyyy-MM-dd");
                    string status = StatusCb.SelectedItem.ToString();

                    string query = "UPDATE LeaveTbl SET Employee = @EmpId, DateStart = @DateStart, " +
                                   "DateEnd = @DateEnd, Status = @Status WHERE LId = @LeaveId";

                    SqlCommand cmd = new SqlCommand(query, Con.Connection);
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@DateStart", dateStart);
                    cmd.Parameters.AddWithValue("@DateEnd", dateEnd);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@LeaveId", Key); // Key represents the LId of the selected leave request

                    int rowsAffected = Con.insertData(cmd);

                    if (rowsAffected > 0)
                    {
                        ShowLeaveForm();
                        MessageBox.Show("Leave Updated!!!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update leave.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EmpDltBtnLeave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select the leave to delete!");
                }
                else
                {
                    // Display a confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this leave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // If the user confirms deletion, proceed with deletion
                    if (result == DialogResult.Yes)
                    {
                        string Query = "DELETE FROM LeaveTbl WHERE LId = {0}";
                        Query = string.Format(Query, Key);
                        Con.SetData(Query);
                        ShowLeaveForm();
                        MessageBox.Show("Leave Deleted!!!");
                    }
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
            Point location = new Point(553, 220); // Adjust the coordinates as needed

            // Show the Category form
            sf.StartPosition = FormStartPosition.Manual;
            sf.Location = location;
            sf.Show();
            this.Hide();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            Point location = new Point(598, 250); // Adjust the coordinates as needed

            // Show the Category form
            c.StartPosition = FormStartPosition.Manual;
            c.Location = location;
            c.Show();
            this.Hide();
        }

        private void DateEndCalender_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
