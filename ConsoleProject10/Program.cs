using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Lütfen bir sayı giriniz");
            //        string girilenDeger= Console.ReadLine();
            //        if (girilenDeger == "q" || girilenDeger == "Q") //programa q veya Q yazılınca sistemden return la  moethodun dışına çıkar,
            //                                                        //geri kalan çalışmaz
            //        {
            //            return;
            //        }

            //        int a = Int32.Parse(girilenDeger);
            //        Console.Write("3000 / " + a + " = "); // tırnak içine alınan ifadeler metin olarak ekrana yansır. "=" eşittir olarak ekrana düşer
            //        Console.WriteLine(3000 / a);
            //        Console.WriteLine("işlem başarılı bir şekilde sonuçlandı"); //bir üst basamakta hata varsa zaten catch e düşecek                                                          //catch te sorgulanır,eğer hata yoksa mesajı yayınlıcak.
            //    }
            //    catch (DivideByZeroException nesne) //sıfıra bölme hatasını yakalamak için bunu ekledik (sıfıra bölme hatası)
            //    {
            //        Console.WriteLine("Sayı sıfıra bölünemez !" + nesne.Message + nesne.Source);
            //    }
            //    catch (Exception nesne) //bu blok en sonda olmalı, istisnai hatalar bloğu olarak adlandırılır.
            //    {
            //        Console.WriteLine("hata var !" + nesne.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Programdan çıkmak için q/Q harfine basınız.");
            //    }
            //} while (true);


            string girilenDeger = "";
            do
            {

                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen bir sayı giriniz");
                    girilenDeger = Console.ReadLine();

                    int a = Int32.Parse(girilenDeger);
                    Console.Write("3000 / " + a + " = "); // tırnak içine alınan ifadeler metin olarak ekrana yansır. "=" eşittir olarak ekrana düşer
                    Console.WriteLine(3000 / a);
                    Console.WriteLine("işlem başarılı bir şekilde sonuçlandı"); //bir üst basamakta hata varsa zaten catch e düşecek                                                          //catch te sorgulanır,eğer hata yoksa mesajı yayınlıcak.
                }
                catch (DivideByZeroException nesne) //sıfıra bölme hatasını yakalamak için bunu ekledik (sıfıra bölme hatası)
                {
                    Console.WriteLine("Sayı sıfıra bölünemez !" + nesne.Message + nesne.Source);
                }
                catch (Exception nesne) //bu blok en sonda olmalı, istisnai hatalar bloğu olarak adlandırılır.
                {
                    if (girilenDeger == "Q" && girilenDeger != "q")
                        Console.WriteLine("hata var !" + nesne.Message);
                }



                finally
                {
                    Console.WriteLine("Programdan çıkmak için q/Q harfine basınız.");
                }
                
            } while (girilenDeger != "Q" && girilenDeger != "q");  //mesela a yazıldı, a eşit değildir Q ve false oldu

        }

    }
    
}
