using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("ivesk teigiama durniau!");
            }
            if(a > 0)
            {
                Console.WriteLine("saunuolis kazka sugebi");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("skaicius yra lyginis");
            }
            if(a % 4 == 0)
            {
                Console.WriteLine("skaicius dalinasi is 4");          
            }
            if(a > 10)
            {
                Console.WriteLine("skaicius yra didesnis uz 10");
            }
            Console.ReadKey();
        }
        
    }
}
