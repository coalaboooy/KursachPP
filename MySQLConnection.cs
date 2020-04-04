﻿using System;
using System.Collections.Generic;
using System.Data;
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

        public static void Close ()
        {
            if (conn != null)
                conn.Close();
        }

        /*public static StringBuilder TextCommand () //Возможно, не стоит использовать. Вместо этого попробовать отображать информацию в таблице (нужна новая форма)
        {
            string command = "SELECT * FROM employee";
            MySqlCommand sqlCommand = new MySqlCommand(command, conn);
            MySqlDataReader rdr = sqlCommand.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            int fieldNumber =  rdr.FieldCount;
            while (rdr.Read())
            {
                for (int i = 0; i < fieldNumber; i++)
                {
                    if (i == fieldNumber)
                        sb.Append(rdr[i]);
                    else
                        //sb.Append(rdr[i].ToString().PadRight(10, ' ') + "|"); Найти способ узнать максимальное кол-во символов в таблице
                        sb.Append(rdr[i]);
                }
                sb.Append("\n");
            }
            rdr.Close();
            return sb;
        }*/

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
                    tableName = words[i + 1];
            }
            if (tableName == null)
                throw new ArgumentNullException("Не найдено название таблицы в запросе");
            return tableName;
        }
    }
}
