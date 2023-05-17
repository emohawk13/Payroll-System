using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capps_CourseProject_Part2
{
    [Serializable]
    internal class Hourly : Employee
    {
        public double hourlyRate { get; set; }
        public double hoursWorked { get; set; }
        public Hourly(string cFirstName, string cLastName, string cSSN, DateTime cHireDate, Benefits cbenefits, double chourlyRate, double cHoursWorked)
    : base(cFirstName, cLastName, cSSN, cHireDate, cbenefits)
        {
            hourlyRate = chourlyRate;
            hoursWorked = cHoursWorked;
        }
        public double annualSalary { get; set; }
        public override string ToString()
        {
            return FirstName + "," + LastName +
                "," + SSN + "," + HireDate.ToShortDateString() +
                "," + benefits.ToString() + "," + hourlyRate.ToString() + "," + hoursWorked.ToString();
        }
        public double CaclucatePay()
        {
            return hoursWorked * hourlyRate;
        }
    }
}
