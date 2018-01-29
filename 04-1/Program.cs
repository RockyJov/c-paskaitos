using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jusu vardas:");
            var vardas = Console.ReadLine();
            Console.WriteLine("amzius:");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("jusu vardas : {0} jusu amzius: {1}", vardas, amzius);
        }
    }
}
