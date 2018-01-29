using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spekite skaiciu");
            var randomas = new Random();
            var atsitiktinis = randomas.Next(10);
            var spejimas = Convert.ToInt32(Console.ReadLine());
            while (spejimas != atsitiktinis)
            {
                spejimas = Convert.ToInt32(Console.ReadLine());

                if (spejimas > atsitiktinis)
                {
                    Console.WriteLine("slaptas skaicius yra mazesnis");
                    

                }
                else if (spejimas < atsitiktinis)
                {
                    Console.WriteLine("slaptas skaicius yra didesnis ");
                    
                }
                else if (spejimas == atsitiktinis)
                {
                    Console.WriteLine("atspejote skaiciu");
                }
                

            }
        }
            
    }
}
