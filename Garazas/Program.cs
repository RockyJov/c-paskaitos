using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garazas
{
    class Program
    {
        static void Main(string[] args)
        {
            var garazas = new Garazas("Garaziuks", "Kaune prie namu", 4, new List<Automobilis> {
                new Automobilis("BMW", "Batman", 2020, 4534,55, 4.7, "Juodas"),
                new Automobilis("Audi", "Bulka", 1990, 453444, 122, 1.7, "Balta"),
                new Automobilis("Siera", "siera", 2000, 453434,150, 1.9, "Zalia"),
                new Automobilis("Mersas", "S klases", 2010, 10000, 200,  3.7, "Sidabrinis")

            });

            garazas.Isvedimas();
            garazas.AtnaujintiPasirinkti();
            garazas.Skaiciavimai();
        }
    }
}
