using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite betkoki skaiciu: ");
             var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(skaicius, 2));

        }
    }
}
