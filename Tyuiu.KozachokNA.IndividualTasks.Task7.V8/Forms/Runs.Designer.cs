namespace Tyuiu.KozachokNA.IndividualTasks.Task7.V8
{
    partial class Runs
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
            RunsDeleteRowField = new TextBox();
            RunsAddRowField = new TextBox();
            RunsDeleteRow = new Button();
            RunsAddRow = new Button();
            RunsStatistics = new GroupBox();
            AvrRange = new TextBox();
            Counter = new TextBox();
            textbox2 = new TextBox();
            textbox1 = new TextBox();
            RunsRefresh = new Button();
            RunsSearch = new Button();
            RunsSearchField = new TextBox();
            RunsTable = new DataGridView();
            DateOut = new DataGridViewTextBoxColumn();
            DateIn = new DataGridViewTextBoxColumn();
            Range = new DataGridViewTextBoxColumn();
            Fuel = new DataGridViewTextBoxColumn();
            Load = new DataGridViewTextBoxColumn();
            RunsSaveFile = new Button();
            RunsOpenFile = new Button();
            RunsStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RunsTable).BeginInit();
            SuspendLayout();
            // 
            // RunsDeleteRowField
            // 
            RunsDeleteRowField.Location = new Point(754, 613);
            RunsDeleteRowField.Name = "RunsDeleteRowField";
            RunsDeleteRowField.Size = new Size(322, 31);
            RunsDeleteRowField.TabIndex = 32;
            // 
            // RunsAddRowField
            // 
            RunsAddRowField.Location = new Point(411, 613);
            RunsAddRowField.Name = "RunsAddRowField";
            RunsAddRowField.Size = new Size(337, 31);
            RunsAddRowField.TabIndex = 31;
            // 
            // RunsDeleteRow
            // 
            RunsDeleteRow.Location = new Point(754, 556);
            RunsDeleteRow.Name = "RunsDeleteRow";
            RunsDeleteRow.Size = new Size(322, 51);
            RunsDeleteRow.TabIndex = 30;
            RunsDeleteRow.Text = "Удалить строку";
            RunsDeleteRow.UseVisualStyleBackColor = true;
            RunsDeleteRow.Click += DeleteRow_Click;
            // 
            // RunsAddRow
            // 
            RunsAddRow.Location = new Point(411, 556);
            RunsAddRow.Name = "RunsAddRow";
            RunsAddRow.Size = new Size(337, 51);
            RunsAddRow.TabIndex = 29;
            RunsAddRow.Text = "Добавить строку";
            RunsAddRow.UseVisualStyleBackColor = true;
            RunsAddRow.Click += AddRow_Click;
            // 
            // RunsStatistics
            // 
            RunsStatistics.Controls.Add(AvrRange);
            RunsStatistics.Controls.Add(Counter);
            RunsStatistics.Controls.Add(textbox2);
            RunsStatistics.Controls.Add(textbox1);
            RunsStatistics.Controls.Add(RunsRefresh);
            RunsStatistics.Location = new Point(12, 265);
            RunsStatistics.Name = "RunsStatistics";
            RunsStatistics.Size = new Size(393, 379);
            RunsStatistics.TabIndex = 28;
            RunsStatistics.TabStop = false;
            RunsStatistics.Text = "Статистика";
            // 
            // AvrRange
            // 
            AvrRange.Location = new Point(204, 107);
            AvrRange.Name = "AvrRange";
            AvrRange.Size = new Size(183, 31);
            AvrRange.TabIndex = 13;
            // 
            // Counter
            // 
            Counter.Location = new Point(204, 70);
            Counter.Name = "Counter";
            Counter.Size = new Size(183, 31);
            Counter.TabIndex = 12;
            // 
            // textbox2
            // 
            textbox2.Location = new Point(6, 107);
            textbox2.Name = "textbox2";
            textbox2.ReadOnly = true;
            textbox2.Size = new Size(192, 31);
            textbox2.TabIndex = 10;
            textbox2.Text = "Средняя длина пути";
            // 
            // textbox1
            // 
            textbox1.Location = new Point(6, 70);
            textbox1.Name = "textbox1";
            textbox1.ReadOnly = true;
            textbox1.Size = new Size(192, 31);
            textbox1.TabIndex = 9;
            textbox1.Text = "Кол-во поездок";
            // 
            // RunsRefresh
            // 
            RunsRefresh.Location = new Point(6, 30);
            RunsRefresh.Name = "RunsRefresh";
            RunsRefresh.Size = new Size(112, 34);
            RunsRefresh.TabIndex = 8;
            RunsRefresh.Text = "Обновить данные";
            RunsRefresh.UseVisualStyleBackColor = true;
            RunsRefresh.Click += RunsRefresh_Click;
            // 
            // RunsSearch
            // 
            RunsSearch.Location = new Point(293, 79);
            RunsSearch.Name = "RunsSearch";
            RunsSearch.Size = new Size(112, 34);
            RunsSearch.TabIndex = 27;
            RunsSearch.Text = "Найти?";
            RunsSearch.UseVisualStyleBackColor = true;
            RunsSearch.Click += RunsSearch_Click;
            // 
            // RunsSearchField
            // 
            RunsSearchField.Location = new Point(12, 82);
            RunsSearchField.Name = "RunsSearchField";
            RunsSearchField.Size = new Size(252, 31);
            RunsSearchField.TabIndex = 26;
            // 
            // RunsTable
            // 
            RunsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RunsTable.Columns.AddRange(new DataGridViewColumn[] { DateOut, DateIn, Range, Fuel, Load });
            RunsTable.Location = new Point(411, 12);
            RunsTable.Name = "RunsTable";
            RunsTable.RowHeadersWidth = 62;
            RunsTable.Size = new Size(665, 538);
            RunsTable.TabIndex = 25;
            // 
            // DateOut
            // 
            DateOut.HeaderText = "Выезд";
            DateOut.MinimumWidth = 8;
            DateOut.Name = "DateOut";
            DateOut.Width = 150;
            // 
            // DateIn
            // 
            DateIn.HeaderText = "Прибытие";
            DateIn.MinimumWidth = 8;
            DateIn.Name = "DateIn";
            DateIn.Width = 150;
            // 
            // Range
            // 
            Range.HeaderText = "Длина пути";
            Range.MinimumWidth = 8;
            Range.Name = "Range";
            Range.Width = 150;
            // 
            // Fuel
            // 
            Fuel.HeaderText = "Горючее";
            Fuel.MinimumWidth = 8;
            Fuel.Name = "Fuel";
            Fuel.Width = 150;
            // 
            // Load
            // 
            Load.HeaderText = "Масса груза";
            Load.MinimumWidth = 8;
            Load.Name = "Load";
            Load.Width = 150;
            // 
            // RunsSaveFile
            // 
            RunsSaveFile.Location = new Point(293, 12);
            RunsSaveFile.Name = "RunsSaveFile";
            RunsSaveFile.Size = new Size(112, 34);
            RunsSaveFile.TabIndex = 24;
            RunsSaveFile.Text = "Save file";
            RunsSaveFile.UseVisualStyleBackColor = true;
            RunsSaveFile.Click += SaveFile_Click;
            // 
            // RunsOpenFile
            // 
            RunsOpenFile.Location = new Point(12, 12);
            RunsOpenFile.Name = "RunsOpenFile";
            RunsOpenFile.Size = new Size(252, 34);
            RunsOpenFile.TabIndex = 23;
            RunsOpenFile.Text = "Open file";
            RunsOpenFile.UseVisualStyleBackColor = true;
            RunsOpenFile.Click += OpenFile_Click;
            // 
            // Runs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 656);
            Controls.Add(RunsDeleteRowField);
            Controls.Add(RunsAddRowField);
            Controls.Add(RunsDeleteRow);
            Controls.Add(RunsAddRow);
            Controls.Add(RunsStatistics);
            Controls.Add(RunsSearch);
            Controls.Add(RunsSearchField);
            Controls.Add(RunsTable);
            Controls.Add(RunsSaveFile);
            Controls.Add(RunsOpenFile);
            Name = "Runs";
            Text = "Поездки";
            RunsStatistics.ResumeLayout(false);
            RunsStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RunsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RunsDeleteRowField;
        private TextBox RunsAddRowField;
        private Button RunsDeleteRow;
        private Button RunsAddRow;
        private GroupBox RunsStatistics;
        private Button RunsRefresh;
        private Button RunsSearch;
        private TextBox RunsSearchField;
        private DataGridView RunsTable;
        private Button RunsSaveFile;
        private Button RunsOpenFile;
        private DataGridViewTextBoxColumn DateOut;
        private DataGridViewTextBoxColumn DateIn;
        private DataGridViewTextBoxColumn Range;
        private DataGridViewTextBoxColumn Fuel;
        private DataGridViewTextBoxColumn Load;
        private TextBox AvrRange;
        private TextBox Counter;
        private TextBox textbox2;
        private TextBox textbox1;
    }
}