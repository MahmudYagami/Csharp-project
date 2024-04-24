using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class ViewSalary : Form
    {
        Functions Con;

        public ViewSalary()
        {
            InitializeComponent();
            Con = new Functions();
            EmpIdLbl.Text = Login.EmpId.ToString();
            EmpNameLbl.Text = Login.EmpName;
            ShowSalaryInformation();
        }

        private void ShowSalaryInformation()
        {
            try
            {
                // Construct the query with parameterized placeholders
                string query = "SELECT * FROM SalaryTbl WHERE EmpId = " + Login.EmpId;

                // Execute the query and get the data
                var data = Con.GetData(query);

                // Check if data is returned
                if (data != null && data.Rows.Count > 0)
                {
                    SalaryInformation.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No salary information found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
