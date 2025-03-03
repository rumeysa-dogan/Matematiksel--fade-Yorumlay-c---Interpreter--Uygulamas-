using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.son
{
    public class ToplamaExpression : AbstractExpression
    {
       public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }

        public ToplamaExpression(int sayi1,int sayi2)
        {
            Sayi1 = sayi1;
            Sayi2 = sayi2;
        }
        public void Interpath(Context context)
        {
            context.Sonuc +=Sayi1+Sayi2;
        }
    }
}
