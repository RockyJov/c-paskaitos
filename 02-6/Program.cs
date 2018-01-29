using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "Lamborgini";
            var modelis = "Gallardo";
            var metai = 2010;
            var rida = 14000;

            Console.WriteLine("Automobilio {0}, {1}, {2} m. rida - {3} km.", marke, modelis, metai, rida); /*
            skliaustuose kas bus ivesta, o poto  rasosi reiksmes) */
            Console.ReadKey();
        }
    }
}
