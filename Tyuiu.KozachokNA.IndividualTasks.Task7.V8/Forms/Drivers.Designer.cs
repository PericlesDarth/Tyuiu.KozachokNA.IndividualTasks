namespace Tyuiu.KozachokNA.IndividualTasks.Task7.V8
{
    partial class Drivers
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
            DriversOpenFile = new Button();
            DriversSaveFile = new Button();
            DriversTable = new DataGridView();
            DriversSearchField = new TextBox();
            DriversSearch = new Button();
            DriversStatistics = new GroupBox();
            AvrMoney = new TextBox();
            AvrYears = new TextBox();
            Counter = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            DriversRefresh = new Button();
            DriversAddRow = new Button();
            DriversDeleteRow = new Button();
            DriversAddRowField = new TextBox();
            DriversDeleteRowField = new TextBox();
            Number = new DataGridViewTextBoxColumn();
            NameSurname = new DataGridViewTextBoxColumn();
            DoB = new DataGridViewTextBoxColumn();
            Years = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DriversTable).BeginInit();
            DriversStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // DriversOpenFile
            // 
            DriversOpenFile.Location = new Point(12, 12);
            DriversOpenFile.Name = "DriversOpenFile";
            DriversOpenFile.Size = new Size(252, 34);
            DriversOpenFile.TabIndex = 2;
            DriversOpenFile.Text = "Open file";
            DriversOpenFile.UseVisualStyleBackColor = true;
            DriversOpenFile.Click += OpenFile_Click;
            // 
            // DriversSaveFile
            // 
            DriversSaveFile.Location = new Point(293, 12);
            DriversSaveFile.Name = "DriversSaveFile";
            DriversSaveFile.Size = new Size(112, 34);
            DriversSaveFile.TabIndex = 3;
            DriversSaveFile.Text = "Save file";
            DriversSaveFile.UseVisualStyleBackColor = true;
            DriversSaveFile.Click += SaveFile_Click;
            // 
            // DriversTable
            // 
            DriversTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DriversTable.Columns.AddRange(new DataGridViewColumn[] { Number, NameSurname, DoB, Years, Money });
            DriversTable.Location = new Point(411, 12);
            DriversTable.Name = "DriversTable";
            DriversTable.RowHeadersWidth = 62;
            DriversTable.Size = new Size(665, 538);
            DriversTable.TabIndex = 4;
            // 
            // DriversSearchField
            // 
            DriversSearchField.Location = new Point(12, 82);
            DriversSearchField.Name = "DriversSearchField";
            DriversSearchField.Size = new Size(252, 31);
            DriversSearchField.TabIndex = 5;
            // 
            // DriversSearch
            // 
            DriversSearch.Location = new Point(293, 79);
            DriversSearch.Name = "DriversSearch";
            DriversSearch.Size = new Size(112, 34);
            DriversSearch.TabIndex = 6;
            DriversSearch.Text = "Найти?";
            DriversSearch.UseVisualStyleBackColor = true;
            DriversSearch.Click += DriversSearch_Click;
            // 
            // DriversStatistics
            // 
            DriversStatistics.Controls.Add(AvrMoney);
            DriversStatistics.Controls.Add(AvrYears);
            DriversStatistics.Controls.Add(Counter);
            DriversStatistics.Controls.Add(textBox3);
            DriversStatistics.Controls.Add(textBox2);
            DriversStatistics.Controls.Add(textBox1);
            DriversStatistics.Controls.Add(DriversRefresh);
            DriversStatistics.Location = new Point(12, 265);
            DriversStatistics.Name = "DriversStatistics";
            DriversStatistics.Size = new Size(393, 379);
            DriversStatistics.TabIndex = 7;
            DriversStatistics.TabStop = false;
            DriversStatistics.Text = "Статистика";
            // 
            // AvrMoney
            // 
            AvrMoney.Location = new Point(174, 144);
            AvrMoney.Name = "AvrMoney";
            AvrMoney.Size = new Size(213, 31);
            AvrMoney.TabIndex = 14;
            // 
            // AvrYears
            // 
            AvrYears.Location = new Point(174, 107);
            AvrYears.Name = "AvrYears";
            AvrYears.Size = new Size(213, 31);
            AvrYears.TabIndex = 13;
            // 
            // Counter
            // 
            Counter.Location = new Point(174, 70);
            Counter.Name = "Counter";
            Counter.Size = new Size(213, 31);
            Counter.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 144);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(162, 31);
            textBox3.TabIndex = 11;
            textBox3.Text = "Средний оклад";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 107);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(162, 31);
            textBox2.TabIndex = 10;
            textBox2.Text = "Средний стаж";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 70);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(162, 31);
            textBox1.TabIndex = 9;
            textBox1.Text = "Кол-во водителей";
            // 
            // DriversRefresh
            // 
            DriversRefresh.Location = new Point(6, 30);
            DriversRefresh.Name = "DriversRefresh";
            DriversRefresh.Size = new Size(112, 34);
            DriversRefresh.TabIndex = 8;
            DriversRefresh.Text = "Обновить данные";
            DriversRefresh.UseVisualStyleBackColor = true;
            DriversRefresh.Click += DriversRefresh_Click;
            // 
            // DriversAddRow
            // 
            DriversAddRow.Location = new Point(411, 556);
            DriversAddRow.Name = "DriversAddRow";
            DriversAddRow.Size = new Size(337, 51);
            DriversAddRow.TabIndex = 9;
            DriversAddRow.Text = "Добавить строку";
            DriversAddRow.UseVisualStyleBackColor = true;
            DriversAddRow.Click += AddRow_Click;
            // 
            // DriversDeleteRow
            // 
            DriversDeleteRow.Location = new Point(754, 556);
            DriversDeleteRow.Name = "DriversDeleteRow";
            DriversDeleteRow.Size = new Size(322, 51);
            DriversDeleteRow.TabIndex = 10;
            DriversDeleteRow.Text = "Удалить строку";
            DriversDeleteRow.UseVisualStyleBackColor = true;
            DriversDeleteRow.Click += DeleteRow_Click;
            // 
            // DriversAddRowField
            // 
            DriversAddRowField.Location = new Point(411, 613);
            DriversAddRowField.Name = "DriversAddRowField";
            DriversAddRowField.Size = new Size(337, 31);
            DriversAddRowField.TabIndex = 11;
            // 
            // DriversDeleteRowField
            // 
            DriversDeleteRowField.Location = new Point(754, 613);
            DriversDeleteRowField.Name = "DriversDeleteRowField";
            DriversDeleteRowField.Size = new Size(322, 31);
            DriversDeleteRowField.TabIndex = 12;
            // 
            // Number
            // 
            Number.HeaderText = "Номер водителя";
            Number.MinimumWidth = 8;
            Number.Name = "Number";
            // 
            // NameSurname
            // 
            NameSurname.HeaderText = "ФИО";
            NameSurname.MinimumWidth = 8;
            NameSurname.Name = "NameSurname";
            NameSurname.Width = 150;
            // 
            // DoB
            // 
            DoB.HeaderText = "Дата рождения";
            DoB.MinimumWidth = 8;
            DoB.Name = "DoB";
            // 
            // Years
            // 
            Years.HeaderText = "Стаж";
            Years.MinimumWidth = 8;
            Years.Name = "Years";
            // 
            // Money
            // 
            Money.HeaderText = "Оклад";
            Money.MinimumWidth = 8;
            Money.Name = "Money";
            // 
            // Drivers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 656);
            Controls.Add(DriversDeleteRowField);
            Controls.Add(DriversAddRowField);
            Controls.Add(DriversDeleteRow);
            Controls.Add(DriversAddRow);
            Controls.Add(DriversStatistics);
            Controls.Add(DriversSearch);
            Controls.Add(DriversSearchField);
            Controls.Add(DriversTable);
            Controls.Add(DriversSaveFile);
            Controls.Add(DriversOpenFile);
            Name = "Drivers";
            Text = "Водители";
            ((System.ComponentModel.ISupportInitialize)DriversTable).EndInit();
            DriversStatistics.ResumeLayout(false);
            DriversStatistics.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DriversOpenFile;
        private Button DriversSaveFile;
        private DataGridView DriversTable;
        private TextBox DriversSearchField;
        private Button DriversSearch;
        private GroupBox DriversStatistics;
        private Button DriversRefresh;
        private Button DriversAddRow;
        private Button DriversDeleteRow;
        private TextBox DriversAddRowField;
        private TextBox DriversDeleteRowField;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox AvrMoney;
        private TextBox AvrYears;
        private TextBox Counter;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn NameSurname;
        private DataGridViewTextBoxColumn DoB;
        private DataGridViewTextBoxColumn Years;
        private DataGridViewTextBoxColumn Money;
    }
}