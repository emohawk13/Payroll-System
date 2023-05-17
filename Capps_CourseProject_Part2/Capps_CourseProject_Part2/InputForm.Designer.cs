
namespace Capps_CourseProject_Part2
{
    partial class InputForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.hireDateLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.HireDateTextBox = new System.Windows.Forms.TextBox();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VacationTextBox = new System.Windows.Forms.TextBox();
            this.LifeInsTextBox = new System.Windows.Forms.TextBox();
            this.HealthInsTextBox = new System.Windows.Forms.TextBox();
            this.vacaLabel = new System.Windows.Forms.Label();
            this.healthInsLabel = new System.Windows.Forms.Label();
            this.lifeInsLabel = new System.Windows.Forms.Label();
            this.beneLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.annualSalaryTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.AnnSalaryLabel = new System.Windows.Forms.Label();
            this.salaryRDButton = new System.Windows.Forms.RadioButton();
            this.hourlyRDButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNameLabel.Location = new System.Drawing.Point(30, 46);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastNameLabel.Location = new System.Drawing.Point(30, 80);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 20);
            this.lastNameLabel.TabIndex = 45;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ssnLabel.Location = new System.Drawing.Point(78, 111);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(48, 20);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "SSN:";
            // 
            // hireDateLabel
            // 
            this.hireDateLabel.AutoSize = true;
            this.hireDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hireDateLabel.Location = new System.Drawing.Point(40, 144);
            this.hireDateLabel.Name = "hireDateLabel";
            this.hireDateLabel.Size = new System.Drawing.Size(87, 20);
            this.hireDateLabel.TabIndex = 3;
            this.hireDateLabel.Text = "Hire Date:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(133, 46);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(327, 26);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LastNameTextBox.Location = new System.Drawing.Point(133, 80);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(327, 26);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // HireDateTextBox
            // 
            this.HireDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HireDateTextBox.Location = new System.Drawing.Point(133, 144);
            this.HireDateTextBox.Name = "HireDateTextBox";
            this.HireDateTextBox.Size = new System.Drawing.Size(327, 26);
            this.HireDateTextBox.TabIndex = 4;
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SSNTextBox.Location = new System.Drawing.Point(133, 111);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(327, 26);
            this.SSNTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitButton.Location = new System.Drawing.Point(58, 622);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(155, 48);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(296, 622);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 48);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VacationTextBox);
            this.panel1.Controls.Add(this.LifeInsTextBox);
            this.panel1.Controls.Add(this.HealthInsTextBox);
            this.panel1.Controls.Add(this.vacaLabel);
            this.panel1.Controls.Add(this.healthInsLabel);
            this.panel1.Controls.Add(this.lifeInsLabel);
            this.panel1.Controls.Add(this.beneLabel);
            this.panel1.Location = new System.Drawing.Point(58, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 170);
            this.panel1.TabIndex = 47;
            // 
            // VacationTextBox
            // 
            this.VacationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.VacationTextBox.Location = new System.Drawing.Point(177, 96);
            this.VacationTextBox.Name = "VacationTextBox";
            this.VacationTextBox.Size = new System.Drawing.Size(233, 26);
            this.VacationTextBox.TabIndex = 10;
            // 
            // LifeInsTextBox
            // 
            this.LifeInsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LifeInsTextBox.Location = new System.Drawing.Point(177, 64);
            this.LifeInsTextBox.Name = "LifeInsTextBox";
            this.LifeInsTextBox.Size = new System.Drawing.Size(233, 26);
            this.LifeInsTextBox.TabIndex = 9;
            // 
            // HealthInsTextBox
            // 
            this.HealthInsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HealthInsTextBox.Location = new System.Drawing.Point(177, 32);
            this.HealthInsTextBox.Name = "HealthInsTextBox";
            this.HealthInsTextBox.Size = new System.Drawing.Size(233, 26);
            this.HealthInsTextBox.TabIndex = 8;
            // 
            // vacaLabel
            // 
            this.vacaLabel.AutoSize = true;
            this.vacaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vacaLabel.Location = new System.Drawing.Point(30, 95);
            this.vacaLabel.Name = "vacaLabel";
            this.vacaLabel.Size = new System.Drawing.Size(123, 20);
            this.vacaLabel.TabIndex = 3;
            this.vacaLabel.Text = "Vacation Days:";
            // 
            // healthInsLabel
            // 
            this.healthInsLabel.AutoSize = true;
            this.healthInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.healthInsLabel.Location = new System.Drawing.Point(30, 64);
            this.healthInsLabel.Name = "healthInsLabel";
            this.healthInsLabel.Size = new System.Drawing.Size(120, 20);
            this.healthInsLabel.TabIndex = 2;
            this.healthInsLabel.Text = "Life Insurance:";
            // 
            // lifeInsLabel
            // 
            this.lifeInsLabel.AutoSize = true;
            this.lifeInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lifeInsLabel.Location = new System.Drawing.Point(30, 35);
            this.lifeInsLabel.Name = "lifeInsLabel";
            this.lifeInsLabel.Size = new System.Drawing.Size(141, 20);
            this.lifeInsLabel.TabIndex = 1;
            this.lifeInsLabel.Text = "Health Insurance:";
            // 
            // beneLabel
            // 
            this.beneLabel.AutoSize = true;
            this.beneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.beneLabel.Location = new System.Drawing.Point(16, 4);
            this.beneLabel.Name = "beneLabel";
            this.beneLabel.Size = new System.Drawing.Size(76, 20);
            this.beneLabel.TabIndex = 0;
            this.beneLabel.Text = "Benefits:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hoursWorkedTextBox);
            this.panel2.Controls.Add(this.hourlyRateTextBox);
            this.panel2.Controls.Add(this.annualSalaryTextBox);
            this.panel2.Controls.Add(this.hourlyRateLabel);
            this.panel2.Controls.Add(this.hoursWorkedLabel);
            this.panel2.Controls.Add(this.AnnSalaryLabel);
            this.panel2.Controls.Add(this.salaryRDButton);
            this.panel2.Controls.Add(this.hourlyRDButton);
            this.panel2.Location = new System.Drawing.Point(58, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 210);
            this.panel2.TabIndex = 48;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(177, 150);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(216, 22);
            this.hoursWorkedTextBox.TabIndex = 7;
            this.hoursWorkedTextBox.Visible = false;
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Location = new System.Drawing.Point(177, 110);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(216, 22);
            this.hourlyRateTextBox.TabIndex = 6;
            this.hourlyRateTextBox.Visible = false;
            // 
            // annualSalaryTextBox
            // 
            this.annualSalaryTextBox.Location = new System.Drawing.Point(177, 69);
            this.annualSalaryTextBox.Name = "annualSalaryTextBox";
            this.annualSalaryTextBox.Size = new System.Drawing.Size(216, 22);
            this.annualSalaryTextBox.TabIndex = 5;
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hourlyRateLabel.Location = new System.Drawing.Point(20, 110);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(103, 20);
            this.hourlyRateLabel.TabIndex = 4;
            this.hourlyRateLabel.Text = "Hourly Rate:";
            this.hourlyRateLabel.Visible = false;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hoursWorkedLabel.Location = new System.Drawing.Point(20, 150);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(122, 20);
            this.hoursWorkedLabel.TabIndex = 3;
            this.hoursWorkedLabel.Text = "Hours Worked:";
            this.hoursWorkedLabel.Visible = false;
            // 
            // AnnSalaryLabel
            // 
            this.AnnSalaryLabel.AutoSize = true;
            this.AnnSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AnnSalaryLabel.Location = new System.Drawing.Point(20, 72);
            this.AnnSalaryLabel.Name = "AnnSalaryLabel";
            this.AnnSalaryLabel.Size = new System.Drawing.Size(117, 20);
            this.AnnSalaryLabel.TabIndex = 2;
            this.AnnSalaryLabel.Text = "Annual Salary:";
            // 
            // salaryRDButton
            // 
            this.salaryRDButton.AutoSize = true;
            this.salaryRDButton.Location = new System.Drawing.Point(24, 25);
            this.salaryRDButton.Name = "salaryRDButton";
            this.salaryRDButton.Size = new System.Drawing.Size(69, 21);
            this.salaryRDButton.TabIndex = 1;
            this.salaryRDButton.TabStop = true;
            this.salaryRDButton.Text = "Salary";
            this.salaryRDButton.UseVisualStyleBackColor = true;
            this.salaryRDButton.CheckedChanged += new System.EventHandler(this.salaryRDButton_CheckedChanged);
            // 
            // hourlyRDButton
            // 
            this.hourlyRDButton.AutoSize = true;
            this.hourlyRDButton.Location = new System.Drawing.Point(177, 25);
            this.hourlyRDButton.Name = "hourlyRDButton";
            this.hourlyRDButton.Size = new System.Drawing.Size(70, 21);
            this.hourlyRDButton.TabIndex = 0;
            this.hourlyRDButton.TabStop = true;
            this.hourlyRDButton.Text = "Hourly";
            this.hourlyRDButton.UseVisualStyleBackColor = true;
            this.hourlyRDButton.CheckedChanged += new System.EventHandler(this.hourlyRDButton_CheckedChanged);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 693);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.HireDateTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.hireDateLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label hireDateLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox LastNameTextBox;
        public System.Windows.Forms.TextBox HireDateTextBox;
        public System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vacaLabel;
        private System.Windows.Forms.Label healthInsLabel;
        private System.Windows.Forms.Label lifeInsLabel;
        private System.Windows.Forms.Label beneLabel;
        public System.Windows.Forms.TextBox VacationTextBox;
        public System.Windows.Forms.TextBox LifeInsTextBox;
        public System.Windows.Forms.TextBox HealthInsTextBox;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox hoursWorkedTextBox;
        public System.Windows.Forms.TextBox hourlyRateTextBox;
        public System.Windows.Forms.TextBox annualSalaryTextBox;
        public System.Windows.Forms.Label hourlyRateLabel;
        public System.Windows.Forms.Label hoursWorkedLabel;
        public System.Windows.Forms.Label AnnSalaryLabel;
        public System.Windows.Forms.RadioButton salaryRDButton;
        public System.Windows.Forms.RadioButton hourlyRDButton;
    }
}