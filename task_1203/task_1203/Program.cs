using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.TimeSpan time = DateTime.Now.TimeOfDay;

            if (time >= TimeSpan.FromHours(9.00) && time < TimeSpan.FromHours(12.00))
            {
                Console.WriteLine("{0}, good morning", time);
            }

            else if (time >= TimeSpan.FromHours(12.00) && time < TimeSpan.FromHours(15.00))
            {
                Console.WriteLine("{0}, good day", time);
            }

            else
            {
                Console.WriteLine("{0}, good evening", time);
            }
        }
    }
}
