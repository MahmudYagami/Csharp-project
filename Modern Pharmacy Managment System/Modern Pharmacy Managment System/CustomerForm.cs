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
using System.Data;

namespace Modern_Pharmacy_Managment_System
{
   
    public partial class CustomerForm : Form
    {
       Functions Con;
        public CustomerForm()
        {
            InitializeComponent();
            Con = new Functions();
            showCustomerForm();
          
        }

        private void showCustomerForm()
        {
            string Query = "select * from tbCustomer";
            dgvCustomer.DataSource = Con.GetData(Query);
        }

        string Key = "";


        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerManagementForm moduleForm = new CustomerManagementForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnUpdate.Enabled = false;
            moduleForm.ShowDialog();

            showCustomerForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string remove = tbSearchBox.Text;
            string Query = "delete from tbCustomer WHERE cname = '" + remove + "'";
            Query = string.Format(Query, Key);
            Con.SetData(Query);
            MessageBox.Show("Employee Deleted!!!");
            tbSearchBox.Text = "";
            showCustomerForm();
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbSearchBox.Text.Trim();
            string Query = "SELECT * FROM tbCustomer WHERE cname LIKE '%" + searchText + "%'";
            dgvCustomer.DataSource = Con.GetData(Query);
            
        }

 
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCustomer.SelectedRows[0];
                string customerName = selectedRow.Cells[1].Value.ToString();
                string customerPhone = selectedRow.Cells[2].Value.ToString();
                string customerPassword = selectedRow.Cells[3].Value.ToString();
                CustomerManagementForm cmf = new CustomerManagementForm();
                cmf.lblCId.Text = dgvCustomer.Rows[0].Cells[0].Value.ToString();
                cmf.txtCuName.Text = customerName;
                cmf.txtCPhone.Text = customerPhone;
                cmf.CustomerPassTxt.Text = customerPassword;
                cmf.txtCPhone.ReadOnly = true;
                cmf.btnSave.Enabled = false;
                cmf.btnUpdate.Enabled = true;
                cmf.ShowDialog();
          
                showCustomerForm();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tbSearchBox.Text = "";         
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbSearchBox.Text = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            Key = dgvCustomer.SelectedRows[0].Cells[1].Value.ToString();    
        }
    }
}
