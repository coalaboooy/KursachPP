using System;
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
    public partial class Form2 : Form
    {
        EntryForm ef = null;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(EntryForm f)
        {
            InitializeComponent();
            //DataTable.ReadOnly = false; Для редактирования?
            ef = f;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ef.Visible = true;
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Команды будут передаваться из новой формы, открывающейся по клику CreateQueryButton
                DataTable.DataSource = MySQLConnection.GetDataSet("select * from employee"); 
                DataTable.DataMember = MySQLConnection.GetTableName("select * from employee");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                {
                    ArgumentNullException ArgNullEx = (ArgumentNullException)ex;
                    MessageBox.Show(ArgNullEx.ParamName, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                if (ex is MySqlException)
                {
                    MySqlException sqlEx = (MySqlException)ex;
                    string msg = "Таблица " + sqlEx.Message.Split('\'')[1] + " не существует в данной базе данных";
                    MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
            }
        }

        private void CreateQueryButton_Click(object sender, EventArgs e)
        {
            //Новая форма для создания запросов
        }
    }
}
