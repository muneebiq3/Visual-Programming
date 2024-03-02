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

            Console.Write("Enter your ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the hours you've worked so far: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            HourlyEmployee h1 = new HourlyEmployee(name, ID, hours);

            Console.Write("Calculated income of Hourly Employee: " + h1.calculateIncome(hours) + "\n");

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the hours you've worked so far: ");
            hours = Convert.ToInt32(Console.ReadLine());

            PermanentEmployee p1 = new PermanentEmployee(name, ID, hours);

            Console.WriteLine("Calculated income of Permanent Employee: " + p1.calculateIncome() + "\n");
        }
    }
}
