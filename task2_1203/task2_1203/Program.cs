using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1203
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = (Color)(new System.Random().Next(0, 3));

            //Console.WriteLine(color);

            switch (color)
            {
                //case Color.Red:
                //    Console.WriteLine("THE COLOR IS RED");
                //    break;
                //case Color.Green:
                //    Console.WriteLine("THE COLOR IS GREEN");
                //    break;
                //case Color.Blue:
                //    Console.WriteLine("THE COLOR IS BLUE");
                //    break;
                default:
                    Console.WriteLine("NO COLOR DEFINED");
                    break;
            }

            //switch (color)
            //{
            //    case Color.Red:
            //        Console.WriteLine("THE COLOR IS RED");
            //        break;
            //    case Color.Green:
            //        break;
            //}

            Console.Read();
        }
    }

    public enum Color { Red, Green, Blue }

    
}
