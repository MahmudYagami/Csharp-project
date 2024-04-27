using Modern_Pharmacy_Managment_System.Database;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Modern_Pharmacy_Managment_System.Classes
{
    class Customer
    {
        public static bool IsValidPhoneNumber(string phoneNumber)
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
    }

    
}
