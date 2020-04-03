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
        /* Для выполнения команды поиска (а может, и не только)
            dataGridView1.DataSource = MySQLConnection.GetDataSet("SELECT * FROM employee");
            dataGridView1.DataMember = MySQLConnection.GetTableName("SELECT * FROM employee");
        */
        EntryForm ef = null;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(EntryForm f)
        {
            InitializeComponent();
            ef = f;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ef.Visible = true;
        }
    }
}
