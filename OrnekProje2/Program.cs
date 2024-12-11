using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basit Not Sistemi Programı Hoş Geldiniz!");

            Console.Write("Öğrencinin adını girin: ");
            string ogrenciAdi = Console.ReadLine();

            Console.Write("Dersin adını girin: ");
            string dersAdi = Console.ReadLine();

            Console.Write("Birinci notu girin: ");
            double not1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci notu girin: ");
            double not2 = double.Parse(Console.ReadLine());

            Console.Write("Üçünce notu girin: ");
            double not3 = double.Parse(Console.ReadLine());

            double ortalama = (not1 +  not2 + not3) / 3;

            string durum = ortalama >= 50 ? "Geçti" : "Kaldı";

            Console.WriteLine("\n--- *** Sonuçlar *** ---");
            Console.WriteLine($"Öğrenci : {ogrenciAdi}");
            Console.WriteLine($"Ders : {dersAdi}");
            Console.WriteLine($"Ortalama : {ortalama}");
            Console.WriteLine($"Durum : {durum}");

            Console.WriteLine("\nProgram sonlandı. Teşekkürler!");

            Console.Read();
        }
    }
}
