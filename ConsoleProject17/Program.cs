using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjec16
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 4;

            while (i > 0)
            {

                double vize1;
                double final;
                double ort;
                Console.WriteLine("çıkmak için  q ya basınız yada entere basınız ");

                string q = Console.ReadLine();
                if (q == "q" || q == "Q")
                {
                    return;
                }


                Console.WriteLine("birinci notu giriniz");
                vize1 = Convert.ToDouble(Console.ReadLine());
                if (vize1>100)
                {
                    Console.WriteLine("hatalı bir işlem yaptınız");
                    continue;
                }
                Console.WriteLine("ikinci notu giriniz");
                final = Convert.ToDouble(Console.ReadLine());
                if(final>100)
                    {
                    Console.WriteLine("hatalı bir işlem yaptınız");
                    continue;
                }

                ort = (40*vize1 + 60*final) / 100;
                Console.WriteLine("ortalamanız" + ort);
                if (ort >= 50)
                {
                    Console.WriteLine("sınıfı geçtiniz");
                    Console.ReadLine();
                }
               else
                {
                    Console.WriteLine("sınıfta kaldınız");
                    Console.ReadLine();
                }




            }
            i = i - 1;

            Console.ReadLine();
        }

    }
}
