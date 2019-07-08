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

                double not1;
                double not2;
                double ort;
                Console.WriteLine("çıkmak için  q ya basınız yada entere basınız ");

                string q = Console.ReadLine();
                if (q == "q" || q == "Q")
                {
                    return;
                }


                Console.WriteLine("birinci notu giriniz");
                not1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ikinci notu giriniz");
                not2 = Convert.ToDouble(Console.ReadLine());
                ort = (not1 + not2) / 2;
                Console.WriteLine("ortalamanız" + ort);
                if (ort >= 50)
                {
                    Console.WriteLine("sınıfı geçtiniz");
                    Console.ReadLine();
                }
                if (ort > 50)
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
