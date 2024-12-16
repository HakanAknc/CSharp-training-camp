using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1, "Hakan", "Akıncı", 50, 40, 73, "Necmettin Erbakan Üni.");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz... Yapamk istediğiniz işlemi seçiniz: ");

            while(kontrol)
            {
                islemleriGoster();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgiGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.ogrenciOrtalamsiBul();
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;
                }
            }
            
        }
        static void islemleriGoster()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğreni Ortalamasını Göster");
            Console.WriteLine("3- Öğrenci Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");
        }

    }
}
