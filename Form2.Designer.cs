namespace KursProj
{
    partial class DataShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.CreateQueryButton = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteQueryButton
            // 
            this.ExecuteQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteQueryButton.Location = new System.Drawing.Point(16, 469);
            this.ExecuteQueryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.Size = new System.Drawing.Size(195, 28);
            this.ExecuteQueryButton.TabIndex = 1;
            this.ExecuteQueryButton.Text = "Выполнить запрос";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            this.ExecuteQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // CreateQueryButton
            // 
            this.CreateQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateQueryButton.Location = new System.Drawing.Point(689, 469);
            this.CreateQueryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateQueryButton.Name = "CreateQueryButton";
            this.CreateQueryButton.Size = new System.Drawing.Size(163, 28);
            this.CreateQueryButton.TabIndex = 2;
            this.CreateQueryButton.Text = "Создать запрос";
            this.CreateQueryButton.UseVisualStyleBackColor = true;
            this.CreateQueryButton.Click += new System.EventHandler(this.CreateQueryButton_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataTable.Location = new System.Drawing.Point(16, 44);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(836, 417);
            this.DataTable.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(229, 11);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(413, 29);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Результат выполнения запроса";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "TEST BUT)N";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.CreateQueryButton);
            this.Controls.Add(this.ExecuteQueryButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataShowForm";
            this.Text = "DataShowForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteQueryButton;
        private System.Windows.Forms.Button CreateQueryButton;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button button1;
    }
}