using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capps_CourseProject_Part2
{
    [Serializable]
    class Benefits
    {
        private string hInsurance;
        private double lInsurance;
        private int vaca;
        public Benefits(string healthIns, double lifeIns, int vacationDays)
        {
            hInsurance = healthIns;
            lInsurance = lifeIns;
            vaca = vacationDays;
        }
        public string healthInsurance
        {
            get
            {
                return hInsurance;
            }
            set
            {
                hInsurance = value;
            }
        }
        public double lifeInsurance
        {
            get
            {
                return lInsurance;
            }
            set
            {
                lInsurance = value;
            }
        }
        public int vacation
        {
            get
            {
                return vaca;
            }
            set
            {
                vaca = value;
            }
        }
        public override string ToString()
        {
            return hInsurance + "," + lInsurance + "," + vaca;
        }
    }
}

