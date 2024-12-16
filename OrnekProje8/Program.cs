using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();   // nesne (obje) oluşturuldu

            araba1.kapiSayisi = 4;
            araba1.arabaRengi = "Siyah";
            araba1.arabaModel = "TOGG";

            araba1.motorCalistir();
            araba1.kapilarKilitli();

            Console.WriteLine("Arabanın kapı sayısı : " + araba1.kapiSayisi);
            Console.WriteLine("Araba rengi : " + araba1.arabaRengi);
            Console.WriteLine("Arabanın Modeli : " + araba1.arabaModel);

            Console.Read();
        }
    }
}
