using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje6
{
    class Kutuphane
    {
        // kitap listesi
        private List<Kitap> kitapListesi = new List<Kitap>();

        // Yeni kitap ekle metodu
        public void YeniKitapEkle(Kitap yeniKitap)
        {
            kitapListesi.Add(yeniKitap);
            Console.WriteLine($"Kitap eklendi: {yeniKitap.KitapAdi}");
        }

        // Tüm kitaparı listeleme metodu
        public void KitapListele()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in kitapListesi)
            {
                kitap.BilgiGoster();
            }
        }
    }
}
