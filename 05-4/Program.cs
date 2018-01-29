using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk 5 pazymius");
            var paz1 = Convert.ToInt32(Console.ReadLine());
            var paz2 = Convert.ToInt32(Console.ReadLine());
            var paz3 = Convert.ToInt32(Console.ReadLine());
            var paz4 = Convert.ToInt32(Console.ReadLine());
            var paz5 = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (double)(paz1 + paz2 + paz3 + paz4 + paz5) / 5; 

            Console.WriteLine("pazymiu vidurkis yra {0}", vidurkis);
        }
    }
}
