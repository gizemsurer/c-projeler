using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject25
{
    class Program
    {
        static void Main(string[] args)
        {//kaç adet sayı toplayacağını sor
            //okadar sayıyı tola
            int sayi;
            int sayac = 1;
            int toplam=0;
            Console.WriteLine("kaç adet sayı toplanacak");
            sayi = Convert.ToInt32(Console.ReadLine());
            while(sayac<=sayi)
            {
                try
                {
                    Console.WriteLine(sayac + ".sayıyı giriniz");
                    Console.ReadLine();
                    sayac++;
                }
                catch
                {
                    Console.WriteLine("hatalı giriş yaptınız");
                    continue;
                }
                toplam = toplam + sayi;
                

            }
            Console.WriteLine("sayıların toplamı " + toplam);
            Console.ReadLine();


        }  
        

    }
}
