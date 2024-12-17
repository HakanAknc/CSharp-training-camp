using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap();
            kitap1.KitapAdi = "Risale-i Nur";
            kitap1.Yazar = "Said Nursi";
            kitap1.YayınYılı = 1985;
            kitap1.SayfaSayisi = 430;
            kitap1.ISBN = "978-6053604787";

            // Kitap bilgililerini göster
            kitap1.BilgiGoster();

            Console.WriteLine("----------------------------");

            // Kütüphane sınıfı örneği oluştur
            Kutuphane kutuphane = new Kutuphane();

            // Kitap 1 oluştur ve ekle
            Kitap kitap2 = new Kitap
            {
                KitapAdi = "Suç ve Ceza",
                Yazar = "Fyodor Dostoyevski",
                YayınYılı = 1866,
                SayfaSayisi = 430,
                ISBN = "978-6053604787"
            };
            kutuphane.YeniKitapEkle(kitap1);

            // Kitap 2 oluştur ve ekle
            Kitap kitap3 = new Kitap
            {
                KitapAdi = "1984",
                Yazar = "George Orwell",
                YayınYılı = 1949,
                SayfaSayisi = 328,
                ISBN = "978-0451524935"
            };
            kutuphane.YeniKitapEkle(kitap3);

            // Tüm kitapları listele
            kutuphane.KitapListele();


            Console.Read();
        }
    }
}
