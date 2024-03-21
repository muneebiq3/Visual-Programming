using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray {
    class Program {

        static string merger(string[] array) {
            return string.Concat(array);
        }

        static void Main(string[] args) {

            string[] array = { "Hello ", "and ", "welcome ", "to ", "this ", "demo! " };
            string mergedString = merger(array);
            Console.WriteLine(mergedString);
            Console.ReadLine();

        }
    }
}
