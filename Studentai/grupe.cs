using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentai
{
    class grupe // darbas su listais
    {
        public List<Studentas> Studentai { get; set; } = new List<Studentas>(); // sudarom nauja lista 

        public grupe()
        {
            Studentai.Add(new Studentas("Rokas", "Jov", 130, 20, 'v'));
            Studentai.Add(new Studentas("Tomas", "Tom", 150, 30, 'v'));
            Studentai.Add(new Studentas("Petras", "Jov", 180, 28, 'v'));
            Studentai.Add(new Studentas("Kamile", "B", 132, 23, 'm'));
            Studentai.Add(new Studentas("Giedrius", "P", 193, 67, 'v'));


        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentai");
            foreach (var studentas in Studentai)
            {
                studentas.Isvedimas();
            }
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Skaiciavimai");
            Console.WriteLine();

            Console.WriteLine("Zemiausias studentas");
            var zemiausias = ZemiausiasStudentas();
            zemiausias.Isvedimas();
            Console.WriteLine();
        
            Console.WriteLine("Auksciausias studentas");
            var auksciausias = AuksciausiasStudentas();
            zemiausias.Isvedimas();

        }
        //grupes klaseje nauji metodai:
        //zemiausias studentas

        public Studentas ZemiausiasStudentas()
        {
            var zemiausias = Studentai[0];

            foreach (var studentas in Studentai)
            {
                if (studentas.UgisCM < zemiausias.UgisCM)
                {
                    zemiausias = studentas;
                }
            }


            return zemiausias;


        }
        //auksciausias studentas
        public Studentas AuksciausiasStudentas()
        {
            var auksciausias = Studentai[0];

            foreach (var studentas in Studentai)
            {
                if (studentas.UgisCM > auksciausias.UgisCM)
                {
                    auksciausias = studentas;
                }
            }
            return auksciausias;


            //kiek moteru
            
            //kiek vyru
            //amziu vidurkis

        }
        
    }
}
