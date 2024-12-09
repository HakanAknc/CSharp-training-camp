using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8_PozitifNegatifKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Ne pozitif ne negatif.");
            }
            else
            {
                Console.WriteLine("Sayı negatiftir.");
            }

            Console.Read();
        }
    }
}
