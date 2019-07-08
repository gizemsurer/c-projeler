using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz(Bolunen)");
            string sayi1 = Console.ReadLine();  // readline ın dördüğü şey string
            //yazmış olduğunuz program parçası hata üretme ihtimali fazlaysa sorunlu olacak kodumuzu try {} blogunun arasına yazılır.
            // catch blogta try blogunda oluşacak hatayla alakalı açıklama yazabılırsınız. catch {} blogu arasına yazılır.

            int sayiBolunen;
            try
            {

                sayiBolunen = Convert.ToInt32(sayi1);
                // int sayiBolunen = Convert.Toİnt32(Console.ReadLine());

            }
            catch
            {

                Console.WriteLine("girmiş oldupunuz değer dogru değil ");
                Console.ReadLine();
                return;

            }

            finally
            {
                Console.WriteLine("sizi tekrar görmek isteriz Ali Saraç ");
                Console.ReadLine();


            }
            
            Console.WriteLine("LÜtfen ikinci sayıyı giriniz(Bolen)");
            string sayi2 = Console.ReadLine();
            int sayiBolen;
            try
            {
                sayiBolen = Convert.ToInt32(sayi2);
                //int sayiBolen = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("girmiş olduğunuz ikinci değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("sizi tekrar aramızda görmek isteriz yeşim uğurlu");
                Console.ReadLine();   
            }
            // int sayiBolen = Convert.Toİnt32(Console.ReadLine());

            Console.WriteLine("İki sayının birbirine bölümünün sonucu ");
            // int sonucu fractional part ı attığı için
            // yani küsüratı kestiği için, sonuç int olarak hesaplanıyor.
            // eğer sonucun küsüratlı kısmı varsa ve biz bunu görmek istiyorsak 
            //Aşağıdaki satıra olduğu gib explicit conversion yapılabilir
            //yani sayılardan birini açık şekilde double'a cast ettik

            double sonuc;

            try
            {
                sonuc = (double)sayiBolunen / sayiBolen;

                // decimal sonuc = Decimal.Divide( sayiBolunen, sayiBolen );
            }
            catch
            {
                Console.WriteLine("bölme işlemi sırasında hata yapıyor");
                Console.ReadLine();
                return;
            }

            finally
            {
                Console.WriteLine("sizi tekrar aramızda görmek isteriz Gülsüm Çınar");
                Console.ReadLine();
            }

            Console.WriteLine(sonuc);

       
       
            Console.ReadLine();


        }
    }
}
