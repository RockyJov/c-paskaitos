using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUI_Uzduotis_3_savarankiska_
{
    public class Pasaulis
    {
        public List<Salis> Saliu_sarasas { get; private set; } = new List<Salis>();


        public Miestas Daugiausiai_gyventoju()
        {
            var daugiausiai = Saliu_sarasas.First().Miestu_sarasas.First();
            foreach (var Salis in Saliu_sarasas)
            {
                foreach (var Miestas in Salis.Miestu_sarasas)
                {
                    if (Miestas.Gyventoju_Skaicius > daugiausiai.Gyventoju_Skaicius)
                    {
                        daugiausiai = Miestas;
                    }
                }
            }
            return  daugiausiai;


        }

        public Miestas Maziausiai_Gyventoju()
        {
            var maziausiai = Saliu_sarasas.First().Miestu_sarasas.First();
            foreach (var Salis in Saliu_sarasas)
            {
                foreach (var Miestas in Salis.Miestu_sarasas)
                {
                    if (Miestas.Gyventoju_Skaicius < maziausiai.Gyventoju_Skaicius)
                    {
                        maziausiai = Miestas;
                    }
                }
            }
            return maziausiai;
        }
               

        public Miestas Maziausias_Miestas()
        {
            var maziausias = Saliu_sarasas.First().Miestu_sarasas.First();
            foreach (var Salis in Saliu_sarasas)
            {
                foreach (var Miestas in Salis.Miestu_sarasas)
                {
                    if (Miestas.Plotas < maziausias.Plotas)
                    {
                        maziausias = Miestas;
                    }
                }
            }
            return maziausias;
        }
    }
}