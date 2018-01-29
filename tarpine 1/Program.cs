using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            bool testi = true;
            int kiek = 1;

            while (a > 0)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (a % i != 0)
                    {
                        testi = false;
                        kiek = 1;
                        break;
                    }
                    else
                    {
                        kiek++;
                    }
                    if (kiek == 20)
                    {
                        testi = false;
                        Console.WriteLine("atsakymas: " + a);
                        a = -1;
                    }
                }


                a++;
            }




        }
    }
}
