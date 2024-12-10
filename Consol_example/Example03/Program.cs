using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kalavyeden girilen iki syaının toplamı
            int sayi1, sayi2, toplam;
            Console.Write("Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            Console.Read();
        }
    }
}
