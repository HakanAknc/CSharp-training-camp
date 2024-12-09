using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek10_Girilen2SayidanBuyukOlaniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Örnek 10 : Girilen 2 sayıdan büyük olanını bulan Console örneği:
            int sayi1, sayi2;
            Console.Write("1. Sayı : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine("1. Sayı Büyük");
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("İki Sayı Eşit");
            }
            else
            {
                Console.WriteLine("2. Sayı Büyük");
            }
            Console.ReadKey();




            // Örnek 11: Girilen sayının 4 ve 7 ye tam bölünüp bölünmediğini bulan Console örneği.
            int sayi;
            Console.Write("Sayıyı Girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 4 == 0 && sayi % 7 == 0)
            {
                Console.WriteLine("Sayı 4 ve 7 ye tam bölünüyor");
            }
            else
            {
                Console.WriteLine("Sayı 4 ve 7 ye tam bölünmüyor");
            }
            Console.ReadKey();




            // Örnek 12: Girilen sayının 0-100 arasında olup olmadığını kontrol eden Console örneği.
            int rakam;
            Console.Write("Sayıyı Girin : ");
            rakam = Convert.ToInt32(Console.ReadLine());
            if (rakam >= 0 && rakam <= 100)
            {
                Console.WriteLine("Girilen sayı 0-100 aralığında");
            }
            else
            {
                Console.WriteLine("Girilen sayı 0-100 aralığında değil");
            }
            Console.ReadKey();
        }
    }
}
