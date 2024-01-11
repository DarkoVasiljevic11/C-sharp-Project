using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Kolicina:VrstaProizvoda
    {
         private int B;
              public int b
    {
        get { return B; }
        set { B = value; }
       

    }
         public Kolicina(int B,string A):base(A)
         {
             this.B = B;
         }

    }
}
