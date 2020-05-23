namespace KursProj
{
    partial class DocumentationForm
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
            this.DocLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpDateButton = new System.Windows.Forms.Button();
            this.MissingChangeButton = new System.Windows.Forms.Button();
            this.OverAllButton = new System.Windows.Forms.Button();
            this.SavePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DocLabel
            // 
            this.DocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DocLabel.Location = new System.Drawing.Point(13, 13);
            this.DocLabel.Name = "DocLabel";
            this.DocLabel.Size = new System.Drawing.Size(775, 60);
            this.DocLabel.TabIndex = 0;
            this.DocLabel.Text = "Здесь можно сгенерировать следующие отчеты:";
            this.DocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(18, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 169);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчет о списании по истечению срока эксплуатации";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(300, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 169);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отчет о заменах по причине утраты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(561, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 169);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчет об общем количестве имущества всех видов";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpDateButton
            // 
            this.ExpDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExpDateButton.Location = new System.Drawing.Point(22, 306);
            this.ExpDateButton.Name = "ExpDateButton";
            this.ExpDateButton.Size = new System.Drawing.Size(199, 50);
            this.ExpDateButton.TabIndex = 4;
            this.ExpDateButton.Text = "Сгенерировать";
            this.ExpDateButton.UseVisualStyleBackColor = true;
            this.ExpDateButton.Click += new System.EventHandler(this.ExpDateButton_Click);
            // 
            // MissingChangeButton
            // 
            this.MissingChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MissingChangeButton.Location = new System.Drawing.Point(304, 306);
            this.MissingChangeButton.Name = "MissingChangeButton";
            this.MissingChangeButton.Size = new System.Drawing.Size(199, 50);
            this.MissingChangeButton.TabIndex = 5;
            this.MissingChangeButton.Text = "Сгенерировать";
            this.MissingChangeButton.UseVisualStyleBackColor = true;
            this.MissingChangeButton.Click += new System.EventHandler(this.MissingChangeButton_Click);
            // 
            // OverAllButton
            // 
            this.OverAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OverAllButton.Location = new System.Drawing.Point(565, 306);
            this.OverAllButton.Name = "OverAllButton";
            this.OverAllButton.Size = new System.Drawing.Size(199, 50);
            this.OverAllButton.TabIndex = 6;
            this.OverAllButton.Text = "Сгенерировать";
            this.OverAllButton.UseVisualStyleBackColor = true;
            this.OverAllButton.Click += new System.EventHandler(this.OverAllButton_Click);
            // 
            // SavePathLabel
            // 
            this.SavePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SavePathLabel.Location = new System.Drawing.Point(19, 383);
            this.SavePathLabel.Name = "SavePathLabel";
            this.SavePathLabel.Size = new System.Drawing.Size(745, 42);
            this.SavePathLabel.TabIndex = 7;
            this.SavePathLabel.Text = "Все отчеты сохраняются в Application.StartupPath";
            // 
            // DocumentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SavePathLabel);
            this.Controls.Add(this.OverAllButton);
            this.Controls.Add(this.MissingChangeButton);
            this.Controls.Add(this.ExpDateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocLabel);
            this.Name = "DocumentationForm";
            this.Text = "Генерация отчетов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DocLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExpDateButton;
        private System.Windows.Forms.Button MissingChangeButton;
        private System.Windows.Forms.Button OverAllButton;
        private System.Windows.Forms.Label SavePathLabel;
    }
}