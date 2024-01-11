using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cena:Kolicina
    {
        private double C;
        public double uc { get; set; }
              public double c
    {
        get { return C; }
        set { C = value; }
       

    }
         public Cena(double C,int B,string A):base(B,A)
         {
             this.C = C;
            
          
            
         }
         public double Ukupnacena(double c, int b)
         {
             uc = c * b;
             return uc;


         }
         public void Ispis()
         {
             Console.WriteLine("Vrsta proizvoda je:" + a);
             Console.WriteLine("Kolicina proizvoda je:" + b);
             Console.WriteLine("Ukupna cena je:" + uc);

            



         }

    }
}

