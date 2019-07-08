using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject18
{
    class Program
    {
        static void Main(string[] args)

        {
            //kullanıcının girdiği satır ve sütun sayısı kadar yıldız koyan programı yazma
            Console.WriteLine("satır sayısı giriniz");
        
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sütun sayısı giriniz");

            int sutun = Convert.ToInt32(Console.ReadLine());

            for (int i=1;i<=satir; i++)
            {
                for(int j=1;j<=sutun;j++)
                {
                    Console.Write("x");
                    
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();

        }
        
    }
}
