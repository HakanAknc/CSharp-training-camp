using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** { Hesap Makinesi Programına Hoşgeldiniz! } ******");
            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.Write("Yapmak istediğiniz işlemi seçiniz (+,-,*,/,%): ");
            char islem = char.Parse(Console.ReadLine());

            double sonuc = 0;

            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz!");
                    }
                    break;
                case '%':
                    sonuc = sayi1 % sayi2;
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçtiniz :( ");
                    break;
            }

            if (islem == '+' | islem == '-' | islem == '*' | (islem == '/' & sayi2 != 0) | islem == '%')
            {
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            Console.WriteLine("Program sonlandı. Teşekkürler!");

            Console.Read();

        }
    }
}
