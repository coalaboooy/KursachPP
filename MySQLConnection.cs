using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KursProj
{
    class MySQLConnection
    {
        private static string serverName = "localhost";
        private static string port = "3306";
        private static MySqlConnection conn = null;
        public static void Connect (string userName, string password, string dataBaseName) 
        {
            string connStr = "server=" + serverName +
            ";user=" + userName +
            ";database=" + dataBaseName +
            ";port=" + port +
            ";password=" + password + ";";
            conn = new MySqlConnection(connStr);
            conn.Open();
        }
    }
}
