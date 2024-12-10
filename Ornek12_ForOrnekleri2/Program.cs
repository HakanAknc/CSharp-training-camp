using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12_ForOrnekleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖRNEK: ( Random ile sayıların toplamını bulma )
            //Random sayi;
            //sayi = new Random();
            //int toplam = 0;
            //int bts = sayi.Next(0,100);
            //for (int a = 1; a <= 10; a++)
            //{
            //    bts = sayi.Next(0, 100);
            //    Console.WriteLine(bts);
            //    toplam = toplam + bts;
            //}
            //Console.WriteLine("Toplam : " + toplam);


            // ÖRNEK: ( Sayı tahmini yapma )
            //Random sayiUret;
            //sayiUret = new Random();
            //int bts = sayiUret.Next(1, 100);
            //Console.Write("Tahmininizi giriniz:");
            //int tahmin = Convert.ToInt32(Console.ReadLine());
            //if (tahmin == bts)
            //{
            //    Console.WriteLine("DOĞRU TAHMİN");
            //}
            //else
            //{
            //    Console.WriteLine("MAALESEF OLMADI");
            //}


            // ÖRNEK: ( Kullanıcının yaşını ve gününü bulma )
            DateTime zaman;
            zaman = new DateTime();
            zaman = DateTime.Now;
            Console.WriteLine("Bu günün tarihi:" + zaman.ToString());
            Console.Write("Doğum tarihinizi giriniz:");
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(Console.ReadLine());
            TimeSpan gün = zaman - dogumtarihi;
            double toplamgün = gün.Days;
            Console.WriteLine(toplamgün + " Günlüksünüz");
            int yas = zaman.Year - dogumtarihi.Year;
            Console.WriteLine(yas + " yaşındasınız");



            Console.Read();
        }
    }
}
