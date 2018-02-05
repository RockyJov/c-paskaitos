using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUI_Uzduotis_3_savarankiska_
{
    public class Miestas
    {
        public string Pavadinimas { get; private set; }
        public int Gyventoju_Skaicius { get; private set; }
        public double Plotas { get; private set; }

      /*Konstruktorius gavęs string eilute kintamąjį, jį turi išskaidyti naudojant eilute.Split(‘simbolis’);
Nurodytas simbolis, tai kaip toje eilutėje kiekvienas stulpelis yra atskirtas vienas nuo kito.
Išskaidę eilutę į dalis, kiekvieną narį priskirkite klasės kintamiesiems.
Pvz
var isskaidyta = eilute.Split(‘;’);
Pavadinimas = isskaidyta[0];
Ten kur reikia skaičių, nurodytą išskaidytos eilutės dalį konvertuokite.
*/

        public Miestas(string eilute)
        {
            var isskaidyta = eilute.Split(',');
            Pavadinimas = isskaidyta[0];
            Gyventoju_Skaicius = Convert.ToInt32(isskaidyta[1]);
            Plotas = Convert.ToDouble(isskaidyta[2]);
        }
    }
}
