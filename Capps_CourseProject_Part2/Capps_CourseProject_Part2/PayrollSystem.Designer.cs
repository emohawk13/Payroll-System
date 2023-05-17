
namespace Capps_CourseProject_Part2
{
    partial class PayrollSystem
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.displayEmployeeButton = new System.Windows.Forms.Button();
            this.paycheckButton = new System.Windows.Forms.Button();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addEmployeeButton.Location = new System.Drawing.Point(13, 12);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(239, 81);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeButton.Location = new System.Drawing.Point(258, 12);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(244, 81);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove Employee";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // displayEmployeeButton
            // 
            this.displayEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayEmployeeButton.Location = new System.Drawing.Point(508, 12);
            this.displayEmployeeButton.Name = "displayEmployeeButton";
            this.displayEmployeeButton.Size = new System.Drawing.Size(240, 81);
            this.displayEmployeeButton.TabIndex = 2;
            this.displayEmployeeButton.Text = "Display Employees";
            this.displayEmployeeButton.UseVisualStyleBackColor = true;
            this.displayEmployeeButton.Click += new System.EventHandler(this.displayEmployeeButton_Click);
            // 
            // paycheckButton
            // 
            this.paycheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.paycheckButton.Location = new System.Drawing.Point(754, 12);
            this.paycheckButton.Name = "paycheckButton";
            this.paycheckButton.Size = new System.Drawing.Size(260, 81);
            this.paycheckButton.TabIndex = 3;
            this.paycheckButton.Text = "Print Paychecks";
            this.paycheckButton.UseVisualStyleBackColor = true;
            this.paycheckButton.Click += new System.EventHandler(this.paycheckButton_Click);
            // 
            // employeeListBox
            // 
            this.employeeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 25;
            this.employeeListBox.Location = new System.Drawing.Point(13, 114);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(1023, 479);
            this.employeeListBox.TabIndex = 4;
            this.employeeListBox.DoubleClick += new System.EventHandler(this.employeeListBox_DoubleClick);
            // 
            // PayrollSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 613);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.paycheckButton);
            this.Controls.Add(this.displayEmployeeButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "PayrollSystem";
            this.Text = "Payroll System";
            this.Load += new System.EventHandler(this.PayrollSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button displayEmployeeButton;
        private System.Windows.Forms.Button paycheckButton;
        private System.Windows.Forms.ListBox employeeListBox;
    }
}

