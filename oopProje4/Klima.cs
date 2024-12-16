using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje4
{
    public class Klima : IKumanda
    {
        public void Ac()
        {
            Console.WriteLine("Klima Açıldı");
        }

        public void Kapat()
        {
            Console.WriteLine("Klima Kapandı");
        }

        public void SesArtir()
        {
            Console.WriteLine("Klima Sesi artırılmaz. (Geçersiz işlem)");
        }

        public void SesAzalt()
        {
            Console.WriteLine("Klima Sesi azaltılmaz. (Geçersiz işlem)");
        }
    }
}
