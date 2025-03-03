using System;

namespace oop.son
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir matematiksel ifade girin:");
            string ifade = Console.ReadLine();

            int sonuc = Hesapla(ifade);

            Console.WriteLine("Sonuç: " + sonuc);
        }

        static int Hesapla(string ifade)
        {
            int sonuc = 0;
            int geciciSayi = 0;
            char sonOperator = '+';

            foreach (char c in ifade)
            {
                if (c >= '0' && c <= '9') 
                {
                    geciciSayi = geciciSayi * 10 + (c - '0');
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/') 
                {
                    sonuc = IslemiGerceklestir(sonuc, geciciSayi, sonOperator);
                    geciciSayi = 0;
                    sonOperator = c; 
                }
            }

            
            sonuc = IslemiGerceklestir(sonuc, geciciSayi, sonOperator);

            return sonuc;
        }

        static int IslemiGerceklestir(int sonuc, int sayi, char operatör)
        {
            switch (operatör)
            {
                case '+':
                    return sonuc + sayi;
                case '-':
                    return sonuc - sayi;
                case '*':
                    return sonuc * sayi;
                case '/':
                    return sonuc / sayi;
                default:
                    return Convert.ToInt32( "Geçersiz operatör: ");

            }
        }
    }
}
