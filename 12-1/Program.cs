using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] pazymiai = { 2, 4, 6, 7, 4, 6, 6, 9 };
            Console.WriteLine(pazymiai[2]); // 6
            pazymiai[3] = 2; //keiciam 7 i 2
            foreach (var pazimys in pazymiai) // kai pro visa masyva norim praeit
            {
                Console.WriteLine(pazimys + " " );
            }

            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.WriteLine(pazymiai[i] + " ");
            }


            var vardai = new string[7];
            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("iveskite varda: ");
                vardai[i] = Console.ReadLine();
            }
            Console.WriteLine();

            foreach (var vardas in vardai)
            {
                Console.Write(vardas  + " " );

            
            }
            
            //pazymiai

            Console.WriteLine("kiek pazymiu norite suvesti");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var pazymiai2 = new int[kiek];

            for (int i = 0; i < pazymiai2.Length; i++)
            {
                Console.WriteLine("Iveskite {0}-aji pazymi: ", i+1);
                pazymiai2[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            foreach (var pazimys in pazymiai2)
            {
                Console.WriteLine(pazimys + " " );
            }
            //algoritmas - suma
            var suma = 0;
            foreach (var pazymys in pazymiai2)
            {
                suma += pazymys;
            }
            Console.WriteLine("suma = " + suma);

            //min pazymis
            var maziausias = pazymiai2[0];
            foreach (var pazymys in pazymiai2)

                if (pazymys < maziausias)
                {
                    maziausias = pazymys;
                }
            Console.WriteLine("maziausias pazimys yra: " + maziausias);

            //max pazimys
            var didziausias = pazymiai2[0];
            foreach (var pazymys in pazymiai2)
            {
                if (pazymys > didziausias)
                {
                    didziausias = pazymys;
                }
            }
            Console.WriteLine("didziausias pazimys: " + didziausias);
            
 
        }
    }
}
