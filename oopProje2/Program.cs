using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();

            personel1.TCNO = "12345678956";

            Console.WriteLine(personel1.TCNO);

            Console.Read();
        }
    }
}
