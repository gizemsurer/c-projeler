using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProje15  
{
    class Program
    {
        static void Main(string[] args)
        {
          int toplam = 0;
          int adet = 0;
          for (int i = 0; i <= 1000; i++)
            {
                if ((i%5==0) && (i%7!= 0))
             {
                Console.WriteLine(i) ;
                toplam = toplam + i;
                adet++;
                //adet = adet + 1;
             }
            }
           Console.WriteLine("sayıların toplamı: " + toplam);
           Console.WriteLine("sayı adedi: "+ adet );  
           Console.ReadLine();
        }
    } //bu döngü 1000 e kadar olan sayıları ve 5 bölünüp 7 ye bölünmeyenleri toplayıp ekrana verdi.
}
 