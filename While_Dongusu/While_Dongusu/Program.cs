using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayac = 1;
            //while (sayac <= 10) 
            //{
            //    Console.WriteLine("Merhaba Dünya!");
            //    sayac++;
            //}
            //Console.Read();


            // -> Kalavyeden girielen sayının faktöriyelinin hesaplama
            /*
            int faktoriyel = 1;
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            int sayac = 1;
            while (sayac <= sayi)
            {
                faktoriyel = faktoriyel * sayac;
                sayac++;
            }
            Console.WriteLine(faktoriyel);
            Console.Read();
            */


            // -> Do While Döngüsü    === Döngüyü en az bir kere ekrana yazdrır.

            int sayi = 13;
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi < 12);
            Console.Read();
        }
    }
}
