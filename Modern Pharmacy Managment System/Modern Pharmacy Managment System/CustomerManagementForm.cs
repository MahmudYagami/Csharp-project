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
    public partial class CustomerManagementForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ishti\OneDrive\Desktop\pro\Csharp-project\DATABASE TABLE\StaffDb.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone,cpoints)VALUES(@cname, @cphone,@cpoints)", con);
                    cm.Parameters.AddWithValue("@cname", txtCuName.Text);
                    cm.Parameters.AddWithValue("@cphone", txtCPhone.Text);
                    cm.Parameters.AddWithValue("@cpoints", 0);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtCuName.Clear();
            txtCPhone.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("UPDATE tbCustomer SET cname = @cname,cphone=@cphone WHERE cid LIKE '" + lblCId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@cname", txtCuName.Text);
                    cm.Parameters.AddWithValue("@cphone", txtCPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCuName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
