using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarismasi_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Turkcel Bilgi Yarişmasına Hoşgeldiniz *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;

            if (soru == 1)
            {
                Console.WriteLine("Türkiyenin başkenti neresidir? ");
                Console.WriteLine();
                Console.WriteLine("A) İstanbul");
                Console.WriteLine("B) Ankara");
                Console.WriteLine("C) İzmir");
                Console.WriteLine("D) Bursa");
                Console.WriteLine("E) Antalya");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "b" ||  cevap == "B") 
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış yarışma bitti puanınz : 0");
                }
            }

            if (soru == 2) 
            {
                Console.WriteLine();
                Console.WriteLine("Print() hangi progamlama dilinin yazdırma komutudur?");
                Console.WriteLine();
                Console.WriteLine("A) C#");
                Console.WriteLine("B) Java");
                Console.WriteLine("C) Php");
                Console.WriteLine("D) Python");
                Console.WriteLine("E) JavaScript");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap= Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru= soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış yarışma bitti puanınz : 10");
                }
            }

            if (soru == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Antalya hangi coğrafi bölgemizdedir?");
                Console.WriteLine();
                Console.WriteLine("A) Marmara");
                Console.WriteLine("B) Karadeniz");
                Console.WriteLine("C) İç Anadolu");
                Console.WriteLine("D) Ege");
                Console.WriteLine("E) Akdeniz");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap == "e" || cevap == "E")
                {
                    Console.WriteLine("Tebrikler yarışma bitti, bütün soruları doğru bildiniz :)");
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış yarışma bitti puanınz : 20");
                }
            }

            Console.Read();
        }
    }
}
