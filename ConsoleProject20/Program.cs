using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject20
{
    class Program
    {
        static void Main(string[] args)
        {//klavyeden iki ürünün fiyatı ayrı ayrı girildiğinde 
            //iki ürünün toplam fiyatı 200 tl'den gazla ise,
            //2.üründen %25 indirim yaparak,iki ürün için
            //toplam ödenecek tutarı gösteren uygulamayı yapınız
            while (true)
                { 
            double urunFiyat1, urunFiyat2, toplamFiyat;
                Console.WriteLine("birinci ürünün fiyatını giriniz");
                urunFiyat1 = Convert.ToDouble(Console.ReadLine());
                ;
                Console.WriteLine("ikinci ürünün fiyatını giriniz");
                urunFiyat2 = Convert.ToDouble(Console.ReadLine());
                toplamFiyat = urunFiyat1 + urunFiyat2;
                if (toplamFiyat >= 200)
                {
                    Console.WriteLine("toplam indirim=" + urunFiyat2 * 0.25);
                    urunFiyat2 = urunFiyat2 * 0.75;
                    toplamFiyat = urunFiyat1 + urunFiyat2;

                }
                else
                {
                    Console.WriteLine("toplamFiyat indirim =0");
                }
                Console.WriteLine("iki ürünün toplam fiyatı" + toplamFiyat);
                Console.ReadLine();
            }
        }
    }
}
