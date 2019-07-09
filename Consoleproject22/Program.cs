//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Consoleproject22
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {//bilgisayar 1 ile 10 arasında rastgele bir sayı tutsun
//         //oyunumuz "1.tahmiinşz:"yazısı ile başlasın
//         //eğer tahmin için yazdığınız sayı>10 ise
//         //tahmin sayısı 1 ile 10 arasında olmalıdır mesajı versin
//         //bu mesaj sonrası tekrar "1.tahmininiz diye sorsun
//         //kullanıcının girdiği tahmin sayısı eğer bilgisayarın tuttuğundan farklı ise 
//         //2.tahmininiz: yazısı çıksın
//         //doğru tahmini yapınca "sayıyı 5.tahminde buldun gibi bir mesaj versin.
//         //int tuttuguSayi=(new Random().next(1,10);
//         //random rnd=new Random();random classı cinsinde bir instance oluşturduk.


          //Random rnd = new Random();
          //int tuttugusayi = rnd.Next(1, 10);
           //tuttugusayi = Convert.ToInt32(Console.ReadLine());


      // Console.WriteLine("1.tahmini giriniz");
          //  int sayi = Convert.ToInt32(Console.ReadLine());          //  int sayac = 0;
          //  for (int i = 1; i <= 10; i++)
          //  {
               // sayac = sayac + 1;
               // if (sayi > 10)
                  //  Console.WriteLine("1-10 arasında olmalı");
//                else
//                {
//                    Console.WriteLine(i + ".tahmin");
//                    if (sayi != tuttugusayi)
//                    {
//                        return;
//                    }
//                    else
//                    {
//                       Console.WriteLine("doğru tahmin") ;
//                    }
//                }



//                Console.ReadLine();

//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayar 1 ile 10 arasında rastgele bir sayı tutsun
            //Oyunumuz "1.Tahmininiz:" yazısı ile başlasın
            //Eğer tahmin için yazdığınız sayı>10 ise 
            //"Tahmin sayısı 1-10 arasında olmalıdır." diye mesaj versin.
            //Bu mesaj sonrası tekrar "1.Tahmininiz: " diye sorsun
            //Kullanıcının girdiği tahmin sayısı eğer bilgisayarın tuttuğundan farklı ise
            //"2.Tahmininiz: " yazısı çıksın.
            //Bu işlemler kullanıcının tahmin ettiği sayı,
            //bilgisayarın tuttuğu sayıya eşit olana kadar devam etsin
            //Doğru tahminleme yapılınca;
            //"Sayıyı 5.tahmininizde buldunuz" gibi bir yazı yazılsın.


            Random rnd = new Random();// Random class'ı cinsinde bir instance oluşturduk.
            int tuttuguSayi = rnd.Next(1, 10);
            //int tuttuguSayi=(new Random()).Next(1,10);
            int tahminSirasi = 1;
            do
            {
                try
                {
                    Console.Write("{0}.Tahmininizi Giriniz: ", tahminSirasi);
                    int tahminSayisi;
                    tahminSayisi = Convert.ToInt32(Console.ReadLine());

                    if (tahminSayisi > 10)
                    {
                        Console.WriteLine("Tahmin sayısı 1-10 arasında olmalıdır. ");
                    }
                    else
                    {
                        if (tahminSayisi == tuttuguSayi)
                        {
                            Console.WriteLine("Sayıyı {0}.tahmininizde buldunuz", tahminSirasi);
                            break;
                        }
                        else
                            tahminSirasi++;
                    }
                }
                catch (Exception nesne)
                {
                    Console.WriteLine("Girdiğiniz değer hatalı!" + nesne.Message);
                }

            }
            while (true);
            Console.ReadLine();




        }
    }
}

