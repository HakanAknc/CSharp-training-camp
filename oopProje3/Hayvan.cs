using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje3
{
    internal class Hayvan
    {
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan bir ses çıkarıyor.");
        }
    }

    class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Köpek havlıyor.");
        }
    }

    class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Kedi miyavlıyor...");
        }
    }
}
