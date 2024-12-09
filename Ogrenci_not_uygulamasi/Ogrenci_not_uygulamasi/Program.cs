using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_not_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci sınav not uygulaması

            string ad, soyad, bolum, ders;
            int s1, s2, s3, ort;

            Console.WriteLine("***** Öğrenci Bilgi Sistemi *****");

            // String değerler alındı
            ad = "Hakan";
            soyad = "Akıncı";
            bolum = "Yönetim Bilişim Sistemleri";
            ders = "C# Algoritma ve Programlama";

            // Int değerler alındı
            s1 = 65;
            s2 = 75;
            s3 = 88;
            ort = (s1 + s2 + s3) / 3;

            Console.WriteLine();
            Console.WriteLine("Öğrencinin Adı Soyadı: " + ad + " " + soyad);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Ders: "+ ders);

            Console.WriteLine();

            Console.WriteLine("Sınav 1: " + s1);
            Console.WriteLine("Sınav 2: " + s2);
            Console.WriteLine("Sınav 3: " + s3);
            Console.WriteLine("Ortalamanız: " + ort);

            Console.Read();

        }
    }
}
