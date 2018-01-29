using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Vardas = "Rokas";
            var Pavarde = "Jova";
            var amzius = 23;

            Isvedimas(Vardas, Pavarde, amzius);
            Ivedimas(ref Vardas, ref Pavarde, ref amzius); // tipu nereik maine( pvz string int.)
            Isvedimas(Vardas, Pavarde, amzius);


        }
        public static void Ivedimas(ref string Vardas,ref string Pavarde,ref int amzius) // static, kad nereik kurti objekto
        {
            Console.WriteLine("programije ivestas vardas: " + Vardas );
            Console.Write("Iveskite nauja: " );
            Vardas = Console.ReadLine(); // su ref keiciasi jo reiksme

            Console.WriteLine("programije ivesta pavarde: " + Pavarde);
            Console.Write("Iveskite nauja: ");
            Pavarde = Console.ReadLine();

            Console.WriteLine("programije ivestas amzius: " + amzius);
            Console.Write("Iveskite nauja: ");
            amzius = Convert.ToInt32(Console.ReadLine());
            
        }
        public static void Isvedimas(string Vardas, string Pavarde, int amzius)
        {
            Console.WriteLine("{0} , {1}, {2} m.", Vardas, Pavarde, amzius);            
        }
        
    }
}
