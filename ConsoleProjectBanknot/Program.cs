using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKalanPara
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Uruna1adedi;
            Double Uruna2adedi;
            Double toplam = 0;
            double paraUstu;
            Double girilenTutar = 0;
            double kalan = 0;
            int bolum;
            Console.WriteLine("ürüna1 adedini giriniz");
            Uruna1adedi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ürüna2 adedini giriniz");
            Uruna2adedi = Convert.ToDouble(Console.ReadLine());
            toplam = (Uruna1adedi * 0.5) + (Uruna2adedi * 2);
            Console.WriteLine("ödeyeceğiniz tutar: " + toplam);
            Console.WriteLine("toplamdan büyük bir tutar giriniz");
            girilenTutar = Convert.ToDouble(Console.ReadLine());
            paraUstu = girilenTutar - toplam;
            Console.WriteLine("para üstünüz:" + paraUstu);
            bolum = (int)paraUstu / 10;
            kalan = paraUstu - (bolum * 10);
            Console.WriteLine("10'luk: " + bolum);
            bolum = (int)kalan / 5;
            kalan = kalan - (bolum * 5);
            Console.WriteLine("5'lik: " + bolum);
            bolum = (int)kalan / 2;
            kalan = kalan - (bolum * 2);
            Console.WriteLine("2'lik: " + bolum);
            bolum = (int)kalan / 1;
            Console.WriteLine("kalan miktar " + bolum);
            if (kalan % 2 == 1)
            {
                Console.WriteLine("para üstü verilmeyecetir");

            }
            Console.ReadLine();



        }


    }
}

