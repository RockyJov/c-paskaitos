using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodu_pvz
{
    class Matematika
    {
        public static int Suma(int a, int b)
        {
            return a + b;// grazina reiskme is suma()
        }
        public static int Skirtumas(int a, int b)
        {
            return a - b;
        }
        public static int Daugyba(int a, int b)
        {
            return a * b;
        }
        public static double Dalyba(int a, int b)
        {
            return (double)a / b;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinti();
            Atsisveikinti();
            Program programa = new Program(); // susikuriam, kad galetume isvesti is ne static klases metodo. kuriamas viena karta!
            programa.Pinigai();
            programa.Auto();


            Console.WriteLine(Matematika.Suma(1,4)); // kvieciam is matematika metodo kuri susikurem
            Console.WriteLine(Matematika.Skirtumas(10, 5));
            Console.WriteLine(Matematika.Daugyba(10, 40));
            Console.WriteLine(Matematika.Dalyba(10, 5));
        }


        static public  void Pasisveikinti() 
        {
        Console.WriteLine("Jusu vardas?");
        Console.WriteLine("Labas " + Console.ReadLine());
        }
        
        static public void Atsisveikinti() 
        {
            Console.WriteLine("Ate");
        }

        public void Pinigai()
        {
            Console.WriteLine("Pasakyte ka daro pinigai");
            var pinigai = Console.ReadLine();
            Console.WriteLine("atsakymas: ");
            Console.WriteLine(pinigai);
        }

        public void Auto()
        {
            Console.WriteLine("ka vairuoji?");
            var car = Console.ReadLine();
            Console.WriteLine("nice" + car);
        }
    }
}
