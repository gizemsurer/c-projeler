using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir alt satırdaki a değişkeni tanımlanırsa
            //Birinci ve ikinci scope taki a değişkenleri yeniden tanımlanamaz.
            //Ancak kullanılabilir.Yani Main bloğunda tanımlanan a değişkeninin 
            //faaliyet alanı açılan diğer bloklarda devam etmektedir.
            //Üst seviyede açılan bloklar alt seviyedeki blokları kapsar.
            // int a = 65; 
            {
                //Birinci scope
                int a = 19;
                Console.WriteLine("a nın degeri = " + a);
                Console.ReadLine();

            }
            // aşağıdaki kod compile hatası verir çünkü a değişkeni bu scope'ta tanımlı değil.//
            // ConsoleWriteLine(a);

            {
                //İkinci scope
                int a = 22;
                Console.WriteLine("a nın degeri = " + a);
                Console.ReadLine();


            }
        }
    }
}
