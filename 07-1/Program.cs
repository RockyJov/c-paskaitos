using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 2 skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antra");
            }
            else if (b > a)
            {
                Console.WriteLine("antras skaicius didesnis uz pirma");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
        }
    }
}
