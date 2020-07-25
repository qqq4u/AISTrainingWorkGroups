using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISWorkGroup.Model
{
    public static class DBConnector
    {
        public static string connectionString = "server=127.0.0.1;user=root;password=dashasofia2;database=workgroups";
        public static MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
        public static MySqlCommand mySqlCommand = new MySqlCommand();
    }
}
