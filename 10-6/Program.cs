using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite reziu pradzia ir pagaiga");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            var pabaiga = Convert.ToInt32(Console.ReadLine());
            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    if (i % 8 == 0 || i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

        }
    }
}
