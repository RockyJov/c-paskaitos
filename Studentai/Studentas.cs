using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentai
{
    class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCM { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }


        public Studentas()
        {
        
        }// tuscias konstruktorius, kad veiktu
        public Studentas(string vardas, string pavarde, int ugisCM, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugisCM;
            Amzius = amzius;
            Lytis = lytis;
        }
        //isvedimo metodas
        public void Isvedimas()
        {
            Console.WriteLine("Duomenys apie studenta: {0} {1}", Vardas, Pavarde);
           
            Console.Write("Stundento amzius: " + Amzius);
            
            Console.Write("Studento ugis: " + UgisCM);
            
            Console.Write("Studento lytis: " + Lytis);

            Console.WriteLine();
            Console.WriteLine();

            
            
            
        }
         
        
    }
}
