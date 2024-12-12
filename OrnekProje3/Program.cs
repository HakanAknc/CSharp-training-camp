using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öğrencinin adını girin : ");
            string name = Console.ReadLine();

            Console.Write("Öğrencinin soyadını girin: ");
            string surname= Console.ReadLine();

            Console.Write("Dersin adını girin: ");
            string ders = Console.ReadLine();

            Console.Write("Birinci notu girin: ");
            double not1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci notu girin: ");
            double not2 = double.Parse(Console.ReadLine());

            Console.Write("Üçüncü notu girin: ");
            double not3 = double.Parse(Console.ReadLine());

            double ortalama = (not1 + not2 + not3) / 3;

            if (ortalama > 50)
            {
                Console.WriteLine("Tebrikler Dostum :)");
            }
            else
            {
                Console.WriteLine("Kaldın Yavrucum...");
            }
            Console.WriteLine();
            Console.WriteLine("\n--- Sonuçlar ---");
            Console.WriteLine($"Öğrenci: {name}");
            Console.WriteLine($"Öğrenci: {surname}");
            Console.WriteLine($"Ders: {ders}");
            Console.WriteLine($"Ortalama: {ortalama:F2}");

            Console.Read();
        }
    }
}
