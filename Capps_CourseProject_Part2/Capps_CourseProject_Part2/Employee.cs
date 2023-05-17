using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capps_CourseProject_Part2
{
    [Serializable]
    class Employee
    {
        //Attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits bene;

        //Constructors
        public Employee()
        {
            firstName = "unknown";
            lastName = "unknown";
            ssn = "unknown";
            hireDate = DateTime.MinValue;
        }
        public Employee(string firstName, string lastName, string ssn, DateTime hireDate, Benefits pBenefits)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            SSN = ssn;
            HireDate = hireDate;
            bene = pBenefits;
        }
        //Behaviors
        public override string ToString()
        {
            // Formatting Name Last, 000-00-0000, short date
            return firstName + "," + lastName + "," + ssn + "," + hireDate.ToShortDateString() + "," + bene.ToString();
        }
        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 0)
                    firstName = value;
                else
                    firstName = "unknown";
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 0)
                    lastName = value;
                else
                    lastName = "unknown";
            }
        }
        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                if (value.Length == 9 || value.Length == 11)
                    ssn = value;
                else
                    ssn = "unknown";
            }
        }
        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                if (value.Year >= 1950 && value.Year <= DateTime.Now.Year + 1)
                    hireDate = value;
                else
                    hireDate = DateTime.MinValue;
            }
        }
        public Benefits benefits
        {
            get
            {
                return bene;
            }
            set
            {
                bene = value;
            }
        }
        public double CaclucatePay()
        {
            return 0.0;
        }
    }
}
