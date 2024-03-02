using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main {
    class Program {
        static void Main(string[] args) {
            Tollbooth t1 = new Tollbooth();

            Console.WriteLine("Press P if paying car found, N for non-paying and D for status: ");

            while (true) {
                
                char status = Convert.ToChar(Console.ReadLine());

                switch (status) {
                    case 'P':
                    case 'p':
                        t1.payingCar();
                        break;
                    case 'N':
                    case 'n':
                        t1.nonpayingCars();
                        break;
                    case 'D':
                    case 'd':
                        t1.display();
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }
    }
}
