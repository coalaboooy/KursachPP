﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KursProj
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MySQLConnection.Close();
            Application.Exit();
        }

        public string GetRole ()
        {
            string role = "unknown role";
            switch (LoginTextBox.Text)
            {
                case "root":
                    role = "администратор";
                    break;
                case "user":
                    role = "пользователь";
                    break;
                case "guest":
                    role = "гость";
                    break;
            }
            return role;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                MySQLConnection.Connect(LoginTextBox.Text, PasswordTextBox.Text, DBNameTextBox.Text);
                DataShowForm DSF = new DataShowForm(this, DBNameTextBox.Text);
                DSF.Show();
                Hide();
            }
            catch (MySqlException MSQLEx)
            {
                if (MSQLEx.Message.Contains("denied"))
                    MessageBox.Show("Пользователь с указанными логином и паролем не зарегестрирован в системе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                else
                    MessageBox.Show("Указанной базы данных не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }
    }
}
