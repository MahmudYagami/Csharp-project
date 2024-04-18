using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Pharmacy_Managment_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            // Application.Run(new SignUp());
              Application.Run(new DashBoard());
          //  Application.Run(new Login());
            // Application.Run(new StaffModule());
            // Application.Run(new StaffForm());
            // Application.Run(new Category());
            //Application.Run(new LeavesForm());
          // Application.Run(new StaffDashboard());
         //   Application.Run(new CustomerForm());

        }
    }
}
