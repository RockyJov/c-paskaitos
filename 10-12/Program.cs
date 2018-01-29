using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "fizz";
            string b = "buzz";
            string c = "fizzbuzz";

            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(c);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(a);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(b);
                }
                else 
                {
                    Console.WriteLine(i);
                }
               

            }
            
        }
    }
}
