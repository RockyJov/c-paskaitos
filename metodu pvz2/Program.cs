using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodu_pvz2
{
    class Program
    {


        static void Main(string[] args)
        {
            
            var nuvaziuotiKilometrai = new List<int>();
            Program programa = new Program();
            //metodai

            //duomenu ivedimui
            programa.Ivedimas(nuvaziuotiKilometrai);
            //duomenu isvedimui
            programa.Isvedimas(nuvaziuotiKilometrai, "PRADINIAI DUOMENYS");
            //skaiciavimu iskvietimui, kuris kvies siuos atskirus metodus
            //suma
            //min
            //max
            //vidurkis (vidurkis kviecia sumos metoda)
            //atrinkimui i kita sarasa tinkamu duomenu
            programa.Skaiciavimai(nuvaziuotiKilometrai);
            List<int> atrinkti = programa.Atrinkimas(nuvaziuotiKilometrai);
            programa.Isvedimas(atrinkti, "ATRINKTI DUOMENYS");


        } // main pabaiga

        public void Ivedimas(List<int> sarasas)//void nes nieko negrazinam
        {
            var dar = true;
            while (dar)
            {
                Console.WriteLine("Iveskite kilomatraza: " );
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);
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
            foreach (var km in sarasas)
            {
                Console.WriteLine("[{0}]",  km);
            }
            Console.WriteLine();
        }
        public int Suma(List<int> sarasas)// sum grzint inta
        {
            return sarasas.Sum();
            
            
        }
        public int min(List<int> sarasas)
        {
            return sarasas.Min();
        }
        public int max(List<int> sarasas)
        {
            return sarasas.Max();
        }

        public double Vidurkis(List<int> sarasas)
        {
            var vidurkis = (double)Suma(sarasas) / sarasas.Count;
            return vidurkis;

        } // vidurki naudojam sumos metoda
        public void Skaiciavimai(List <int> sarasas)
        {
            Console.WriteLine("suma: " + Suma(sarasas));
            Console.WriteLine("Min: " + min(sarasas));
            Console.WriteLine("Max: " + max(sarasas));
            Console.WriteLine("Vidurkis: " + Vidurkis(sarasas));
        } // skaiciavimu isvedimai
        public List<int> Atrinkimas(List<int> pradiniai) 
        {
            //daugiai nei 300k tai grabas
            var atrinkti = new List<int>();
            foreach (var km in pradiniai)
            {
                if (km > 300000)
                {
                    atrinkti.Add(km);
                }
            }
            return atrinkti;
        }



    }//class program pabaiga
}
