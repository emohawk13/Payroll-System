using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capps_CourseProject_Part2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void hourlyRDButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hourlyRDButton.Checked)
            {
                AnnSalaryLabel.Visible = false;
                annualSalaryTextBox.Visible = false;
                hourlyRateLabel.Visible = true;
                hourlyRateTextBox.Visible = true;
                hoursWorkedLabel.Visible = true;
                hoursWorkedTextBox.Visible = true;
            }
        }

        private void salaryRDButton_CheckedChanged(object sender, EventArgs e)
        {
            if (salaryRDButton.Checked)
            {
                AnnSalaryLabel.Visible = true;
                annualSalaryTextBox.Visible = true;
                hourlyRateLabel.Visible = false;
                hourlyRateTextBox.Visible = false;
                hoursWorkedLabel.Visible =false;
                hoursWorkedTextBox.Visible = false;
            }
        }
    }
}
