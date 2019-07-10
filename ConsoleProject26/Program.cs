using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject26
{
    class Program
    {
        static void Main(string[] args)
        {//eleman sayısını kendimiz girdiğimiz fibonacci dizisi oluşturma programı
            int x = 0;
            int y = 1;
            int sayi;
            int z;
            Console.WriteLine("kaç adet fibonacci dizisi toplanacak");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write(x + " " + y+ " ");
           
            for(int i =3;i<=sayi; i++)
            {
                
               
                z = x + y;
                Console.Write( z+" ");
                x = y; 
                y = z;
            }
            
            Console.ReadLine();

        }
    }
}
