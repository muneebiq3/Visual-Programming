using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class Teacher : Person {

        Teacher() { }

        public Teacher(String name, int age, Int64 phoneNumber, String email) {

            this.setName(name);
            this.setAge(age);
            this.setPhoneNumber(phoneNumber);
            this.setEmail(email);
        }

        public void behaviour() {
            Console.WriteLine("Teaching!");
        }

    }
}
