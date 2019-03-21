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
        }

        public static void EmptyArray()
        {
            int[] emptyArray = new int[0];
            Console.WriteLine(emptyArray.Length);
        }
    }
}
