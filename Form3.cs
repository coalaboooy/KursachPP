using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KursProj
{
    public partial class QueryForm : Form
    {
        public int TypeOfCommand = -1;
        DataShowForm DSF = null;
        private string command = null;
        private MySqlCommand cmd = null;
        DataTable TablesTable = MySQLConnection.GetTables();

        public QueryForm()
        {
            InitializeComponent();
        }

        public QueryForm(DataShowForm f)
        {
            InitializeComponent();
            DSF = f;
            cmd = new MySqlCommand();
            cmd.Connection = MySQLConnection.GetConnection();
            cmd.CommandType = CommandType.Text;
        }

        public string GetQueryCommand()
        {
            return command;
        }

        public MySqlCommand GetNonQueryCommand()
        {
            return cmd;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            switch (QueryCreateWindow.SelectedIndex)
            {
                case 0://view
                    TypeOfCommand = 0;
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
                            if (ViewConditionFields.SelectedItem == null)
                                throw new ArgumentException("Пожалуйста, выберите поле для условия");
                            command += ViewConditionFields.SelectedItem;
                            switch (ViewConditions.SelectedItem)
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
                            if (ViewTextBox.Text == "")
                                throw new ArgumentException("Пожалуйста, введите значение для условия");
                            command += "\"";
                            command += ViewTextBox.Text;
                            command += "\"";
                        }
                        catch (ArgumentException AEX)
                        {
                            MessageBox.Show(AEX.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            DSF.CreateQueryButton_Click(null, null);
                        }
                    }
                    break;
                case 1://add
                    TypeOfCommand = 1;
                    DataTable columns = MySQLConnection.GetColumnsInTable(Tables.SelectedItem.ToString());
                    cmd.CommandText += "insert into ";
                    cmd.CommandText += Tables.SelectedItem;
                    cmd.CommandText += " (";
                    for (int i = 0; i < columns.Rows.Count; i++)
                    {
                        if (columns.Rows[i].ItemArray[2].ToString() == "auto_increment")
                            continue;
                        cmd.CommandText += columns.Rows[i].ItemArray[0].ToString();
                        if (i != columns.Rows.Count - 1)
                            cmd.CommandText += ", ";
                    }
                    cmd.CommandText += ") values (";
                    string[] values = ValuesTextBox.Text.Split(';');
                    string n_value = null;
                    foreach (string value in values)
                    {
                        n_value = value.Trim(' ');
                        cmd.CommandText += "\"";
                        cmd.CommandText += n_value;
                        cmd.CommandText += "\", ";
                    }
                    cmd.CommandText = cmd.CommandText.Remove(cmd.CommandText.Length - 2);
                    cmd.CommandText += ")";
                    break;
                case 2://modify
                    //состав команды: update 
                    //table - брать выбранный элемент из списка таблиц
                    //set
                    //column_name = value - брать выбранный элемент из списка колонок и введенный текст
                    //where column_name (==, !=, >, <, <=, >=) value - добавить условие
                    TypeOfCommand = 1;
                    try
                    {
                        cmd.CommandText += "update ";
                        cmd.CommandText += Tables.SelectedItem;
                        cmd.CommandText += " set ";
                        cmd.CommandText += ModifyFields.CheckedItems[0].ToString();
                        cmd.CommandText += " = ";
                        if (ModifyValueTextBox.Text == "")
                            throw new ArgumentException("Пожалуйста, введите значение для замены");
                        cmd.CommandText += "\"";
                        cmd.CommandText += ModifyValueTextBox.Text;
                        cmd.CommandText += "\"";
                        cmd.CommandText += " where ";
                        if (ModifyConditionFields.SelectedItem == null)
                            throw new ArgumentException("Пожалуйста, выберите поле для условия");
                        cmd.CommandText += ModifyConditionFields.SelectedItem;
                        switch (ModifyConditions.SelectedItem)
                        {
                            case "= (равно)":
                                cmd.CommandText += " = ";
                                break;
                            case "!= (не равно)":
                                cmd.CommandText += " != ";
                                break;
                            case "> (больше)":
                                cmd.CommandText += " > ";
                                break;
                            case ">= (больше или равно)":
                                cmd.CommandText += " >= ";
                                break;
                            case "< (меньше)":
                                cmd.CommandText += " < ";
                                break;
                            case "<= (меньше или равно)":
                                cmd.CommandText += " <= ";
                                break;
                            default:
                                throw new ArgumentException("Пожалуйста, выберите условие");
                        }
                        if (ModifyTextBox.Text == "")
                            throw new ArgumentException("Пожалуйста, введите значение для условия");
                        cmd.CommandText += "\"";
                        cmd.CommandText += ModifyTextBox.Text;
                        cmd.CommandText += "\"";
                    }
                    catch (ArgumentException AEX)
                    {
                        MessageBox.Show(AEX.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        DSF.CreateQueryButton_Click(null, null);
                    }
                    break;
                case 3://delete

                    break;
            }
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
            ViewConditionFields.Items.Clear();
            ModifyFields.Items.Clear();
            ModifyConditionFields.Items.Clear();
            FormatLabel.Text = "Введите добавляемые данные ниже в данном формате:\n";
            for (int i = 0; i < columns.Rows.Count; i++)
            {
                ViewFields.Items.Add(columns.Rows[i].ItemArray[0].ToString());
                ViewConditionFields.Items.Add(columns.Rows[i].ItemArray[0].ToString());
                ModifyFields.Items.Add(columns.Rows[i].ItemArray[0].ToString());
                ModifyConditionFields.Items.Add(columns.Rows[i].ItemArray[0].ToString());
                if (columns.Rows[i].ItemArray[2].ToString() == "auto_increment")
                    continue;
                FormatLabel.Text += columns.Rows[i].ItemArray[0].ToString();
                FormatLabel.Text += " - ";
                FormatLabel.Text += columns.Rows[i].ItemArray[1].ToString();
                FormatLabel.Text += "; ";
            }
            FormatLabel.Text = FormatLabel.Text.Replace("varchar;", "строка;");
            FormatLabel.Text = FormatLabel.Text.Replace("tinytext;", "строка;");
            FormatLabel.Text = FormatLabel.Text.Replace("mediumtext;", "строка;");
            FormatLabel.Text = FormatLabel.Text.Replace("largetext;", "строка;");
            FormatLabel.Text = FormatLabel.Text.Replace("text;", "строк;");
            FormatLabel.Text = FormatLabel.Text.Replace("tinyint;", "целое число;");
            FormatLabel.Text = FormatLabel.Text.Replace("smallint;", "целое число;");
            FormatLabel.Text = FormatLabel.Text.Replace("mediumint;", "целое число;");
            FormatLabel.Text = FormatLabel.Text.Replace("bigint;", "целое число;");
            FormatLabel.Text = FormatLabel.Text.Replace("int;", "целое число;");
            FormatLabel.Text = FormatLabel.Text.Replace("double;", "число с точкой;");
            FormatLabel.Text = FormatLabel.Text.Replace("float;", "число с точкой;");
            FormatLabel.Text = FormatLabel.Text.Replace("date;", "дата (в формате ДД.ММ.ГГГГ);");
            FormatLabel.Text = FormatLabel.Text.Remove(FormatLabel.Text.Length - 2);
        }

        private void ConditionSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (ConditionPanel.Enabled == false)
                ConditionPanel.Enabled = true;
            else
                ConditionPanel.Enabled = false;
        }

        private void ModifyFields_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //позволяет выбрать только один из элементов
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (int index in list.CheckedIndices)
                    if (index != e.Index)
                        list.SetItemChecked(index, false);
        }
    }
}
