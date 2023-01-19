using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace keys
{
    internal class MySql
    {
        MySqlConnection conn = new MySqlConnection("Server=locolhost;Database=keys;port=3306;User Id=root;password=12345");

        private  void QueryEmployee() { 
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM keys.kabinet";
            DbDataReader reader = cmd.ExecuteReader();
            int empIdIndex = reader.GetOrdinal("Emp_Id");
        }
    }
}
