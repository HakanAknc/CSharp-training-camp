using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Tahmin Oyununa Hoş Geldin Dostum **** ");
            Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım tahmin edebilecek misin :) ");

            Random random = new Random();
            int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında sayı üret
            int tahmin;
            int denemeSayisi = 0;

            while (true)
            {
                Console.Write("Tahmininiz : ");
                tahmin = int.Parse(Console.ReadLine());
                denemeSayisi++;

                // Tahmin kontrolü
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine($"Tebrikler! {denemeSayisi} denemede doğru tahmini yaptınız. Sayı: {rastgeleSayi}");
                    break;
                }
                else if (tahmin < denemeSayisi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin!");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin!");
                }
            }
            Console.WriteLine("Oyun bitti, teşekkürler!");


            Console.Read();
        }
    }
}
