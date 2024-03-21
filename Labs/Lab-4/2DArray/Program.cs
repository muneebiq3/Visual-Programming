using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray {
    class Program {
        static void Display(int[,] a) {

            foreach (int i in a)
                Console.Write($"{i}\t");
            Console.Write("\n");
        }
        static void Main(string[] args) {

            int[,] multiDimensionalArray = new int[2, 2];

            multiDimensionalArray[0, 0] = 1;
            multiDimensionalArray[0, 1] = 2;
            multiDimensionalArray[1, 0] = 3;
            multiDimensionalArray[1, 1] = 4;

            Display(multiDimensionalArray);

            Console.ReadLine();

        }
    }
}
