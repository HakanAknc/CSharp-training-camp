using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje8
{
    internal class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;


        // CTOR kısa yol CONSTROCTOR 
        public Araba()
        {
            Console.WriteLine("Araba sınıfının yapıcı metodu çalıştı...");
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor çalışıyor...");
        }

        public void kapilarKilitli()
        {
            Console.WriteLine("Kapılar kilitleniyor...");
        }
    }
}
