using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your phone number: +92");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your email: ");
            String email = Console.ReadLine();

            Person p1 = new Person(name, age, phoneNumber, email);
            Console.WriteLine("Person: ");
            p1.behaviour();

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your phone number: +92");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your email: ");
            email = Console.ReadLine();

            Student s1 = new Student(name, age, phoneNumber, email);
            Console.WriteLine("Student: ");
            s1.behaviour();

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your phone number: +92");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your email: ");
            email = Console.ReadLine();

            Teacher t1 = new Teacher(name, age, phoneNumber, email);
            Console.WriteLine("Teacher: ");
            t1.behaviour();

            Console.ReadKey();

        }
    }
}
