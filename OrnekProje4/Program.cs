using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dikdörtgen Alan ve Çevre Hesaplama Programına Hoş Geldiniz!");

            Console.Write("Diktörtgenin kısa kenarını girin : ");
            int kısaKenar = int.Parse(Console.ReadLine());

            Console.Write("Diktörtgenin uzun kenarını girin : ");
            int uzunKenar = int.Parse(Console.ReadLine());

            int alan, cevre;

            alan =  kısaKenar * uzunKenar;
            cevre = 2 * (kısaKenar + uzunKenar);

            Console.WriteLine("***** SONUÇLAR *****");
            Console.WriteLine("Alan : " + alan);
            Console.WriteLine("Çevre : " + cevre);
            Console.WriteLine($"Alan : {alan} , Çevre : {cevre}");

            Console.Read();
        }
    }
}
