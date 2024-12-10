using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Dönguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //    //Console.WriteLine(sum);
            //    //Console.WriteLine(i);
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(i);

            // Girilen üç sayının toplamı
            //int a, b, c;

            //Console.Write("a sayısını giriniz: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("b sayısını giriniz: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("c sayısını giriniz: ");
            //c = Convert.ToInt32(Console.ReadLine());

            //int toplam = a + b + c;
            //Console.WriteLine("Toplam : " + toplam);



            // Örnek soru;
            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Üç basamaklı bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            sum = ones + tens + hundreds;
            Console.WriteLine(sum);

            



            Console.Read();

            #endregion
        }
    }
}
