using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_pavyzdiai
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) //isveda nuo 1 iki 10
            {
                Console.WriteLine(i);
            }
            Console.WriteLine( );

            for (int i = 0; i < 10; i++) //isveda nuo 1 iki 10 su tarpais
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 
            for (int i = 0; i < 10; i++) //isveda nuo 1 iki 10 su kabliai
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i += 2) //isveda kas antra 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 5; i < 10; i++) //isveda nuo 5 iki 9 su skliaustais
            {
                Console.Write("[{0}]", i);
            }
            Console.WriteLine();
            for (int i = 4 ; i < 20; i+=3) // isveda nuo 4 iki 20 pridedamas po 3
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            var pradzia = 10;
            var pabaiga = 15;

            for (int i = pradzia; i <= pabaiga; i++) // isveda nuo pradzios iki pabaigos
            {
                Console.Write(i);
            }
            Console.WriteLine();

            for (; ; )
            {
                Console.Write("Labas"); // begalinis ciklas
            }
                

        }


    }
}
