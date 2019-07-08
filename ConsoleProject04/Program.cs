using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject04
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 350;
            Console.WriteLine("İNT gösteriliyor");
            Console.WriteLine(sayi);
            Console.WriteLine("");

            //Bir alt satırdakı conversion dır. 
            //Fakat uygun değildir.
            //Çünkü, büyük veri tipi, daha küçük bir veri tipine dönüştürülmek istenmiştir.
            //Bu durum veri kaybına yol açacağı için hata vermiştir.Ama bilinçli bir
            //çevirim söz konusuysa bu durum explicit conversion ile çözülebilir.

            //byte sayiByte = sayi;
            byte sayiByte = (byte)sayi;
            Console.Write("İNT to BYTE gösteriliyor: ");       
            Console.WriteLine(sayiByte);
            Console.WriteLine("");

            long sayiLong = (byte)sayi;
            Console.Write("İNT to LONG gösteriliyor: ");
            Console.WriteLine(sayiLong);
            Console.WriteLine("");
    

            sbyte sayiSByte = (SByte)sayi;
            Console.Write("İNT to SBYTE gösteriliyor: ");
            Console.WriteLine(sayiSByte);

            double x = 1234.7;
            int a1;
            int a2;

            // cast double to int
            a1 = (int)x;             //truncate double (yuvarlamaz)
            Console.WriteLine("double to INT göster: ");
            Console.WriteLine(a1);


            a2 = Convert.ToInt32(x);   //convert to int (int e çevir)
            Console.WriteLine("double to INT conversion göster: ");
            Console.WriteLine(a2);

            Console.Beep(300, 3000);
            System.Threading.Thread.Sleep(3000);
            // Console.ReadLine();
        }
    }
}
