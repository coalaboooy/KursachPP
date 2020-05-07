namespace KursProj
{
    partial class QueryForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.QueryCreateWindow = new System.Windows.Forms.TabControl();
            this.DataViewTab = new System.Windows.Forms.TabPage();
            this.ConditionSwitch = new System.Windows.Forms.CheckBox();
            this.ConditionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Conditions = new System.Windows.Forms.ComboBox();
            this.ConditionFields = new System.Windows.Forms.ComboBox();
            this.CondLabel2 = new System.Windows.Forms.Label();
            this.CondLabel1 = new System.Windows.Forms.Label();
            this.ValueCheckTextBox = new System.Windows.Forms.TextBox();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.ViewFields = new System.Windows.Forms.CheckedListBox();
            this.DataAddTab = new System.Windows.Forms.TabPage();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.DataChangeTab = new System.Windows.Forms.TabPage();
            this.DataDeleteTab = new System.Windows.Forms.TabPage();
            this.Tables = new System.Windows.Forms.ComboBox();
            this.TableListLabel = new System.Windows.Forms.Label();
            this.QueryCreateWindow.SuspendLayout();
            this.DataViewTab.SuspendLayout();
            this.ConditionPanel.SuspendLayout();
            this.DataAddTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(252, 395);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(316, 43);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить запрос";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QueryCreateWindow
            // 
            this.QueryCreateWindow.Controls.Add(this.DataViewTab);
            this.QueryCreateWindow.Controls.Add(this.DataAddTab);
            this.QueryCreateWindow.Controls.Add(this.DataChangeTab);
            this.QueryCreateWindow.Controls.Add(this.DataDeleteTab);
            this.QueryCreateWindow.Location = new System.Drawing.Point(12, 12);
            this.QueryCreateWindow.Name = "QueryCreateWindow";
            this.QueryCreateWindow.SelectedIndex = 0;
            this.QueryCreateWindow.Size = new System.Drawing.Size(652, 377);
            this.QueryCreateWindow.TabIndex = 0;
            // 
            // DataViewTab
            // 
            this.DataViewTab.Controls.Add(this.ConditionSwitch);
            this.DataViewTab.Controls.Add(this.ConditionPanel);
            this.DataViewTab.Controls.Add(this.SelectLabel);
            this.DataViewTab.Controls.Add(this.ViewFields);
            this.DataViewTab.Location = new System.Drawing.Point(4, 25);
            this.DataViewTab.Name = "DataViewTab";
            this.DataViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataViewTab.Size = new System.Drawing.Size(644, 348);
            this.DataViewTab.TabIndex = 0;
            this.DataViewTab.Text = "Отображение данных";
            this.DataViewTab.ToolTipText = "Здесь можно просмотреть сущности из таблиц";
            this.DataViewTab.UseVisualStyleBackColor = true;
            // 
            // ConditionSwitch
            // 
            this.ConditionSwitch.AutoSize = true;
            this.ConditionSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionSwitch.Location = new System.Drawing.Point(187, 18);
            this.ConditionSwitch.Name = "ConditionSwitch";
            this.ConditionSwitch.Size = new System.Drawing.Size(415, 24);
            this.ConditionSwitch.TabIndex = 3;
            this.ConditionSwitch.Text = "Отметьте, чтобы задать условие для поиска";
            this.ConditionSwitch.UseVisualStyleBackColor = true;
            this.ConditionSwitch.CheckedChanged += new System.EventHandler(this.ConditionSwitch_CheckedChanged);
            // 
            // ConditionPanel
            // 
            this.ConditionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionPanel.Controls.Add(this.label1);
            this.ConditionPanel.Controls.Add(this.Conditions);
            this.ConditionPanel.Controls.Add(this.ConditionFields);
            this.ConditionPanel.Controls.Add(this.CondLabel2);
            this.ConditionPanel.Controls.Add(this.CondLabel1);
            this.ConditionPanel.Controls.Add(this.ValueCheckTextBox);
            this.ConditionPanel.Enabled = false;
            this.ConditionPanel.Location = new System.Drawing.Point(187, 57);
            this.ConditionPanel.Name = "ConditionPanel";
            this.ConditionPanel.Size = new System.Drawing.Size(433, 279);
            this.ConditionPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите значение для проверки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Conditions
            // 
            this.Conditions.FormattingEnabled = true;
            this.Conditions.Items.AddRange(new object[] {
            "= (равно)",
            "!= (не равно)",
            "> (больше)",
            ">= (больше или равно)",
            "< (меньше)",
            "<= (меньше или равно)"});
            this.Conditions.Location = new System.Drawing.Point(234, 73);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(180, 24);
            this.Conditions.TabIndex = 6;
            // 
            // ConditionFields
            // 
            this.ConditionFields.FormattingEnabled = true;
            this.ConditionFields.Location = new System.Drawing.Point(11, 73);
            this.ConditionFields.Name = "ConditionFields";
            this.ConditionFields.Size = new System.Drawing.Size(180, 24);
            this.ConditionFields.TabIndex = 5;
            // 
            // CondLabel2
            // 
            this.CondLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CondLabel2.Location = new System.Drawing.Point(234, -1);
            this.CondLabel2.Name = "CondLabel2";
            this.CondLabel2.Size = new System.Drawing.Size(180, 75);
            this.CondLabel2.TabIndex = 4;
            this.CondLabel2.Text = "Выберите условие для проверки";
            this.CondLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CondLabel1
            // 
            this.CondLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CondLabel1.Location = new System.Drawing.Point(11, 0);
            this.CondLabel1.Name = "CondLabel1";
            this.CondLabel1.Size = new System.Drawing.Size(180, 74);
            this.CondLabel1.TabIndex = 3;
            this.CondLabel1.Text = "Выберите поле для задания условия";
            this.CondLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueCheckTextBox
            // 
            this.ValueCheckTextBox.Location = new System.Drawing.Point(190, 242);
            this.ValueCheckTextBox.Name = "ValueCheckTextBox";
            this.ValueCheckTextBox.Size = new System.Drawing.Size(238, 22);
            this.ValueCheckTextBox.TabIndex = 2;
            // 
            // SelectLabel
            // 
            this.SelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectLabel.Location = new System.Drawing.Point(21, 7);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(136, 67);
            this.SelectLabel.TabIndex = 1;
            this.SelectLabel.Text = "Выберите поля для вывода";
            this.SelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewFields
            // 
            this.ViewFields.FormattingEnabled = true;
            this.ViewFields.Location = new System.Drawing.Point(21, 77);
            this.ViewFields.Name = "ViewFields";
            this.ViewFields.Size = new System.Drawing.Size(136, 259);
            this.ViewFields.TabIndex = 0;
            // 
            // DataAddTab
            // 
            this.DataAddTab.Controls.Add(this.ValuesTextBox);
            this.DataAddTab.Controls.Add(this.FormatLabel);
            this.DataAddTab.Location = new System.Drawing.Point(4, 25);
            this.DataAddTab.Name = "DataAddTab";
            this.DataAddTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataAddTab.Size = new System.Drawing.Size(644, 348);
            this.DataAddTab.TabIndex = 1;
            this.DataAddTab.Text = "Добавление данных";
            this.DataAddTab.ToolTipText = "Здесь можно добавить сущности в таблицы";
            this.DataAddTab.UseVisualStyleBackColor = true;
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesTextBox.Location = new System.Drawing.Point(6, 139);
            this.ValuesTextBox.Multiline = true;
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(632, 203);
            this.ValuesTextBox.TabIndex = 1;
            // 
            // FormatLabel
            // 
            this.FormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormatLabel.Location = new System.Drawing.Point(7, 7);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(631, 129);
            this.FormatLabel.TabIndex = 0;
            this.FormatLabel.Text = "Введите добавляемые данные ниже в данном формате:\r\n";
            // 
            // DataChangeTab
            // 
            this.DataChangeTab.Location = new System.Drawing.Point(4, 25);
            this.DataChangeTab.Name = "DataChangeTab";
            this.DataChangeTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataChangeTab.Size = new System.Drawing.Size(644, 348);
            this.DataChangeTab.TabIndex = 2;
            this.DataChangeTab.Text = "Изменение данных";
            this.DataChangeTab.ToolTipText = "Здесь можно изменить сущности в таблицах";
            this.DataChangeTab.UseVisualStyleBackColor = true;
            // 
            // DataDeleteTab
            // 
            this.DataDeleteTab.Location = new System.Drawing.Point(4, 25);
            this.DataDeleteTab.Name = "DataDeleteTab";
            this.DataDeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataDeleteTab.Size = new System.Drawing.Size(644, 348);
            this.DataDeleteTab.TabIndex = 3;
            this.DataDeleteTab.Text = "Удаление данных";
            this.DataDeleteTab.ToolTipText = "Здесь можно удалить сущности из таблиц";
            this.DataDeleteTab.UseVisualStyleBackColor = true;
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(670, 73);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(121, 24);
            this.Tables.TabIndex = 0;
            this.Tables.SelectedIndexChanged += new System.EventHandler(this.Tables_SelectedIndexChanged);
            // 
            // TableListLabel
            // 
            this.TableListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TableListLabel.Location = new System.Drawing.Point(670, 12);
            this.TableListLabel.Name = "TableListLabel";
            this.TableListLabel.Size = new System.Drawing.Size(121, 58);
            this.TableListLabel.TabIndex = 0;
            this.TableListLabel.Text = "Выберите таблицу для работы";
            this.TableListLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableListLabel);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.QueryCreateWindow);
            this.Controls.Add(this.SaveButton);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.QueryCreateWindow.ResumeLayout(false);
            this.DataViewTab.ResumeLayout(false);
            this.DataViewTab.PerformLayout();
            this.ConditionPanel.ResumeLayout(false);
            this.ConditionPanel.PerformLayout();
            this.DataAddTab.ResumeLayout(false);
            this.DataAddTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TabControl QueryCreateWindow;
        private System.Windows.Forms.TabPage DataViewTab;
        private System.Windows.Forms.TabPage DataAddTab;
        private System.Windows.Forms.TabPage DataChangeTab;
        private System.Windows.Forms.TabPage DataDeleteTab;
        public System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.Label TableListLabel;
        private System.Windows.Forms.CheckedListBox ViewFields;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Panel ConditionPanel;
        private System.Windows.Forms.CheckBox ConditionSwitch;
        private System.Windows.Forms.Label CondLabel2;
        private System.Windows.Forms.Label CondLabel1;
        private System.Windows.Forms.TextBox ValueCheckTextBox;
        private System.Windows.Forms.ComboBox Conditions;
        private System.Windows.Forms.ComboBox ConditionFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValuesTextBox;
        private System.Windows.Forms.Label FormatLabel;
    }
}