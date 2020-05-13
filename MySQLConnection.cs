using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
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

        public static void Close ()
        {
            if (conn != null)
                conn.Close();
        }

        public static MySqlConnection GetConnection()
        {
            return conn;
        }

        public static DataSet GetDataSet (string command)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, GetTableName(command));
            return ds;
        }

        public static string GetTableName (string command)
        {
            string[] words = command.Split(' ');
            string tableName = null;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Equals("from") | words[i].ToLower().Equals("describe"))
                {
                    tableName = words[i + 1];
                    break;
                }
            }
            if (tableName == null)
                throw new ArgumentNullException("Не найдено название таблицы в запросе");
            return tableName;
        }

        public static DataTable GetTables ()
        {
            DataTable dt = conn.GetSchema("Tables").Copy();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ColumnName != "TABLE_NAME")
                {
                    dt.Columns.Remove(dt.Columns[i]);
                    i--;
                }
            }
            return dt;
        }
        public static DataTable GetColumnsInTable (string tableName)
        {
            //для колонок:
            //0, 1 - неважно
            //2 - имя таблицы
            //3 - имя колонки
            string[] rv = new string[4];
            rv[2] = tableName;
            DataTable dt = conn.GetSchema("Columns", rv).Copy();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].ColumnName == "COLUMN_NAME" | dt.Columns[i].ColumnName == "DATA_TYPE" | dt.Columns[i].ColumnName == "EXTRA") { }
                else
                {
                    dt.Columns.Remove(dt.Columns[i]);
                    i--;
                }
            }
            return dt;
        }

        public static string GetPrivileges (string dbName)
        {
            string privileges = "";
            string query = "show grants for current_user";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[0].ToString().Contains("`" + dbName + "`"))
                    privileges += rdr[0];
            }
            rdr.Close();
            if (privileges == "")
                return "все действия.";
            privileges = privileges.Replace("SELECT", "юотображение данных");
            privileges = privileges.Replace("INSERT", "юдобавление данных");
            privileges = privileges.Replace("UPDATE", "юизменение данных");
            privileges = privileges.Substring(privileges.IndexOf('ю'), privileges.LastIndexOf('х')-privileges.IndexOf('ю')+1);
            privileges = privileges.Replace('ю', '⁣');
            privileges += '.';
            return privileges;
        }

        public static string GetExpDate ()
        {
            string results = "";
            string query = "select prop_name from property where cond = \"spoiled\"";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                results += rdr[0];
                results += ", ";
            }
            rdr.Close();
            results = results.Remove(results.Length - 2);
            return results;
        }

        public static string GetMisItems ()
        {
            string results = "";
            string query = "select prop_name from property where cond = \"missing\"";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                results += rdr[0];
                results += ", ";
            }
            rdr.Close();
            results = results.Remove(results.Length - 2);
            return results;
        }

        public static string GetAllItems ()
        {
            string results = "";
            string query = "select tp.type_name, count(*) from property pt join types tp on tp.type_id = pt.type_id group by type_name";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                results += rdr[0];
                results += " - ";
                results += rdr[1];
                results += ", ";
            }
            rdr.Close();
            results = results.Remove(results.Length - 2);
            return results;
        }
    }
}
