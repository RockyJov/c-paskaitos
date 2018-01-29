using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var dv = 8;
            Console.WriteLine("iveskite, kiek darbuotojas ispeka kepalu per valanda");
            var kiekgaliiskepti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kiek darbuotoju turi kepykla?");
            var kiekdarbuotoju = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kepalo savikaina");
            var kepalosavikaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kepalo pardavimo kaina");
            var kepalopardavimokaina = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kiek keplykla turi uzsakymu");
            var kiekuzsakymu = Convert.ToInt32(Console.ReadLine());
            var kepaluperdiena = kiekdarbuotoju * dv * kiekgaliiskepti;
            var kepalusavikaina = kepaluperdiena * kepalosavikaina;
            var pajamos = kepaluperdiena * kepalopardavimokaina;
            var pelnas = pajamos - kepalusavikaina;
            var kieknespesiskepti = kiekuzsakymu - kepaluperdiena;

            Console.WriteLine("kepykla iskepe {0} kepalu per diena", kepaluperdiena);
            Console.WriteLine("Kepalu savikaina {0}, Gautos pajamos {1}, Pelnas {2}", kepalosavikaina, pajamos, pelnas);

            if (kiekuzsakymu < kepaluperdiena)
            {
                Console.WriteLine("keplykla spes iskepti tos dienos uzsakymus");
            }
            else
            {
                Console.WriteLine("nespejo iskepti {0}", kieknespesiskepti);
            }



        
        }
    }
}
