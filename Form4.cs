using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProj
{
    public partial class DocumentationForm : Form
    {
        DataShowForm DSF = null;
        public DocumentationForm()
        {
            InitializeComponent();
        }

        public DocumentationForm(DataShowForm f)
        {
            InitializeComponent();
            DSF = f;
            SavePathLabel.Text = "Все отчеты сохраняются в " + Application.StartupPath;
        }

        private void ExpDateButton_Click(object sender, EventArgs e)
        {
            //генерация отчета о списании по истечению срока эксплуатации
            string CurrentTime = DateTime.Now.ToString().Replace(':', '-');
            string path = Application.StartupPath + "\\Expiration Date Docs " + CurrentTime.Remove(CurrentTime.Length - 3) + ".txt";
            if (!File.Exists(path))
            {
                try
                {
                    //запись полученых результатов в файл
                    string[] items = MySQLConnection.GetExpDate().Split(',');
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine("У предметов, перечисленные ниже, истек срок эксплуатации:");
                    sw.Write(MySQLConnection.GetExpDate() + ". Всего " + items.Length.ToString() + " предметов.");
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Файл с отчетом успешно записан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //открытие полученного файла
                    Process.Start("C:\\Windows\\System32\\notepad.exe", path);
                }
                catch (Exception ex)
                {
                    if (ex is DirectoryNotFoundException | ex is NotSupportedException)
                        MessageBox.Show("Неправильно указано место записи файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex is UnauthorizedAccessException)
                        MessageBox.Show("Невозможно записать файл в данное место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Такой файл уже существует, попробуйте позже", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MissingChangeButton_Click(object sender, EventArgs e)
        {
            //генерация отчета о замене по причине утраты
            string CurrentTime = DateTime.Now.ToString().Replace(':', '-');
            string path = Application.StartupPath + "\\Missing Items Docs " + CurrentTime.Remove(CurrentTime.Length - 3) + ".txt";
            if (!File.Exists(path))
            {
                try
                {
                    //запись полученых результатов в файл
                    string[] items = MySQLConnection.GetMisItems().Split(',');
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine("Предметы, перечисленные ниже, были утеряны:");
                    sw.Write(MySQLConnection.GetMisItems() + ". Всего " + items.Length.ToString() + " предметов.");
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Файл с отчетом успешно записан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //открытие полученного файла
                    Process.Start("C:\\Windows\\System32\\notepad.exe", path);
                }
                catch (Exception ex)
                {
                    if (ex is DirectoryNotFoundException | ex is NotSupportedException)
                        MessageBox.Show("Неправильно указано место записи файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex is UnauthorizedAccessException)
                        MessageBox.Show("Невозможно записать файл в данное место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Такой файл уже существует, попробуйте позже", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OverAllButton_Click(object sender, EventArgs e)
        {
            //генерация отчета об общем количестве всех вещей разных типов
            string CurrentTime = DateTime.Now.ToString().Replace(':', '-');
            string path = Application.StartupPath + "\\All Items Docs " + CurrentTime.Remove(CurrentTime.Length - 3) + ".txt";
            if (!File.Exists(path))
            {
                try
                {
                    //запись полученых результатов в файл
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine("Количество предметов по типам:");
                    sw.Write(MySQLConnection.GetAllItems());
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Файл с отчетом успешно записан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //открытие полученного файла
                    Process.Start("C:\\Windows\\System32\\notepad.exe", path);
                }
                catch (Exception ex)
                {
                    if (ex is DirectoryNotFoundException | ex is NotSupportedException)
                        MessageBox.Show("Неправильно указано место записи файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex is UnauthorizedAccessException)
                        MessageBox.Show("Невозможно записать файл в данное место", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Такой файл уже существует, попробуйте позже", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
