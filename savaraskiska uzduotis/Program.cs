using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savaraskiska_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            var temperaturos = new List<int>();


            //TEMA: dienu temperaturos
            // kuriat sarasa 
            //darot metodus:
            //ivediui
            programa.Ivedimas(temperaturos);
            //isvedimui
            programa.Isvedimas(temperaturos, "PRADINIAI DUOMENYS");
            //visu skaiciamu isvedimui\atrinkimui i nauja sarasa
            
        }
        public void Ivedimas(List<int> sarasas)//nes nieko negrazinam, o ivedam ar isvedam duomenis
        {
            var dar = true;
            while (dar)
            {
                Console.WriteLine("Iveskite temperatura: ");
                var temp = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(temp);
                Console.WriteLine("norit kartoti? t/n");
                var kartoti = Console.ReadLine();

                if (kartoti != "t")
                {
                    dar = false;
                }
            }
        }
        public void Isvedimas(List<int> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);
            foreach (var temp in sarasas)
            {
                Console.WriteLine("[{0}]", temp);
            }
            Console.WriteLine();
        }
        public int Suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }
        public int Min(List<int> sarasas)
        {
            return sarasas.Min();
        }
        public int Max(List<int> sarasas)
        {
            return sarasas.Max();
        }
        public double Vidurkis(List<int> sarasas)
        {
            var vidurkis = (double)Suma(sarasas) / sarasas.Count();
            return vidurkis;
        }
        public void Skaiciavimai(List<int> sarasas)
        {
            Console.WriteLine("Suma: " + Suma(sarasas));
            Console.WriteLine("Max: " + Max(sarasas));
            Console.WriteLine("Min: " + Min(sarasas));
            Console.WriteLine("Vidurkis: " + Vidurkis(sarasas));
        }
        public List<int> Atrinkimas(List<int> sarasas)
        {
            var atrinktas = new List<int>();

        }
    }
}
