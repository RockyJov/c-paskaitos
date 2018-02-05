using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seima
{
    class Seima
    {
        public string Adresas { get; private set; }
        public List<Zmogus> Zmones { get; private set; } = new List<Zmogus>();

       public Seima()
        {
            Ivedimas();
        }

        public Seima(string adresas, List<Zmogus> zmones)
        {
            Adresas = adresas;
            Zmones = zmones;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Seima gyvena {0} adresu", Adresas);
            foreach (var zmogus in Zmones)
            {
                zmogus.Isvedimas();
            }
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite adresa");
            Adresas = Console.ReadLine();
            //klausti kiek zmoniu suvesti
            //sukti cikla for tiek kartu kiek reik
            //kurti tuscia zmogaus objekta
            //kurti tuscia objekta naudojant () - tuscia konstruktoriu
            //zmoniu objekta ikelti i zmoniu sarasa
            Console.WriteLine("Irasykite, kiek norite zmoniu ivesti");
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <  kiek; i++)
            {
                var zmogus = new Zmogus();
                Zmones.Add(zmogus);
            }

        }


    }
}
