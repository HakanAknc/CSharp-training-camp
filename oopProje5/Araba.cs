using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje5
{
    class Araba
    {
        // Özellikler (Properties)
        public string Renk;
        public string Model;
        public string Marka;
        public string YakitTürü;
        public int Hız;

        // Metotlar (Davranışlar)
        public void BilgiGoster()
        {
            Console.WriteLine($"Araba Modeli: {Model}, Renk: {Renk}, Hız: {Hız} km/h");
        }

        public void Hizlan(int artısMiktari)
        {
            Hız += artısMiktari;
            Console.WriteLine($"{Marka} {Model} hızlandı! Yeni hız: {Hız} km/h");
        }

        public void FrenYap(int azalmaMiktari)
        {
            Hız -= azalmaMiktari;
            Console.WriteLine($"{Marka} {Model} fren yaptı! Yeni hız: {Hız} km/h");
        }
    }
}
