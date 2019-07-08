using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ay = "";
            do
            {
                try
                {
                    Console.WriteLine("Lütfen hangi ayda olduğumuzu giriniz. ");
                    ay = Console.ReadLine();
                    int = Int32.Parse(ay);
                    switch (ay)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("kış mevsimi");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("bahar mevsimi");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("yaz mevsimi");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("sonbahar mevsimi");
                            break;
                        default:
                            Console.WriteLine("Ay bilgisini yanlış girdiniz. ");
                            break;
                    }
                }
                catch(Exception nesne)
                {
                    if (ay == "Q" || ay == "q")
                    Console.WriteLine("İstisnai bir durum oluştu !" + nesne.Message);
                }
            } while (true);
               
        }
    }
}
