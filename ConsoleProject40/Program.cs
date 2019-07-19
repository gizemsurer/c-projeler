using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject40
{
    class Program
    {//Fibonacci numbers oluşturma projemizi FibonacciNumbers classı oluşturarark çözelim
     //yani Fibonacci Numbers classı ekranda girilen sayıya kadar olan FibonacciNumber'ları
     //bizim içinde foreach ile gezebileceğimiz bir collection'a(koleksiyona)çevirsin

        static void Main(string[] args)
        {
            Console.WriteLine("lütfen ulaşmak istediğiniz fibonacci sayısıı giriniz");
            int hedefFibonacciSayisi = Convert.ToInt32(Console.ReadLine());

            FibonacciNumbers f = new FibonacciNumbers(hedefFibonacciSayisi);
            foreach (int n in f)
            {
                Console.Write(n);
            }
            Console.ReadKey();
            
            
        }
    }
}
class FibonacciNumbers : IEnumerable
{
    private FibonacciEnumaretor iter;
    public FibonacciNumbers(int max)
    {
        iter = new FibonacciEnumaretor(max);
    }
    public IEnumerator GetEnumerator()
    {
        return iter;
    }

}
class FibonacciEnumaretor:IEnumerator
{
    private int currentNumber, nextNumber, maxNumber;
    public FibonacciEnumaretor(int max)
    {
        maxNumber = max;
        Reset();
    }
    public object Current
    {
        get
        {
            return currentNumber;
        }
    }
    public bool MoveNext()
    {
        int newNextNumber = currentNumber + nextNumber;
        currentNumber = nextNumber;
        nextNumber = newNextNumber;
        return currentNumber <= maxNumber;
    }
    public void Reset()
    {
        currentNumber = 0;
        nextNumber = 1;
    }
}
