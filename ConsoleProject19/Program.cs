//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleProject19
//{
//    class Program
//    {
//        static void Main(string[] args)
//            //belirlenen kullanıcı adı ve şifre doğru girildiğinde giriş başarılı yanlış girildiğinde girdiğiniz kullanıcı adı veya şifre hatalı
//           // mesajı veren consol uygulamasını yapın
//           //kullanıcı adı "admin"
//           //şifre "123456"

//        {
//            string kullaniciAdi;
//            string sifre;
//            Console.WriteLine("kullanıcı adını giriniz");
//            kullaniciAdi=Console.ReadLine();
//            Console.WriteLine("şifre giriniz");
//            sifre=Console.ReadLine();

//            if (kullaniciAdi =="admin"&& sifre=="123456")

//            {
//                Console.WriteLine("giriş başarılı");
//            }

//            else
//            {
//                Console.WriteLine("hatalı kullanıcı adı veya şifre girdiniz");
//            }
//            Console.ReadLine();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject19
{
    class Program
    {
        static void Main(string[] args)
        //belirlenen kullanıcı adı ve şifre doğru girildiğinde giriş başarılı yanlış girildiğinde girdiğiniz kullanıcı adı veya şifre hatalı
        // mesajı veren consol uygulamasını yapın
        //kullanıcı adı "admin"
        //şifre "123456"

        {
            string kullaniciAdi;
            string sifre;
            while (true)
            {
                Console.WriteLine("kullanıcı adını giriniz");
                kullaniciAdi = Console.ReadLine();
                if (kullaniciAdi != "admin")
                {
                    Console.WriteLine("girdiğiniz kullanıcı adı hatalı");
                    continue;
                }
                int sayac = 5;
                while (sayac>0)
                {
                    Console.WriteLine("şifre giriniz");
                    sifre = Console.ReadLine();

                    if (sifre != "123456")
                    {
                        Console.WriteLine("girdiğiniz şifre hatalı");
                        sayac = sayac - 1;
                        Console.WriteLine("toplam" + sayac +"deneme hakkınız kaldı");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                if (sayac==0)
                {
                    Console.WriteLine("şifre deneme hakkınız bitmiştir");
                    Console.ReadLine();
                    return;
                }

                
                Console.WriteLine("giriş başarılı");
                Console.ReadLine();
               //return;//return komple programdan çıkar//break loop'tan çıkar//return'dan sonra kod olsaydı onları çalıştırmadan programdan çıkardı
                
               
            }
            
        }
        
    }
}
