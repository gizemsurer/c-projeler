using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject38
{
    class Program
    {//kullanıcı alacağı para üstünü girsin
        //para üstü veren makinada sadece 2,5,10'luk banknotlar bulunmaktadır
        //kullanıcıya en az adet banknot ile paraüstü veren uygulamayı yazınız 
        //eğer kullanıcı para üstü olarak direkt 1 veya 3 yazarsa sistem uyarı mesajı versin
        static void Main(string[] args)
        {
            int onlukAdedi;
            int beslikAdedi;
            int ikilikAdedi;
            int kalan;
            int paraUstu;
            Console.WriteLine("lütfen para üstü giriniz.");
            paraUstu=Convert.ToInt32(Console.ReadLine());

            onlukAdedi =paraUstu / 10;
            paraUstu = paraUstu % 10;

            beslikAdedi = paraUstu / 5;
            paraUstu = paraUstu % 5;

            ikilikAdedi = paraUstu / 2;
            paraUstu = paraUstu % 2;

            kalan = paraUstu;
            
            
            if(kalan>0)

            {
                int ekikilikAdedi;
                if (beslikAdedi>0)
                {
                    
                    beslikAdedi--;
                    ekikilikAdedi=(5 + kalan) / 2;
                    ikilikAdedi = ikilikAdedi + ekikilikAdedi;
                    kalan = 0;
                }
                else
                {
                    if(onlukAdedi>0)
                    {
                        onlukAdedi--;
                        beslikAdedi++;
                        ekikilikAdedi = (5 + kalan) / 2;
                        ikilikAdedi = ikilikAdedi + ekikilikAdedi;
                        kalan = 0;
                    }
                    else
                    {
                        Console.WriteLine("lütfen 1 veya 3 dışında bir para üstü girin.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
            }
            Console.WriteLine("onluk adet sayısı=" + onlukAdedi);
            Console.WriteLine("beşlik adet sayısı=" + beslikAdedi);
            Console.WriteLine("ikilik adet sayısı=" + ikilikAdedi);
            Console.WriteLine("kalan = " + kalan);
            Console.ReadLine();

        }
    }
}
