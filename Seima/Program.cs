using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seima
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var zmogus1 = new Zmogus();
            zmogus1.Isvedimas(); // ?

            var zmogus2 = new Zmogus("Rokas", "Jov", 180, 23, 'v');
            zmogus2.Isvedimas();*/

            var seima1 = new Seima("Kaunas", new List<Zmogus>
            {
                new Zmogus("roka", "jova", 23, 43, 'b'),
                new Zmogus("roka", "jova", 23, 43, 'b'),
                new Zmogus("roka", "jova", 23, 43, 'b')
            });
            seima1.Isvedimas();
           
            var seima2 = new Seima();
            seima2.Isvedimas();

            

        }
    }
}
