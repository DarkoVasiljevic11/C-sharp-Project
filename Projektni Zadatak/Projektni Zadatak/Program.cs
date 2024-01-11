using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Unesite vrstu proizvoda:");
                string P = Console.ReadLine();
                Console.WriteLine("Unesite kolicinu proizvoda:");
                int K = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesite cenu:");
                double C = Convert.ToDouble(Console.ReadLine());
                Cena cena = new Cena(C, K, P);
                cena.Ukupnacena(C, K);
                cena.Ispis();
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Pogresan unos");
                Console.ReadKey();

         

            }
        }
    }
}
