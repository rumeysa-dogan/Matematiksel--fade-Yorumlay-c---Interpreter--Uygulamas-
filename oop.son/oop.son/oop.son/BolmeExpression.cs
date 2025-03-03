using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.son
{
    public class BolmeExpression : AbstractExpression
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        public BolmeExpression(int sayi1, int sayi2)
        {
            Sayi1 = sayi1;
            Sayi2 = sayi2;
        }
        public void Interpath(Context context)
        {
            if (Sayi2 > Sayi1)
            {
                context.Sonuc += Sayi2 / Sayi1;
            }
            else if(Sayi1 > Sayi2) 
            {
                context.Sonuc += Sayi1 / Sayi2;
            }
            else
            {
                Console.WriteLine("Sonuç :0 'a eşittir.");
            }

            
        }
    }
}
