namespace KursProj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DBNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DatabaseNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(80, 20);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(216, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(80, 76);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(216, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // DBNameTextBox
            // 
            this.DBNameTextBox.Location = new System.Drawing.Point(80, 130);
            this.DBNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DBNameTextBox.Name = "DBNameTextBox";
            this.DBNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.DBNameTextBox.TabIndex = 2;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Location = new System.Drawing.Point(2, 9);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(86, 31);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(4, 79);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.Location = new System.Drawing.Point(2, 120);
            this.DatabaseNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(76, 34);
            this.DatabaseNameLabel.TabIndex = 5;
            this.DatabaseNameLabel.Text = "Название базы данных";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.DatabaseNameLabel);
            this.panel1.Controls.Add(this.LoginTextBox);
            this.panel1.Controls.Add(this.PasswordLabel);
            this.panel1.Controls.Add(this.DBNameTextBox);
            this.panel1.Controls.Add(this.UserNameLabel);
            this.panel1.Location = new System.Drawing.Point(144, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(304, 155);
            this.panel1.TabIndex = 6;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(247, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(118, 24);
            this.WelcomeLabel.TabIndex = 7;
            this.WelcomeLabel.Text = "//WELCOME";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignInButton
            // 
            this.SignInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.Location = new System.Drawing.Point(251, 228);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(114, 29);
            this.SignInButton.TabIndex = 8;
            this.SignInButton.Text = "Вход";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ExitButton.Location = new System.Drawing.Point(323, 307);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(231, 30);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выход из приложения";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 346);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DBNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label DatabaseNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

