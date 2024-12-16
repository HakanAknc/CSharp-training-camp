using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hayvan hayvan = new Hayvan();
            Hayvan kopek = new Kopek();
            Hayvan kedi = new Kedi();

            hayvan.SesCikar();
            kopek.SesCikar();
            kedi.SesCikar();

            Console.Read();


            /*
             Ne Oluyor?
            SesCikar isimli metot, Hayvan sınıfında tanımlanıyor.
            Ama Kopek ve Kedi sınıfları, SesCikar metodunu kendine göre geçersiz kılıyor (override ediyor).
            Çalışma zamanı geldiğinde, hangi sınıfın metodu çağrılıyorsa o çalıştırılıyor.
             */
        }
    }
}
