using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 3;
            var c = 2;

            switch (a)
            {
                case 1:
                    Console.WriteLine(a + b+ c);
                    break;
                case 2:
                    Console.WriteLine(a - c);
                    break;
                case 3:
                    Console.WriteLine(b * c);
                    break;
                default:
                    Console.WriteLine("skaicius nerastas");
                    break;
            }
         
        }
    }
}
