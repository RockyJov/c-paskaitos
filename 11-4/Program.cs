using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string zodis = "a";
            string zodziai = "";
            while (zodis != "exit") 
            {
                Console.Write("Iveskite po nauja zodi arba jei norite baigti parasykite exit: ");
                zodis = Console.ReadLine();
                if (zodis != "exit")
                {
                    zodziai += zodis + " ";
                }
            }
            Console.WriteLine(zodziai);
        }
    }
}
