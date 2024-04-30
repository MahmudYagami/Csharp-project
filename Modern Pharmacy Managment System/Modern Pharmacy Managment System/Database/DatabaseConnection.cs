using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modern_Pharmacy_Managment_System.Database
{
    public abstract class DatabaseConnection
    {

       const string connectionString = @"Data Source=DESKTOP-VQFABNK;Initial Catalog=PMSnew;Integrated Security=True";
        public static SqlConnection databaseConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
