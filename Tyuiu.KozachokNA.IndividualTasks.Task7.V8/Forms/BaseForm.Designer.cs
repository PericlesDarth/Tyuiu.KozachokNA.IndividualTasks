namespace Tyuiu.KozachokNA.IndividualTasks.Task7.V8
{
    partial class BaseForm
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
            DriversFormOpen = new Button();
            CarsFormOpen = new Button();
            RunsFormOpen = new Button();
            HelpFormOpen = new Button();
            SuspendLayout();
            // 
            // DriversFormOpen
            // 
            DriversFormOpen.Location = new Point(12, 12);
            DriversFormOpen.Name = "DriversFormOpen";
            DriversFormOpen.Size = new Size(136, 34);
            DriversFormOpen.TabIndex = 2;
            DriversFormOpen.Text = "Водители";
            DriversFormOpen.UseVisualStyleBackColor = true;
            DriversFormOpen.Click += DriversFormOpen_Click;
            // 
            // CarsFormOpen
            // 
            CarsFormOpen.Location = new Point(12, 52);
            CarsFormOpen.Name = "CarsFormOpen";
            CarsFormOpen.Size = new Size(136, 34);
            CarsFormOpen.TabIndex = 3;
            CarsFormOpen.Text = "Автомобили";
            CarsFormOpen.UseVisualStyleBackColor = true;
            CarsFormOpen.Click += CarsFormOpen_Click;
            // 
            // RunsFormOpen
            // 
            RunsFormOpen.Location = new Point(12, 92);
            RunsFormOpen.Name = "RunsFormOpen";
            RunsFormOpen.Size = new Size(136, 34);
            RunsFormOpen.TabIndex = 4;
            RunsFormOpen.Text = "Поездки";
            RunsFormOpen.UseVisualStyleBackColor = true;
            RunsFormOpen.Click += RunsFormOpen_Click;
            // 
            // HelpFormOpen
            // 
            HelpFormOpen.Location = new Point(292, 12);
            HelpFormOpen.Name = "HelpFormOpen";
            HelpFormOpen.Size = new Size(136, 34);
            HelpFormOpen.TabIndex = 5;
            HelpFormOpen.Text = "Помощь";
            HelpFormOpen.UseVisualStyleBackColor = true;
            HelpFormOpen.Click += HelpFormOpen_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 452);
            Controls.Add(HelpFormOpen);
            Controls.Add(RunsFormOpen);
            Controls.Add(CarsFormOpen);
            Controls.Add(DriversFormOpen);
            Name = "BaseForm";
            Text = "Табличный процессор";
            ResumeLayout(false);
        }

        #endregion
        private Button DriversFormOpen;
        private Button CarsFormOpen;
        private Button RunsFormOpen;
        private Button HelpFormOpen;
    }
}
