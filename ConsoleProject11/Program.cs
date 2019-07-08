using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)

                try
                {
                    double yazili1;
                    double yazili2;
                    double ortalamaDeger;

                    Console.WriteLine("Lütfen 1. yazılı notunu giriniz.");
                    yazili1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Lütfen 2. yazılı notunu giriniz.");
                    yazili2 = Convert.ToDouble(Console.ReadLine());
                    if (yazili1 < 0 && yazili2 < 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Negatif bir sayı giremezsiniz.");
                    }
                    else
                    {
                        ortalamaDeger = (yazili1 + yazili2) / 2;
                        Console.WriteLine("ortalama değeriniz: " + ortalamaDeger);

                        if (ortalamaDeger >= 0 && ortalamaDeger < 25)
                        {
                            Console.WriteLine("5'lik sistemde notunuz 0");
                        }
                        else if (ortalamaDeger >= 25 && ortalamaDeger < 45)
                        {
                            Console.WriteLine("5'lik sistemde notunuz 1");
                        }
                        else if (ortalamaDeger >= 45 && ortalamaDeger < 55)
                        {
                            Console.WriteLine("5'lik sistemde notunuz 2");
                        }
                        else if (ortalamaDeger >= 55 && ortalamaDeger < 70)
                        {
                            Console.WriteLine("5'lik sistemde notunuz 3");
                        }
                        else if (ortalamaDeger >= 70 && ortalamaDeger < 86)
                        {
                            Console.WriteLine("5'lik ssitemde notunuz 4");
                        }
                        else if (ortalamaDeger >= 86 && ortalamaDeger < 100)
                        {
                            Console.WriteLine("5'lik sistemde notunuz 5");
                        }
                    }              
                }               
                catch
                {
                Console.WriteLine("İstisnai durum oluştu!!!");
                }         
        }

    }
}
