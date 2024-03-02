using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class PermanentEmployee : Employee{

        private int hourlyIncome;

        public PermanentEmployee(String name, int ID, int hourlyIncome)
        {

            this.setName(name);
            this.setID(ID);
            this.hourlyIncome = hourlyIncome;

        }
        public int calculateIncome()
        {
            this.hourlyIncome = 240 * 150;
            return hourlyIncome;
        }

    }
}
