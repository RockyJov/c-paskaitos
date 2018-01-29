using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasiu_pvz
{
    class Automobilis
    {

        public string Spalva { get; set; } // "prop" + TAB
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public double DarbinisTuris { get; set; }
        public int GalioKw { get; set; }

        
        public Automobilis() //ctor + TAB 
        {

        }

        public Automobilis(string _spalva, string _marke, string _modelis, int _rida, int _darbinisturis, int _galiokw)
        {
            Spalva = _spalva;
            Marke = _marke;
            Modelis = _modelis;
            Rida = _rida;
            DarbinisTuris = _darbinisturis;
            GalioKw = _galiokw;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilio {0} {1} duomenys", Marke, Modelis);
            Console.WriteLine("Spalva: " + Spalva);
            Console.WriteLine("Galio, kw: " + GalioKw);
            Console.WriteLine();
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite marke: ");
            Marke = Console.ReadLine();

            Console.WriteLine("Iveskite modeli: ");
            Modelis = Console.ReadLine();

            Console.WriteLine("Iveskite spalva: ");
            Spalva = Console.ReadLine();

            Console.WriteLine("Iveskite rida: ");
            Rida = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite darbini turi: ");
            //Convert.ToDouble(Console.ReadLine());
            string darbTuris = Console.ReadLine(); // nuskaitos kaip texta
            double darbTurisSK; // kur saugosim skaiciu jei pavyks convertuoti
            bool pavyko = double.TryParse(darbTuris, out darbTurisSK);
            if (pavyko)
            {
                DarbinisTuris = darbTurisSK;
            }
            else
            {
                Console.WriteLine("Iveskite galia KW: ");
            } // appsas, kad jei nesupranta kablelio ir tasko, tai ne crashina, o leidzia ivesti dar karta

        

            Console.WriteLine("Iveskite galia: ");
            Convert.ToInt32(Console.ReadLine());

        }
    }



    
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis(); // automobilis padarom viena dideli kintamaji, 
            automobilis.Marke = "asd";
            automobilis.Modelis = "bb";
            automobilis.Spalva = "zalia";
            automobilis.Rida = 20000;
            automobilis.DarbinisTuris = 2.0;
            automobilis.GalioKw = 120;

            // Console.WriteLine("{0} , {1} , {2} kw.,  {3} km.", automobilis.Spalva, automobilis.Marke,
            // automobilis.GalioKw, automobilis.Rida);

            automobilis.Isvedimas();

        

            var auto2 = new Automobilis
            {
                Marke = "asdas",
                Spalva = "sadasd",
                Rida = 121212,
                GalioKw = 120
            };
            //Console.WriteLine(automobilis.Marke);
            //Console.WriteLine(automobilis.GalioKw);
            auto2.Isvedimas();

            var auto3 = new Automobilis("juoda", "bmw", "batman", 20000, 2, 120); // geriausias budas isvesti duomenis
            //Console.WriteLine(auto3.GalioKw);
            //Console.WriteLine(auto3.Marke);
            auto3.Isvedimas();

            var auto4 = new Automobilis();
            auto4.Ivedimas();
            auto4.Isvedimas();

            

        }
    }
}
