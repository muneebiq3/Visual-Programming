using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class HourlyEmployee : Employee {

        private int hourlyIncome;

        public HourlyEmployee(String name, int ID, int hourlyIncome)
        {

            this.setName(name);
            this.setID(ID);
            this.hourlyIncome = hourlyIncome;

        }

        public int calculateIncome(int hours)
        {
            this.hourlyIncome = 150 * hours;
            return hourlyIncome;
        }

    }
}
