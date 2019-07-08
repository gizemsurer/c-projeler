using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject12
{
    class Program
    {
        static void Main(string[] args)
        {
          
                do
                {

                    Console.Write("(1-7) arasında bir gün giriniz: ");
                    int girilenGun = Convert.ToInt32(Console.ReadLine());
                    switch (girilenGun)
                    {
                        case 1:
                            Console.WriteLine("Pazartesi");
                            break;
                        case 2:
                            Console.WriteLine("Salı");
                            break;
                        case 3:
                            Console.WriteLine("Çarşamba");
                            break;
                        case 4:
                            Console.WriteLine("Perşembe");
                            break;
                        case 5:
                            Console.WriteLine("Cuma");
                            break;
                        case 6:
                            Console.WriteLine("Cumartesi");
                            break;
                        case 7:
                            Console.WriteLine("Pazar");
                            break;
                        default:
                            Console.WriteLine("Lütfen 1  ile 7 arasında bir sayı giriniz. ");
                            break;
                    }
                } while (true);
            
        }
    }
}
