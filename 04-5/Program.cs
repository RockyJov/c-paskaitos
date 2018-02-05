using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laipsnius:");
            var laipsniai = Convert.ToInt32(Console.ReadLine());
            var kelvinai = laipsniai + 273;
            var farenheitai = laipsniai * 9 / 5 + 32;
        
            Console.WriteLine("{0} laipniai yra {1} Kelvinu ir {2} farenheitu", laipsniai, kelvinai, farenheitai );
            Console.ReadKey();
        }
    }
}
