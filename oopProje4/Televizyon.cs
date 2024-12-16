using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje4
{
    public class Televizyon : IKumanda
    {
        public void Ac()
        {
            Console.WriteLine("Televiyon Açıldı");
        }

        public void Kapat()
        {
            Console.WriteLine("Televiyon Kapandı");
        }

        public void SesArtir()
        {
            Console.WriteLine("Televiyon Ses Artırıldı");
        }

        public void SesAzalt()
        {
            Console.WriteLine("Televiyon Ses Azaltıldı");
        }
    }
}
