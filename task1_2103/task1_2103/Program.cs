using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2103
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            EmptyArray();

            //task2
            ArrayOfDifferentSymbols();
        }

        public static void EmptyArray()
        {
            int[] emptyArray = new int[0];
            Console.WriteLine(emptyArray.Length);
        }

        public static void ArrayOfDifferentSymbols()
        {
            string[] arrayOfDifferentSymbols = new string[] { "10", "A", "Hello" };
            foreach (string i in arrayOfDifferentSymbols)
                Console.WriteLine(i);

            arrayOfDifferentSymbols[0] = Convert.ToString((Convert.ToInt32(arrayOfDifferentSymbols[0]) + 10));
            arrayOfDifferentSymbols[2] += ", guys!";
            foreach (string i in arrayOfDifferentSymbols)
                Console.WriteLine(i);
        }
    }
}
