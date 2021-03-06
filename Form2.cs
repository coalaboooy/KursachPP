﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KursProj
{
    public partial class DataShowForm : Form
    {
        EntryForm EF = null; 
        QueryForm QF = null;
        DocumentationForm DF = null;
        public DataShowForm()
        {
            InitializeComponent();
        }

        public DataShowForm(EntryForm f, string DBName)
        {
            InitializeComponent();
            EF = f;
            PrivilegesLabel.Text = "Вы вошли как ";
            PrivilegesLabel.Text += EF.GetRole();
            PrivilegesLabel.Text += ". Вам доступны следующие действия: ";
            PrivilegesLabel.Text += MySQLConnection.GetPrivileges(DBName);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            EF.Visible = true;
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                //выполнение команды
                if (QF.TypeOfCommand == 0)
                {
                    //загрузка результатов в таблицу для отображения
                    DataTable.DataSource = MySQLConnection.GetDataSet(QF.GetQueryCommand());
                    DataTable.DataMember = MySQLConnection.GetTableName(QF.GetQueryCommand());
                }
                else if (QF.TypeOfCommand == 1)
                {
                    //выполнение транзакции и вывод результатов
                    MessageBox.Show("Транзакция выполнена успешно, изменено " + QF.GetNonQueryCommand().ExecuteNonQuery().ToString() + " рядов");
                }
            }
            catch (Exception ex)
            {
                //обработка исключений разного типа
                if (ex is ArgumentNullException)
                {
                    ArgumentNullException ArgNullEx = (ArgumentNullException)ex;
                    MessageBox.Show(ArgNullEx.ParamName, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                if (ex is MySqlException)
                {
                    MySqlException sqlEx = (MySqlException)ex;
                    string msg = "Unknown error: " + sqlEx.Message;
                    if (sqlEx.Message.Contains("Column count"))
                        msg = "Данные были введены неправильно. Проверьте ввод, разделителем является ';'.";
                    if (sqlEx.Message.Contains("FOREIGN KEY") & sqlEx.Message.Contains("delete"))
                        msg = "Невозможно удалить запись. На поле " + sqlEx.Message.Split('`')[7]
                            + " ссылается запись в таблице " + sqlEx.Message.Split('`')[3] + ", сначала удалите ее.";
                    if (sqlEx.Message.Contains("FOREIGN KEY") & sqlEx.Message.Contains("add"))
                        msg = "Невозможно добавить запись. Поле " + sqlEx.Message.Split('`')[11]
                            + " с введенным значением не существует в таблице " + sqlEx.Message.Split('`')[9] + ", сначала добавьте его.";
                    if (sqlEx.Message.Contains("command"))
                        msg = "У вас недостаточно прав для выполнения запроса " + sqlEx.Message.Split(' ')[0]
                            + ". Обратитесь за помощью к администратору базы данных.";
                        MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Сначала составьте запрос", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
            }
        }

        public void CreateQueryButton_Click(object sender, EventArgs e)
        {
            QF = new QueryForm(this);
            QF.Show();
        }

        private void GenDocButton_Click(object sender, EventArgs e)
        {
            DF = new DocumentationForm(this);
            DF.Show();
        }
    }
}
