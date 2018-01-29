using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;
            do
            {
                Console.WriteLine("1- suo, 2- kate,3- ziurkenas");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (pasirinkimas > 3 || pasirinkimas < 1)
                {
                    Console.WriteLine("blogai ivesti duomenys");
                }

            } while (pasirinkimas >= 3  || pasirinkimas <= 1);
            Console.WriteLine("pasirinkimas: " + pasirinkimas);
        }
    }
}
