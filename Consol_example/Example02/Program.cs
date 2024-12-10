using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoşgeldin ad soyad örneği

            string ad;
            Console.Write("Adınız : ");
            ad = Console.ReadLine();
            Console.WriteLine("Hoşgeldin {0}",ad);
            Console.Read();
        }
    }
}
