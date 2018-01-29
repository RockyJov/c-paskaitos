using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_class_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomas = new Random();
            int suma = 0;
            var didziausias = 0;

            for (int i = 0; i < 50; i++)
            {
               // Console.Write(randomas.Next(20) + " "); // nuo 0 iki 20 vienas budas

                var skaicius = randomas.Next(20);
                Console.WriteLine(skaicius + " ");
                if (skaicius > didziausias)
                {
                    didziausias = skaicius; // surandam didziausia skaiciu
                }
            }
        }
    }
}
