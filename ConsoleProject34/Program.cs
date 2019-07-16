using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int [5];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;
            a1[3] = 40;
            a1[4] = 50;

            int[]a2 = new int[4];
            a2[0] = 12;
            a2[1] = 22;
            a2[2] = 32;
            a2[3] = 42;

            a1 = a2;
           // a2 = a1;

            Console.WriteLine("a1 int arrayinin elemanları:");
            foreach(var item in a1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine("a2 int arrayinin elemanları:");
            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        
    }
}
