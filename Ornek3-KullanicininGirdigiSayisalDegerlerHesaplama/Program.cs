using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_KullanicininGirdigiSayisalDegerlerHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet, fiyat;
            Console.Write("Almak istedeiğiniz ürün adedini giriniz: ");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Birim fiyatını giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam Ödemeniz: " + adet * fiyat + " TL'dir");
            Console.Read();
        }
    }
}
