using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaicius");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            var pabaiga = Convert.ToInt32(Console.ReadLine());
            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    Console.WriteLine("{0}  {1}",i, i*i);
                }
                
            }
            else
            {
                Console.WriteLine("blogai ivesti skaiciai");
            }
        
        }
    }
}
