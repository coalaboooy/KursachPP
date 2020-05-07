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
    public partial class DataShowForm : Form
    {
        EntryForm EF = null; 
        QueryForm QF = null;
        public DataShowForm()
        {
            InitializeComponent();
        }

        public DataShowForm(EntryForm f)
        {
            InitializeComponent();
            //DataTable.ReadOnly = false; Для редактирования?
            EF = f;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            EF.Visible = true;
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (QF.TypeOfCommand == 0 & QF.TypeOfCommand >= 0)
                {
                    DataTable.DataSource = MySQLConnection.GetDataSet(QF.GetQueryCommand());
                    DataTable.DataMember = MySQLConnection.GetTableName(QF.GetQueryCommand());
                }
                else if (QF.TypeOfCommand >= 0)
                {
                    MessageBox.Show("Транзакция выполнена успешно, изменено " + QF.GetNonQueryCommand().ExecuteNonQuery().ToString() + " рядов");
                }
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

        public void CreateQueryButton_Click(object sender, EventArgs e)
        {
            QF = new QueryForm(this);
            QF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получить типы колонок с помощью GetSchema
            DataTable.DataSource = MySQLConnection.GetColumnsInTable("job");
            //возможные типы:
            //varchar, small/medium/bigtext - string
            //int - int
            //float - float
            //date - почитать
        }
    }
}
