namespace Sprint6
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StartCalculate = new Button();
            Rows = new TextBox();
            CreateMatrix = new Button();
            Columns = new TextBox();
            RNGFrom = new TextBox();
            RNGTo = new TextBox();
            RowNumber = new TextBox();
            EnumFrom = new TextBox();
            EnumTo = new TextBox();
            ErrorMessage = new TextBox();
            ResultValue = new TextBox();
            dataGridMatrix = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridMatrix).BeginInit();
            SuspendLayout();
            // 
            // StartCalculate
            // 
            StartCalculate.Location = new Point(773, 52);
            StartCalculate.Name = "StartCalculate";
            StartCalculate.Size = new Size(159, 34);
            StartCalculate.TabIndex = 2;
            StartCalculate.Text = "Calculate";
            StartCalculate.UseVisualStyleBackColor = true;
            StartCalculate.Click += StartCalculate_Click;
            // 
            // Rows
            // 
            Rows.Location = new Point(12, 460);
            Rows.Name = "Rows";
            Rows.Size = new Size(175, 31);
            Rows.TabIndex = 3;
            Rows.Text = "N:";
            // 
            // CreateMatrix
            // 
            CreateMatrix.Location = new Point(773, 12);
            CreateMatrix.Name = "CreateMatrix";
            CreateMatrix.Size = new Size(159, 34);
            CreateMatrix.TabIndex = 4;
            CreateMatrix.Text = "Initialize matrix";
            CreateMatrix.UseVisualStyleBackColor = true;
            CreateMatrix.Click += CreateMatrix_Click;
            // 
            // Columns
            // 
            Columns.Location = new Point(193, 460);
            Columns.Name = "Columns";
            Columns.Size = new Size(179, 31);
            Columns.TabIndex = 5;
            Columns.Text = "M:";
            // 
            // RNGFrom
            // 
            RNGFrom.Location = new Point(12, 497);
            RNGFrom.Name = "RNGFrom";
            RNGFrom.Size = new Size(175, 31);
            RNGFrom.TabIndex = 6;
            RNGFrom.Text = "n1:";
            // 
            // RNGTo
            // 
            RNGTo.Location = new Point(193, 497);
            RNGTo.Name = "RNGTo";
            RNGTo.Size = new Size(179, 31);
            RNGTo.TabIndex = 7;
            RNGTo.Text = "n2:";
            // 
            // RowNumber
            // 
            RowNumber.Location = new Point(378, 460);
            RowNumber.Name = "RowNumber";
            RowNumber.Size = new Size(179, 31);
            RowNumber.TabIndex = 8;
            RowNumber.Text = "R:";
            // 
            // EnumFrom
            // 
            EnumFrom.Location = new Point(378, 497);
            EnumFrom.Name = "EnumFrom";
            EnumFrom.Size = new Size(179, 31);
            EnumFrom.TabIndex = 9;
            EnumFrom.Text = "K:";
            // 
            // EnumTo
            // 
            EnumTo.Location = new Point(378, 534);
            EnumTo.Name = "EnumTo";
            EnumTo.Size = new Size(179, 31);
            EnumTo.TabIndex = 10;
            EnumTo.Text = "L:";
            // 
            // ErrorMessage
            // 
            ErrorMessage.Location = new Point(773, 92);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(257, 31);
            ErrorMessage.TabIndex = 11;
            // 
            // ResultValue
            // 
            ResultValue.AllowDrop = true;
            ResultValue.Location = new Point(773, 129);
            ResultValue.Name = "ResultValue";
            ResultValue.Size = new Size(257, 31);
            ResultValue.TabIndex = 12;
            // 
            // dataGridMatrix
            // 
            dataGridMatrix.AllowDrop = true;
            dataGridMatrix.AutoGenerateColumns = false;
            dataGridMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMatrix.Location = new Point(0, 0);
            dataGridMatrix.Name = "dataGridMatrix";
            dataGridMatrix.RowHeadersWidth = 62;
            dataGridMatrix.Size = new Size(557, 454);
            dataGridMatrix.TabIndex = 13;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 578);
            Controls.Add(dataGridMatrix);
            Controls.Add(ResultValue);
            Controls.Add(ErrorMessage);
            Controls.Add(EnumTo);
            Controls.Add(EnumFrom);
            Controls.Add(RowNumber);
            Controls.Add(RNGTo);
            Controls.Add(RNGFrom);
            Controls.Add(Columns);
            Controls.Add(CreateMatrix);
            Controls.Add(Rows);
            Controls.Add(StartCalculate);
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)dataGridMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartCalculate;
        public TextBox Rows;
        private Button CreateMatrix;
        public TextBox Columns;
        private TextBox RNGFrom;
        private TextBox RNGTo;
        private TextBox RowNumber;
        private TextBox EnumFrom;
        private TextBox EnumTo;
        private TextBox ErrorMessage;
        private TextBox ResultValue;
        private DataGridView dataGridMatrix;
    }
}
