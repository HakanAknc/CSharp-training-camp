using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nesneoler oluşturma
            Araba araba1 = new Araba();
            araba1.Renk = "Kırmızı";
            araba1.Model = "Corolla";
            araba1.Marka = "Toyota";
            araba1.YakitTürü = "Benzin";
            araba1.Hız = 180;


            Araba araba2 = new Araba();
            araba2.Renk = "Mavi";
            araba2.Model = "Focus";
            araba2.Marka = "Ford";
            araba2.YakitTürü = "Dizel";
            araba2.Hız = 200;

            // Nesnelerin Bilgileri gösteriliyor.
            araba1.BilgiGoster();
            araba2.BilgiGoster();

            // Hızlan metodu çağırılıyor.
            araba1.Hizlan(20);
            araba2.Hizlan(40);

            // FrenYap metodu çağırılıyor.
            araba1.FrenYap(50);
            araba2.FrenYap(250);

            Console.Read();
        }
    }
}
