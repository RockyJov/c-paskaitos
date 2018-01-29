using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a % 9 != 0)
            {
                Console.WriteLine("Iveskite atsitiktinius skaicius");
                a = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Ivedete skaiciu kuris dalinas is 9");
        }
    }
}
