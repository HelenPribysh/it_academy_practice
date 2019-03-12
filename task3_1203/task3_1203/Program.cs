using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_1203
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (object.Equals(word[i], 'a'))
                    count += 1;
            }
            Console.WriteLine(count);
        }
    }
}
