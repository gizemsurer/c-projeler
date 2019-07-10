using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectt27
{
    class Program
    {
        static void Main(string[] args)
        {
            int faktoriyel = 1;
            string faktoriyelSonucu = " ";
            int kacaKadar;

            Console.WriteLine("Hangi sayının faktöriyelini hesaplamak istiyorsun?");
            kacaKadar = int.Parse(Console.ReadLine());

            for (int i = 1; i <= kacaKadar; i++)
            {
                faktoriyel = faktoriyel * i;
                if (i < kacaKadar)
                {
                    faktoriyelSonucu = faktoriyelSonucu + i + "x";
                }
                else if (i == kacaKadar)
                {
                    faktoriyelSonucu = faktoriyelSonucu + i;
                }
                if (i < kacaKadar)
                {
                    string tmp = faktoriyelSonucu;
                    if (faktoriyelSonucu.Length > 0)
                        faktoriyelSonucu = faktoriyelSonucu.Substring(0, faktoriyelSonucu.Length - 1);

                    Console.WriteLine(faktoriyelSonucu + " = " + faktoriyel);
                    faktoriyelSonucu = tmp;
                }
                else
                    Console.WriteLine(faktoriyelSonucu + " = " + faktoriyel);

                Console.ReadLine();


            }
        }
    }
}


