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

      SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ES6IRGF\MSSQLSERVER01;Initial Catalog=PMS;Integrated Security=True");

      

      SqlCommand cm = new SqlCommand();



        public CustomerManagementForm()
        {
            InitializeComponent(); 
       
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {

        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Validate phone number length and start
            if (phoneNumber.Length != 11 || !phoneNumber.StartsWith("01"))
            {
                MessageBox.Show("Please enter a valid phone number starting with '01' and having exactly 11 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate SIM company (third digit)
            char thirdDigit = phoneNumber[2];
            if (!(thirdDigit == '5' || thirdDigit == '3' || thirdDigit == '7' || thirdDigit == '9' || thirdDigit == '8' || thirdDigit == '6'))
            {
                MessageBox.Show("Please enter a valid phone number with a supported SIM company (third digit can be 5, 3, 7, 9, 8, or 6).", "Invalid SIM Company", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate all digits
            foreach (char digit in phoneNumber.Substring(2))
            {
                if (!char.IsDigit(digit))
                {
                    MessageBox.Show("Please enter a valid phone number containing only digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        

        public void Clear()
        {
            txtCuName.Clear();
            txtCPhone.Clear();
        }

      

       
        private void txtCuName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = txtCPhone.Text.Trim();
                if (!IsValidPhoneNumber(phoneNumber))
                {
                    return;
                }

                // Continue saving if phone number is valid
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone,cpassword,cpoints)VALUES(@cname, @cphone,@cpassword,@cpoints)", con);
                    cm.Parameters.AddWithValue("@cname", txtCuName.Text);

                    cm.Parameters.AddWithValue("@cphone", phoneNumber);
                    cm.Parameters.AddWithValue("@cpassword", CustomerPassTxt.Text);
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
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = txtCPhone.Text.Trim();
                if (!IsValidPhoneNumber(phoneNumber))
                {
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cm = new SqlCommand("UPDATE tbCustomer SET cname = @cname,cphone=@cphone,cpassword=@cpassword WHERE cid LIKE '" + lblCId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@cname", txtCuName.Text);
                    cm.Parameters.AddWithValue("@cphone", txtCPhone.Text);
                    cm.Parameters.AddWithValue("@cpassword", CustomerPassTxt.Text);
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
    }
}
