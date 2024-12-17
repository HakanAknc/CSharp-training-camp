using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje6
{
    class Kitap
    {
        //Özellikler
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public int YayınYılı { get; set; }
        public int SayfaSayisi { get; set; }
        public string ISBN { get;set; }

        public void BilgiGoster()
        {
            Console.WriteLine("------ Kitap Bilgisi -------");
            Console.WriteLine($"Kitap Adı: {KitapAdi}");
            Console.WriteLine($"Yazar: {Yazar}");
            Console.WriteLine($"Yayın Yılı: {YayınYılı}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("-----------------------------");
        }


    }
}
