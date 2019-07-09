using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search
            int altSinir=0;
            int ustSinir=100;
            int ortalama=50;
            int sayac=1;

            Console.WriteLine("Binary Search oyunu başlıyor");
            Console.ReadLine();
            Random rnd = new Random();//rnd isimli bir random class instantı oluşturdum
            int tutulanSayi=rnd.Next(1, 100);

            while(true)
            {
                ortalama = (altSinir + ustSinir) / 2;
                Console.WriteLine(sayac + ".tahmin=" + ortalama);

                if (ortalama>tutulanSayi)
                {
                    ustSinir = ortalama;
                    Console.WriteLine("tahmin tutulan sayıdan büyüktür");
                    Console.ReadLine();
                    sayac++;
                    continue;
                }
                else if(ortalama<tutulanSayi)
                {
                    altSinir = ortalama;
                    Console.WriteLine("tahmin tutulan sayıdan küçüktür");
                    Console.ReadLine();
                    sayac++;
                    continue;
                }
                else
                {
                    Console.WriteLine(sayac + ".denemede " + tutulanSayi + "sayısını buldunuz");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
