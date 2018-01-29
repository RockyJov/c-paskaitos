using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite egzamino rezultata");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 100)
            {
                Console.WriteLine("100");
            }
            else if (a >= 80)
            {
                Console.WriteLine("80");
            }
            else if (a >= 50)
            {
                Console.WriteLine("50");
            }
            else if (a >= 20)
            {
                Console.WriteLine("20");
            }
            else if (a < 20) 
            {
                Console.WriteLine("maziau uz 20" );
            }
        }
    }
}
