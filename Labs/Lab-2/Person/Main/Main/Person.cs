using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class Person {

        private String name;
        private int age;
        private Int64 phoneNumber;
        private String email;

        public Person() { }

        public Person(String name, int age, long phoneNumber, String email) {

            this.name = name;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }

        public void setName(String name) {
            this.name = name;
        }

        public String getName() {
            return name;
        }

        public void setAge(int age) {
            this.age = age;
        }

        public int getAge() {
            return age;
        }

        public void setPhoneNumber(long phoneNumber) {
            this.phoneNumber = phoneNumber;
        }

        public Int64 getPhoneNumber() {
            return phoneNumber;
        }

        public void setEmail(String email) {
            this.email = email;
        }

        public String getEmail() {
            return email;
        }

        public void behaviour() {
            Console.WriteLine("Existing!");
        }

    }
}
