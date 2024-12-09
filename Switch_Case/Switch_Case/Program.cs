using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte plaka;
            Console.Write("Lütfen plakayı giriniz: ");
            plaka = byte.Parse(Console.ReadLine());

            switch (plaka)
            {
                case 1:
                    Console.WriteLine("Merhaba İstanbul");
                    break;
                case 2:
                    Console.WriteLine("Merhaba Ankara");
                    break;
                case 3:
                    Console.WriteLine("Merhaba İzmir");
                    break;
                default:
                    Console.WriteLine("Henüz bu şehir bilgisi girilmedi.");
                    break;
            }
            Console.Read();
        }
    }
}
