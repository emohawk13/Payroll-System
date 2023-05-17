using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capps_CourseProject_Part2
{
    public partial class PayrollSystem : Form
    {
        private string fileName = "EmployeeData.bin";
        public PayrollSystem()
        {
            InitializeComponent();
        }
        private void WriteEmpsToFile()
        {
            List<Employee> empList = new List<Employee>();
            foreach (Employee emp in employeeListBox.Items)
            {
                empList.Add(emp);
            }
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, empList);
            fs.Close();


            MessageBox.Show("Employees were written to the file.");
        }
        private void ReadEmpsFromFile()
        {   
            if(File.Exists(fileName) && new FileInfo(fileName).Length > 0)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                List<Employee> empList = (List<Employee>)formatter.Deserialize(fs);
                foreach(Employee emp in empList)
                {
                    employeeListBox.Items.Add(emp);
                }
                fs.Close();
            }
        }
        private void addEmployeeButton_Click(object sender, EventArgs e) // add an item to the employee list box
        {
            InputForm frmInput = new InputForm();
            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form was cancelled
                if (result == DialogResult.Cancel)
                    return;    //  ends the method 

                // Takes user's input and create an Employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(frmInput.HireDateTextBox.Text);

                string healthIns = frmInput.HealthInsTextBox.Text;
                double lifeIns = double.Parse(frmInput.LifeInsTextBox.Text);
                int vacation = Int32.Parse(frmInput.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);

                bool isSalary = frmInput.salaryRDButton.Checked;
                bool isHourly = frmInput.hourlyRDButton.Checked;

                if (isSalary)
                {
                    double annualSalary = double.Parse(frmInput.annualSalaryTextBox.Text);

                    Salary empSalary = new Salary(fName, lName, ssn, hireDate, benefits, annualSalary);
                    employeeListBox.Items.Add(empSalary);
                }
                if (isHourly)
                {
                    double hourlyRate = Double.Parse(frmInput.hourlyRateTextBox.Text);
                    double hoursWorked = Double.Parse(frmInput.hoursWorkedTextBox.Text);

                    Hourly empHourly = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                    employeeListBox.Items.Add(empHourly);
                }

                WriteEmpsToFile();
            }
        }

        private void removeButton_Click(object sender, EventArgs e) // remove an item from the employee list box
        {
            int itemNumber = employeeListBox.SelectedIndex;
            //MessageBox.Show(itemNumber.ToString()); // shows and converts item number to a string inside of a message box
            //MessageBox.Show("itemNumber: " + itemNumber); // also converst int to a string
            if (itemNumber > -1)
            {
                employeeListBox.Items.RemoveAt(itemNumber);

                // calls the controls for CSV file
                WriteEmpsToFile();

                MessageBox.Show("Employee removed");
            }
            else
            {
                MessageBox.Show("Please select a Employee to remove.");
            }
        }

        private void displayEmployeeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying all Employees:");
        }

        private void paycheckButton_Click(object sender, EventArgs e)
        {
            string displayString1 = "";
            string displayString2 = "";
            foreach(Employee emp in employeeListBox.Items)
            {
                Type t = emp.GetType();
                if (t.Equals(typeof(Salary)))
                {
                    Salary empSalary = (Salary)emp;
                    displayString1 = displayString1 + empSalary.ToString() + " and the pay is: $" + empSalary.CalculatePay() + "\n";
                }
                if(t.Equals(typeof(Hourly)))
                {
                    Hourly empHourly = (Hourly)emp;
                    displayString2 = displayString2 = empHourly.ToString() + " and the pay is: $" + empHourly.CaclucatePay() + "\n";
                }
            }
            MessageBox.Show("Salary Employees:\n" + displayString1 +"\n"+ "Hourly Employees:\n" + displayString2);
        }

        private void PayrollSystem_Load(object sender, EventArgs e)
        {
            ReadEmpsFromFile();
        }

        private void employeeListBox_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = employeeListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            InputForm frmInput = new InputForm();
            Employee emp = employeeListBox.SelectedItem as Employee;
            Type t = emp.GetType();
            if (t.Equals(typeof(Salary)))
            {
                frmInput.salaryRDButton.Checked = true;
                Salary empSalary = (Salary)emp;
                frmInput.annualSalaryTextBox.Text = empSalary.annualSalary.ToString();
            }
            if (t.Equals(typeof(Hourly)))
            {
                frmInput.hourlyRDButton.Checked = true;
                Hourly empHourly = (Hourly)emp;
                frmInput.hourlyRateTextBox.Text = empHourly.hourlyRate.ToString();
                frmInput.hoursWorkedTextBox.Text = empHourly.hoursWorked.ToString();
            }

            frmInput.FirstNameTextBox.Text = emp.FirstName;
            frmInput.LastNameTextBox.Text = emp.LastName;
            frmInput.SSNTextBox.Text = emp.SSN;
            frmInput.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
            frmInput.HealthInsTextBox.Text = emp.benefits.healthInsurance;
            frmInput.LifeInsTextBox.Text = emp.benefits.lifeInsurance.ToString();
            frmInput.VacationTextBox.Text = emp.benefits.vacation.ToString();

            DialogResult result = frmInput.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            employeeListBox.Items.RemoveAt(selectedIndex);

            string fName = frmInput.FirstNameTextBox.Text;
            string lName = frmInput.LastNameTextBox.Text;
            string ssn = frmInput.SSNTextBox.Text;
            string date = frmInput.HireDateTextBox.Text;
            DateTime hireDate = DateTime.Parse(frmInput.HireDateTextBox.Text);
            string healthIns = frmInput.HealthInsTextBox.Text;
            double lifeIns = double.Parse(frmInput.LifeInsTextBox.Text);
            int vacation = Int32.Parse(frmInput.VacationTextBox.Text);
            Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
            Employee emp1 = new Employee(fName, lName, ssn, hireDate, benefits);
            employeeListBox.Items.Add(emp1);
            WriteEmpsToFile();
            MessageBox.Show("Employee Updated");
        }
    }
}
