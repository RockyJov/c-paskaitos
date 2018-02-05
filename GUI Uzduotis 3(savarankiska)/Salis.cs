using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUI_Uzduotis_3_savarankiska_
{
/*Konstruktorius per argumentus gauna kelią iki failo. Šį failą jis pats turi nuskaityti ir gautus duomenis iš jo sudėti į klasės kintamuosius.

Visą failą vienu metu galima nuskaityti naudojant File.ReadAllLines(failas);
Gautą atsakymą derėtų kur nors išsisaugoti.
ReadAllLines grąžina string[], kuriame kiekvienas elementas yra kiekviena atskira failo eilutė.

Pirmosios dvi failo eilutės yra šalies pavadinimas ir žemynas, kurioje ji yra, todėl galima šiuos du duomenis iškart pasiimti per indeksus 0 ir 1.

Toliau reiktų eiti per visas likusias nuskaitytas failo eilutes ir jas apdoroti. Paprasčiausiai būtų jei būtų sukamas for ciklas nuo 2 iki to teksto eilučių kiekio (tekstas.Length).

Cikle kuriamas miesto objektas, naudojant jo konstruktorių, kuris gauna visą nurodytą eilutę ir ją apdoroja. Šį miestą reikėtų nepamiršti pridėti prieš šalies miestų sąrašo.
*/

   public class Salis
    {
        public string Pavadinimas { get; private set; }
        public string Zemynas { get; private set; }
        public List<Miestas> Miestu_sarasas { get; private set; } = new List<Miestas>(); 

        public Salis(string failas)
        {
            var tekstas = File.ReadAllLines(failas); //kodel braukia File? - nes neparasiau using System.IO

            Pavadinimas = tekstas[0].Split(',')[0];
            Zemynas = tekstas[1].Split(',')[0];

            for (int i = 2; i < tekstas.Length; i++) 
            {
                var miestas = new Miestas(tekstas[i]);
                Miestu_sarasas.Add(miestas);
            }
        }
    }
}
