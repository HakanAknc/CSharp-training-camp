using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11_ForOrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖRNEK: ( Sayıları ritmik arttırma )

            //for (int adim = 2; adim<=100; adim=adim+2)
            //{
            //    Console.WriteLine(adim);
            //}


            // ÖRNEK: (Girilen sayılardan en büyük/küçük olanını bulma)
            //int buyuk = 0, kucuk = 0, sayi = 0;
            //for (int i = 1; i<= 5; i++)
            //{
            //    Console.Write((i) + ".sayıyı giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (i == 1)
            //    {
            //        buyuk = sayi;
            //        kucuk = sayi;
            //    }
            //    if (kucuk>sayi)
            //    {
            //        kucuk = sayi;
            //    }
            //    if (buyuk < sayi)
            //    {
            //        buyuk = sayi;
            //    }
            //}
            //Console.WriteLine("En büyük sayi: " + buyuk);
            //Console.WriteLine("Enküçük sayi: " + kucuk);


            // ÖRNEK: ( Sayının katını bulma )
            //int sayi;
            //Console.Write("Sayı giriniz: ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 7 == 0)
            //{
            //    Console.WriteLine("Sayı yedinin katıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yedinin katı değildir.");
            //}


            //ÖRNEK: ( Sayıların ortalamasını bulma )
            //int s = 0;
            //for (int i = 1; i<=5; i++)
            //{
            //    Console.Write(i + ". sayıyı giriniz: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    s += sayi;  // s = s + sayi  s = 11 + 12 = 23
            //}
            //Console.WriteLine("Toplam : " + s);
            //Console.WriteLine("Ortalama : " + s / 5);


            //ÖRNEK: ( Ekrana otomatik ilerleyen yazı yazdırma )
            for (int a = 0; a < 100; a++)
            {
                Console.SetCursorPosition(a, 15);
                Console.Write(" Risale-i Nur  ==  Bediüzzaman Said Nursi (ra) ");
                System.Threading.Thread.Sleep(100);
            }



            Console.Read();
        }
    }
}
