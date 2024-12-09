using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6_SayininTekmiCiftmiDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çift.");
            }
            else
            {
                Console.WriteLine("Sayı tek.");
            }

            Console.Read();
        }
    }
}
