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
    public partial class ViewLeave : Form
    {
        Functions Con;
        public ViewLeave()
        {
            Con = new Functions();
            InitializeComponent();
            EmpIdLbl.Text = Login.EmpId + "";
            EmpNameLbl.Text = Login.EmpName;
            ShowLeaveForm();
            
        }
        private void ShowLeaveForm()
        {
            string Query = "select * from LeaveTbl where Employee={0}";
            Query = string.Format(Query, Login.EmpId);
            LeaveList.DataSource = Con.GetData(Query);

        }

        private void EmpIdLbl_Click(object sender, EventArgs e)
        {
            // emp id 
        }

        private void LeaveList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
