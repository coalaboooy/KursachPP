namespace KursProj
{
    partial class Form2
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
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteQueryButton
            // 
            this.ExecuteQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExecuteQueryButton.Location = new System.Drawing.Point(12, 381);
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.Size = new System.Drawing.Size(146, 23);
            this.ExecuteQueryButton.TabIndex = 1;
            this.ExecuteQueryButton.Text = "Выполнить запрос";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            this.ExecuteQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // CreateQueryButton
            // 
            this.CreateQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateQueryButton.Location = new System.Drawing.Point(517, 381);
            this.CreateQueryButton.Name = "CreateQueryButton";
            this.CreateQueryButton.Size = new System.Drawing.Size(122, 23);
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
            this.DataTable.Location = new System.Drawing.Point(12, 36);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(627, 339);
            this.DataTable.TabIndex = 0;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(172, 9);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(324, 24);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Результат выполнения запроса";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 410);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.CreateQueryButton);
            this.Controls.Add(this.ExecuteQueryButton);
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}