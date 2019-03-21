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
           // EmptyArray();

            //task2
           // ArrayOfDifferentSymbols();

            //task3
            MaxValue();
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

        public static void MaxValue()
        {
            Random random = new Random();
            int[] array = new int[13];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            foreach (int i in array)
                Console.WriteLine(i);

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.Write("max value ");
            Console.WriteLine(max);
        }
    }
}
