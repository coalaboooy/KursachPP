using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProj
{
    public partial class QueryForm : Form
    {
        DataShowForm DSF = null;
        private string command = null;
        DataTable TablesTable = MySQLConnection.GetTables();

        public QueryForm()
        {
            InitializeComponent();
        }

        public QueryForm(DataShowForm f)
        {
            InitializeComponent();
            DSF = f;
        }

        public string GetCommand ()
        {
            return command;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            switch(QueryCreateWindow.SelectedIndex)
            {
                case 0://view
                    command += "select ";
                    foreach (string column in ViewFields.CheckedItems)
                    {
                        command += column;
                        command += ", ";
                    }
                    command = command.Remove(command.Length - 2, 1);
                    command += "from ";
                    command += Tables.SelectedItem;
                    if (ConditionSwitch.Checked)
                    {
                        try
                        {
                            command += " where ";
                            if (ConditionFields.SelectedItem == null)
                                throw new ArgumentException("Пожалуйста, выберите поле для условия");
                            command += ConditionFields.SelectedItem;
                            switch (Conditions.SelectedItem)
                            {
                                case "= (равно)":
                                    command += " = ";
                                    break;
                                case "!= (не равно)":
                                    command += " != ";
                                    break;
                                case "> (больше)":
                                    command += " > ";
                                    break;
                                case ">= (больше или равно)":
                                    command += " >= ";
                                    break;
                                case "< (меньше)":
                                    command += " < ";
                                    break;
                                case "<= (меньше или равно)":
                                    command += " <= ";
                                    break;
                                default:
                                    throw new ArgumentException("Пожалуйста, выберите условие");
                            }
                            if (ValueCheckTextBox.Text == "")
                                throw new ArgumentException("Пожалуйста, введите значение для условия");
                            command += ValueCheckTextBox.Text;
                        }
                        catch (ArgumentException AEX)
                        {
                            MessageBox.Show(AEX.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            DSF.CreateQueryButton_Click(null, null);
                        }
                    }
                    break;
                case 1://add
                    
                    break;
                case 2://modify
                    
                    break;
                case 3://delete
                    
                    break;
            }
            //command = 
            Hide();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < TablesTable.Rows.Count; i++)
                Tables.Items.Add(TablesTable.Rows[i].ItemArray[0].ToString());
        }

        private void Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable columns = MySQLConnection.GetColumnsInTable(Tables.SelectedItem.ToString());
            ViewFields.Items.Clear();
            for (int i = 0; i < columns.Rows.Count; i++)
                ViewFields.Items.Add(columns.Rows[i].ItemArray[0].ToString());
            ConditionFields.Items.Clear();
            for (int i = 0; i < columns.Rows.Count; i++)
                ConditionFields.Items.Add(columns.Rows[i].ItemArray[0].ToString());
        }

        private void ConditionSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ConditionPanel.Enabled == false)
                ConditionPanel.Enabled = true;
            else
                ConditionPanel.Enabled = false;
        }
    }
}
