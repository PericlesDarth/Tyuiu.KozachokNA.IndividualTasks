namespace Tyuiu.KozachokNA.IndividualTasks.Task7.V8.Forms
{
    partial class Cars
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
            CarsDeleteRowField = new TextBox();
            CarsAddRowField = new TextBox();
            CarsDeleteRow = new Button();
            CarsAddRow = new Button();
            CarsStatistics = new GroupBox();
            CarsRefresh = new Button();
            CarsSearch = new Button();
            CarsSearchField = new TextBox();
            CarsTable = new DataGridView();
            CarNumber = new DataGridViewTextBoxColumn();
            CarMark = new DataGridViewTextBoxColumn();
            CarState = new DataGridViewTextBoxColumn();
            CarPlace = new DataGridViewTextBoxColumn();
            CarSpeed = new DataGridViewTextBoxColumn();
            CarLoad = new DataGridViewTextBoxColumn();
            CarEff = new DataGridViewTextBoxColumn();
            CarsSaveFile = new Button();
            CarsOpenFile = new Button();
            textbox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Counter = new TextBox();
            AvrSpeed = new TextBox();
            AvrEff = new TextBox();
            CarsStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarsTable).BeginInit();
            SuspendLayout();
            // 
            // CarsDeleteRowField
            // 
            CarsDeleteRowField.Location = new Point(754, 613);
            CarsDeleteRowField.Name = "CarsDeleteRowField";
            CarsDeleteRowField.Size = new Size(322, 31);
            CarsDeleteRowField.TabIndex = 22;
            // 
            // CarsAddRowField
            // 
            CarsAddRowField.Location = new Point(411, 613);
            CarsAddRowField.Name = "CarsAddRowField";
            CarsAddRowField.Size = new Size(337, 31);
            CarsAddRowField.TabIndex = 21;
            // 
            // CarsDeleteRow
            // 
            CarsDeleteRow.Location = new Point(754, 556);
            CarsDeleteRow.Name = "CarsDeleteRow";
            CarsDeleteRow.Size = new Size(322, 51);
            CarsDeleteRow.TabIndex = 20;
            CarsDeleteRow.Text = "Удалить строку";
            CarsDeleteRow.UseVisualStyleBackColor = true;
            CarsDeleteRow.Click += DeleteRow_Click;
            // 
            // CarsAddRow
            // 
            CarsAddRow.Location = new Point(411, 556);
            CarsAddRow.Name = "CarsAddRow";
            CarsAddRow.Size = new Size(337, 51);
            CarsAddRow.TabIndex = 19;
            CarsAddRow.Text = "Добавить строку";
            CarsAddRow.UseVisualStyleBackColor = true;
            CarsAddRow.Click += AddRow_Click;
            // 
            // CarsStatistics
            // 
            CarsStatistics.Controls.Add(AvrEff);
            CarsStatistics.Controls.Add(AvrSpeed);
            CarsStatistics.Controls.Add(Counter);
            CarsStatistics.Controls.Add(textBox3);
            CarsStatistics.Controls.Add(textBox2);
            CarsStatistics.Controls.Add(textbox1);
            CarsStatistics.Controls.Add(CarsRefresh);
            CarsStatistics.Location = new Point(12, 265);
            CarsStatistics.Name = "CarsStatistics";
            CarsStatistics.Size = new Size(393, 379);
            CarsStatistics.TabIndex = 18;
            CarsStatistics.TabStop = false;
            CarsStatistics.Text = "Статистика";
            // 
            // CarsRefresh
            // 
            CarsRefresh.Location = new Point(6, 30);
            CarsRefresh.Name = "CarsRefresh";
            CarsRefresh.Size = new Size(112, 34);
            CarsRefresh.TabIndex = 8;
            CarsRefresh.Text = "Обновить данные";
            CarsRefresh.UseVisualStyleBackColor = true;
            CarsRefresh.Click += CarsRefresh_Click;
            // 
            // CarsSearch
            // 
            CarsSearch.Location = new Point(293, 79);
            CarsSearch.Name = "CarsSearch";
            CarsSearch.Size = new Size(112, 34);
            CarsSearch.TabIndex = 17;
            CarsSearch.Text = "Найти?";
            CarsSearch.UseVisualStyleBackColor = true;
            CarsSearch.Click += CarsSearch_Click;
            // 
            // CarsSearchField
            // 
            CarsSearchField.Location = new Point(12, 82);
            CarsSearchField.Name = "CarsSearchField";
            CarsSearchField.Size = new Size(252, 31);
            CarsSearchField.TabIndex = 16;
            // 
            // CarsTable
            // 
            CarsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarsTable.Columns.AddRange(new DataGridViewColumn[] { CarNumber, CarMark, CarState, CarPlace, CarSpeed, CarLoad, CarEff });
            CarsTable.Location = new Point(411, 12);
            CarsTable.Name = "CarsTable";
            CarsTable.RowHeadersWidth = 62;
            CarsTable.Size = new Size(665, 538);
            CarsTable.TabIndex = 15;
            //CarsTable.ColumnHeaderMouseDoubleClick += TableSort;
            // 
            // CarNumber
            // 
            CarNumber.HeaderText = "Номерной знак";
            CarNumber.MinimumWidth = 8;
            CarNumber.Name = "CarNumber";
            CarNumber.Width = 150;
            // 
            // CarMark
            // 
            CarMark.HeaderText = "Марка автомобиля";
            CarMark.MinimumWidth = 8;
            CarMark.Name = "CarMark";
            CarMark.Width = 150;
            // 
            // CarState
            // 
            CarState.HeaderText = "Техническое состояние";
            CarState.MinimumWidth = 8;
            CarState.Name = "CarState";
            CarState.Width = 150;
            // 
            // CarPlace
            // 
            CarPlace.HeaderText = "Местонахождение";
            CarPlace.MinimumWidth = 8;
            CarPlace.Name = "CarPlace";
            CarPlace.Width = 150;
            // 
            // CarSpeed
            // 
            CarSpeed.HeaderText = "Средняя скорость";
            CarSpeed.MinimumWidth = 8;
            CarSpeed.Name = "CarSpeed";
            CarSpeed.Width = 150;
            // 
            // CarLoad
            // 
            CarLoad.HeaderText = "Грузоподъёмность";
            CarLoad.MinimumWidth = 8;
            CarLoad.Name = "CarLoad";
            CarLoad.Width = 150;
            // 
            // CarEff
            // 
            CarEff.HeaderText = "Расход топлива";
            CarEff.MinimumWidth = 8;
            CarEff.Name = "CarEff";
            CarEff.Width = 150;
            // 
            // CarsSaveFile
            // 
            CarsSaveFile.Location = new Point(293, 12);
            CarsSaveFile.Name = "CarsSaveFile";
            CarsSaveFile.Size = new Size(112, 34);
            CarsSaveFile.TabIndex = 14;
            CarsSaveFile.Text = "Save file";
            CarsSaveFile.UseVisualStyleBackColor = true;
            CarsSaveFile.Click += SaveFile_Click;
            // 
            // CarsOpenFile
            // 
            CarsOpenFile.Location = new Point(12, 12);
            CarsOpenFile.Name = "CarsOpenFile";
            CarsOpenFile.Size = new Size(252, 34);
            CarsOpenFile.TabIndex = 13;
            CarsOpenFile.Text = "Open file";
            CarsOpenFile.UseVisualStyleBackColor = true;
            CarsOpenFile.Click += OpenFile_Click;
            // 
            // textbox1
            // 
            textbox1.Location = new Point(6, 70);
            textbox1.Name = "textbox1";
            textbox1.ReadOnly = true;
            textbox1.Size = new Size(209, 31);
            textbox1.TabIndex = 9;
            textbox1.Text = "Кол-во Автомобилей";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 107);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(209, 31);
            textBox2.TabIndex = 10;
            textBox2.Text = "Средняя скорость";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 31);
            textBox3.TabIndex = 11;
            textBox3.Text = "Средний расход топлива";
            // 
            // Counter
            // 
            Counter.Location = new Point(221, 70);
            Counter.Name = "Counter";
            Counter.Size = new Size(150, 31);
            Counter.TabIndex = 12;
            // 
            // AvrSpeed
            // 
            AvrSpeed.Location = new Point(221, 107);
            AvrSpeed.Name = "AvrSpeed";
            AvrSpeed.Size = new Size(150, 31);
            AvrSpeed.TabIndex = 13;
            // 
            // AvrEff
            // 
            AvrEff.Location = new Point(221, 144);
            AvrEff.Name = "AvrEff";
            AvrEff.Size = new Size(150, 31);
            AvrEff.TabIndex = 14;
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 656);
            Controls.Add(CarsDeleteRowField);
            Controls.Add(CarsAddRowField);
            Controls.Add(CarsDeleteRow);
            Controls.Add(CarsAddRow);
            Controls.Add(CarsStatistics);
            Controls.Add(CarsSearch);
            Controls.Add(CarsSearchField);
            Controls.Add(CarsTable);
            Controls.Add(CarsSaveFile);
            Controls.Add(CarsOpenFile);
            Name = "Cars";
            Text = "Автомобили";
            CarsStatistics.ResumeLayout(false);
            CarsStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CarsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CarsDeleteRowField;
        private TextBox CarsAddRowField;
        private Button CarsDeleteRow;
        private Button CarsAddRow;
        private GroupBox CarsStatistics;
        private Button CarsRefresh;
        private Button CarsSearch;
        private TextBox CarsSearchField;
        private DataGridView CarsTable;
        private Button CarsSaveFile;
        private Button CarsOpenFile;
        private DataGridViewTextBoxColumn CarNumber;
        private DataGridViewTextBoxColumn CarMark;
        private DataGridViewTextBoxColumn CarState;
        private DataGridViewTextBoxColumn CarPlace;
        private DataGridViewTextBoxColumn CarSpeed;
        private DataGridViewTextBoxColumn CarLoad;
        private DataGridViewTextBoxColumn CarEff;
        private TextBox textbox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox AvrEff;
        private TextBox AvrSpeed;
        private TextBox Counter;
    }
}