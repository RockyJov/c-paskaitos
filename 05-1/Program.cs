using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("pirmas ir antras skaicius yra lygus");
                
            }
            if (b == c)
            {
                Console.WriteLine("antras ir trecias skaiciai yra lygus");
                
            }
            if (a > b)
            {
                Console.WriteLine("pirmas skaicius yra didenis uz antraji");
            }
            if (b > c * 2)
            {
                Console.WriteLine("antras skaicius yra didensis negu 2 treti");
            
            }
            if(a % 2 == 0)
            {
                Console.WriteLine("pirmas skaicius yra lyginis");
            }
            if(b % 2 != 0)
            {
                Console.WriteLine("antras skaicius yra nelyginis");
            
            }
            if(c > 0)
            {
                Console.WriteLine("trecias skaicius yra teigiamas");
            }
            if (c < 0)
            {
                Console.WriteLine("trecias skaicius yra neigiamas");
            }
            Console.ReadKey();
        }
    }
}
