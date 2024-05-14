using System;
using System.Data;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    public partial class AdminForgotPass : Form
    {
        Functions Con; // Assuming you have a Functions class for database operations

        public AdminForgotPass()
        {
            InitializeComponent();
            Con = new Functions(); // Initialize the Functions object
        }

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = CurrentPasswordTxt.Text;
                string newPassword = NewPasswordTxt.Text;
                string confirmNewPassword = ConfirmNewPasswordTxt.Text;

                // Check if new password and confirm new password match
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("New password and confirm new password do not match.");
                    return;
                }

                // Retrieve the admin ID based on the current password
                string adminIdQuery = "SELECT AdminId FROM AdminTbl WHERE AdminPassword = '{0}'";
                adminIdQuery = string.Format(adminIdQuery, currentPassword);
                DataTable adminIdDt = Con.GetData(adminIdQuery);

                // Check if admin exists and retrieve the admin ID
                if (adminIdDt.Rows.Count > 0)
                {
                    int adminId = Convert.ToInt32(adminIdDt.Rows[0]["AdminId"]);

                    // Update the admin's password
                    string updatePasswordQuery = "UPDATE AdminTbl SET AdminPassword = '{0}' WHERE AdminId = {1}";
                    updatePasswordQuery = string.Format(updatePasswordQuery, newPassword, adminId);
                    Con.SetData(updatePasswordQuery);

                    MessageBox.Show("Password updated successfully!");
                }
                else
                {
                    MessageBox.Show("Current password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }
    }
}
