using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek7_AdDegerininUzunlugunuBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ad;
            //Console.Write("Adınızı giriniz: ");
            //ad = Console.ReadLine();
            //if (ad.Length > 10 )
            //{
            //    Console.WriteLine("Uzun bir isme sahipsiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("İsminiz 10 karekterden az.");
            //}
            //Console.Read();

            // ÖRNEK 7: ( Çemberin çevresi/alanını bulma )
            int r, cevre, alan;
            Console.Write("Çemberin yarıçapını giriniz: ");
            r = Convert.ToInt32(Console.ReadLine());
            cevre = r * 2 * 3;
            alan = 3 * r * r;
            Console.WriteLine("Çemberin çevresi: " + cevre);
            Console.WriteLine("Çemberin alanı: " + alan);
            Console.Read();
        }
    }
}
