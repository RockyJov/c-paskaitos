using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seima
{
    class Zmogus
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int UgisCm { get; private set; }
        public int Amzius { get; private set; }
        public char Lytis { get; private set; }


        public Zmogus()
        {
            Ivedimas();
        }
        public Zmogus(string vardas, string pavarde, int ugiscm, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCm = ugiscm;
            Amzius = amzius;
            Lytis = lytis;

        }
        public void Isvedimas()
        {
            Console.WriteLine("{0} {1} {2} m. kurio/os ugis yra {3}, yra lyties {4}.", Vardas, Pavarde, Amzius, UgisCm, Lytis);
        }
        public void Ivedimas()
        {
            Console.WriteLine("Iveskite Varda, Pavarde, amzius, ugi, lyti: ");

            Console.WriteLine("Vardas: ");
            Vardas = Console.ReadLine();

            Console.WriteLine("Pavarde: ");
            Pavarde = Console.ReadLine();

            Console.WriteLine("Amzius: ");
            Amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ugis: ");
            UgisCm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lytis: ");
            Lytis = Convert.ToChar(Console.Read());
            Console.ReadLine();
        }
    }
    
}
