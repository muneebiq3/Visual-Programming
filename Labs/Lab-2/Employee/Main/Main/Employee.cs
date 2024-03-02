using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class Employee {

        private String name;
        private int ID;

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public int getID()
        {
            return ID;
        }
    }
}
