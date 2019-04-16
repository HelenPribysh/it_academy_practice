using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniqueltem uniqueltem0 = new Uniqueltem();
            uniqueltem0.Id = 2;
            Console.WriteLine(uniqueltem0.Id);
            Uniqueltem uniqueltem1 = new Uniqueltem();
            Console.WriteLine(uniqueltem1.Id);
        }
    }

    public class Uniqueltem
    {
        static private int _id;
        public int Id { get => _id; set => _id = value; }

        public Uniqueltem()
        {
            _id += 1;
        }
    }
}
