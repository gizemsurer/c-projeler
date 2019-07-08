using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Birinci Scope(Blok)
            //int a = 20;
            //Console.WriteLine(a);
            //Console.ReadLine();
            //Console.Read();

            string isim = "";
            string soyIsim = "";

            Console.WriteLine("Lütfen isminizi giriniz.");
            isim = Console.ReadLine();

            Console.WriteLine("Lütfen soyisminizi giriniz.");
            soyIsim = Console.ReadLine();

            string adSoyad;
            // "karakterinin metin içinde gözükmesi için \ " kullan
            adSoyad = isim + " \" MERHABA \" " + soyIsim;

            // \ karakterinin metin içinde gözükmesi için \\ kullan
            adSoyad = isim + " \\ MERHABA \\" + soyIsim;

            // \ karakterinin metin içinde gözükmesi için \\ kullan
            adSoyad = isim + " \\" + "MERHABA" + "\\ " + soyIsim;

            Console.WriteLine(adSoyad);

            adSoyad = isim + " " + soyIsim;
            Console.WriteLine(adSoyad);

            Console.ReadLine();
          

        }
    }

    class Program2
    {

    }
}
