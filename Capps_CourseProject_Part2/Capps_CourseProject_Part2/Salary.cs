using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capps_CourseProject_Part2
{
    [Serializable]
    internal class Salary : Employee
    {
        public Salary(string cFirstName, string cLastName, string cSSN, DateTime cHireDate, Benefits cbenefits, double cAnnualSalary)
            : base(cFirstName, cLastName, cSSN, cHireDate, cbenefits)
        {
            annualSalary = cAnnualSalary;
        }
        public double annualSalary { get; set; }
        public override string ToString()
        {
            return FirstName + "," + LastName + "," + SSN + "," + HireDate.ToShortDateString() + "," + benefits.ToString()
                +","+ annualSalary.ToString();
        }
        public double CalculatePay()
        {
            return annualSalary /12.0;
        }
    }
}
