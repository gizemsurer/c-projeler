using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.sayma işleminin 1'den başlayarak 100'ekadar birer birer
            //devam ettirilmsi,5 ve 5 in katlarına gelindiğinde ekrana sayı yerine
            //BOM yazdırılması
            //1.oyun
            //int i;
            //for(int i=1;i<=100;i++)
            //{
            //  System.Threading.Thread(500);
            //   if(if i%5!=0)
            //       {
            //           Console.WriteLine("bom");
            //           continue;

            //   }
            //{
            //   Console.WriteLine(i);
            //   System.Threading.Thread.Sleep(500);
            //}
            // }
            //
            //ekrana yazılan her sayıyı bir süre bekletmek için 
            //thread.sleep(500) kullanabilirsiniz
            //2.kendisine ve katlarına gelindiğinde BOM denilecek sayının 
            //console ekranından kullanıcı tarafından girilmesinin istenmesi, oyundaki
            //sayma işleminin bu girilen sayıya göre doğru şekilde ekrana yazdırırlması
            //

            // Console.WriteLine("hangi sayı katlarında BoM olmasını istersiniz");

            // int BOMKatsayisi = Convert.ToInt32(Console.ReadLine());
            //// for (int i = 1; i <= 100; i++)
            // {

            //
            //  if (i % BOMKatsayisi == 0)
            //  {

            //     Console.WriteLine("****BOM****");
            //    continue;
            // }
            // System.Threading.Thread.Sleep(500);




            // Console.WriteLine(i);
            //
            //System.Threading.Thread.Sleep(500);
            //
            // }
            // Console.ReadLine();

            //3.BOM denilecek sayının aynı şekilde kullanıcı tarafından girilmesinin 
            //ardından oyunun bilgisayar tarafından başlatılamsı,sırasıyla kullanıcı ve 
            //bilgisayar arasında devam ettirilmesi
            //
            //NOT:aşamada 3'te BOM sırası kullanıcıya geldiğinde ekrandan 
            //BOM yerine sayı girilirse kullanıcı oyunu kaybeder.
            //Bilgisayar oyunu karar yapılarına dayalı olarak oynanacağından
            //kaybedilmesi durumu göz önüne alınmayacaktır.Oyun 100'e kadar devam ettirilecek olup
            //kullanıcının kaybetmiş olması durumunda beraberlik durumu geçerli olacaktır ve
            //ekrana "oyun berabere" yazdırılmalıdır.

            Console.WriteLine("hangi sayı katlarında BoM olmasını istersiniz");
            int BOMKatsayisi = Convert.ToInt32(Console.ReadLine());
            int hataSayisi = 0;
            string sizinSayiniz;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1) //bilgisayarın sırası
                {
                    if (i % BOMKatsayisi == 0)
                    {
                        Console.WriteLine("Bilgisayar: BOM");
                    }
                    else
                    {
                        Console.WriteLine("Bilgisayar: " + i);

                    }
                }
                else // benim sıram
                {
                    if (i % BOMKatsayisi == 0)
                    {
                        Console.Write("Siz: ");
                        if (Console.ReadLine() != "BOM")
                            hataSayisi++;
                    }
                    else
                    {
                        Console.Write("Siz:");
                        sizinSayiniz = Console.ReadLine();
                        if (sizinSayiniz.All(char.IsDigit) == false || Convert.ToInt32(sizinSayiniz) != i)
                            hataSayisi++;
                    }
                }
            } //for

            if (hataSayisi == 0)
                Console.WriteLine("OYUN BERABERE BİTTİ");
            else
                Console.WriteLine("{0} ADET HATA YAPARAK OYUNU KAYBETTİNİZ", hataSayisi);

            Console.ReadLine();
        }
    }
}



