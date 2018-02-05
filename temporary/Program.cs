using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temporary
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int> { 4, 7, 8, 3 };
            for (int i = 1; i < skaiciai.Sum(); i++)
            {
                Console.Write(skaiciai[i]);
            }
        }
    }
}
