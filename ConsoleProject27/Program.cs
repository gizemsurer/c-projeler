//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleProject27
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            while (true)
//            {
//                int sayi;
//                int sonuc=1;

//                try
//                {
//                    Console.WriteLine("faktöriyel sayısını yazınız");
//                    sayi = Convert.ToInt32(Console.ReadLine());
//                }
//                catch
//                {
//                    Console.WriteLine("hatalı değer girdiniz");
//                    continue;
//                }
//                while(true)
//                {


//                    for (int i=1;i<=sayi;i++)

//                    {
//                        sonuc=sonuc*i;

//                    }
//                    Console.WriteLine(sonuc);
//                    Console.ReadLine();

//                    break;
//                }


//            }



//        }
//    }
//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleProject27
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                int girilen;
//                int sonuc = 1;
//                string okunan = "";
//                int i;

//                try
//                {
//                    Console.WriteLine("faktöriyel sayısını yazınız");
//                    girilen = Convert.ToInt32(Console.ReadLine());
//                }
//                catch
//                {
//                    Console.WriteLine("hatalı değer girdiniz");
//                    continue;
//                }

//                for (i = 1; i <= girilen; i++)
//                {
//                    sonuc = sonuc * i;
//                    if (i == girilen)
//                    {
//                        okunan = okunan + i;
//                        Console.WriteLine(okunan);
//                    }
//                    else
//                    {
//                        okunan = okunan + i + " * ";
//                    }
//                    if(girilen==0)
//                     {
//                     okunan="0 sayısının faktöriyeli 1";
//                      console.writeline(okunan);
//                }
//                Console.WriteLine("sayıların faktöriyeli " + okunan + " = " + sonuc);
//                Console.ReadLine();
//            }//while
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject27
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int girilen;
                int sonuc = 1;
                
                int i;

                try
                {
                    Console.WriteLine("faktöriyel sayısını yazınız");
                    girilen = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("hatalı değer girdiniz");
                    continue;
                }

                for (i = 1; i <= girilen; i++)
                {
                    sonuc = sonuc * i;
                  
                    Console.WriteLine(i + "sayısının faktöriyeli= " +sonuc);
                }
                Console.ReadLine();
            }//while
        }
    }
}
