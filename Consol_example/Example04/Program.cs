using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bas = 0, son = 0;
            Console.Write("1. sayıyı giriniz:");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz:");
            son = Convert.ToInt32(Console.ReadLine());

            if (bas > son)
            {
                int depo = bas;
                bas = son;
                son = depo;
            }

            int ciftToplam = 0, adet = 0;
            Console.Write("Çift sayılar:");
            for (int i = bas; i <= son; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "-");
                    ciftToplam += i;
                    adet++;
                }

            }
            Console.WriteLine("\nÇift Sayıların Ortalaması={0}", ciftToplam / adet);
            Console.ReadKey();
        }
    }
}
