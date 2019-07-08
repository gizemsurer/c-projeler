using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject07
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("İki Sayı Giriniz: ");
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                int toplam = Int32.Parse(a) + Int32.Parse(b);
                Console.WriteLine(toplam);
            }
            catch (FormatException nesne)
            {
                Console.WriteLine("Şu hata meydana geldi: " + nesne.Message);
            }
            catch (OverflowException nesne)
            {
                Console.WriteLine("Şu hata meydana geldi: " + nesne.Message);
            }
            catch
            {
                Console.WriteLine("Şu hata meydana geldi: ");

            }

            finally
            {

                Console.ReadLine();

            }
        }
    }
}


