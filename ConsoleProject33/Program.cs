using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = new string[7]
            {"pazartesi","salı","çarşamba","perşembe","cuma","cumartesi" ,"pazar"};
            gunler[0] = "pazartesi";
            gunler[0] = "salı";
            gunler[0] = "çarşamba";
            gunler[0] = "perşembe";
            gunler[0] = "cuma";
            gunler[0] = "cumartesi";
            gunler[0] = "pazar";

           
            Console.WriteLine("clear methodu öncesi-FOR lu");
            for (int i=0;i<=6;i++)

            {
                Console.WriteLine("array'in " + (i + 1) +".elemanı = " + gunler[i]);
                
            }
            Console.ReadLine();

            Console.WriteLine("clear methodu öncesi-FOREACH li");
            int j = 0;
            foreach (string gun in gunler)
            {
                Console.WriteLine("array'in {1}. elemanı={0} "  , gun,j++);
            }

            

            Array.Clear(gunler, 0, 3);
            Console.WriteLine("clear metodu sonrası");
            {
                for (int i = 0; i <= 6; i++)

                {
                    Console.WriteLine("array'in " + (i + 1) + ".elemanı = " + gunler[i]);
                }
                Console.ReadLine();
            }
        }
              
    }
}
