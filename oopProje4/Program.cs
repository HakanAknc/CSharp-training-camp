using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Televizyon televizyon = new Televizyon();
            Klima klima = new Klima();

            Console.WriteLine("Televiyzon Bilgileri");
            televizyon.Ac();
            televizyon.Kapat();
            televizyon.SesArtir();
            televizyon.SesAzalt();

            Console.WriteLine("***********************");

            Console.WriteLine("Klima Bilgileri");
            klima.Ac();
            klima.Kapat();
            klima.SesArtir();
            klima.SesAzalt();


            Console.Read();
        }
    }
}
