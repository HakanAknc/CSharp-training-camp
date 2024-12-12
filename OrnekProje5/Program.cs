using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("&*&*&*&*&* Kütüphane Kitap Takip Sistemine Hoş Geldiniz! *&*&*&*&*&*");

            List<string> kitaplar = new List<string>();

            while (true)
            {
                // menü
                Console.WriteLine("\n--- Menü ---");
                Console.WriteLine("1. Kitap Ekle");
                Console.WriteLine("2. Kitapları Listele");
                Console.WriteLine("3. Kitap Sil");
                Console.WriteLine("4. Çıkış");

                Console.Write("Bir işlem seçiniz (1-4) : ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Write("Kitap adı girin : ");
                    string kitapAdi = Console.ReadLine();

                    Console.Write("Yazar adı girin : ");
                    string yazarAdi = Console.ReadLine();

                    kitaplar.Add($"{kitapAdi} - {yazarAdi}");   // listeye ekleme yapıldı
                    Console.WriteLine("Kitap başarıyla eklendi.");
                }
                else if (secim == "2")
                {
                    Console.WriteLine("\n--- Kütüphanedeki Kitaplar ---");

                    if (kitaplar.Count == 0)
                    {
                        Console.WriteLine("Henüz kütüphanede kitap yok:");
                    }
                    else
                    {
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {kitaplar[i]}");
                        }
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("\n--- Kitap Silme ---");

                    if(kitaplar.Count == 0)
                    {
                        Console.WriteLine("Silinecek kitap yok.");
                    }
                    else
                    {
                        Console.WriteLine("Silmek istediğiniz kitabın numarasını giriniz : ");
                        int kitapNo;
                        if (int.TryParse(Console.ReadLine(), out kitapNo) && kitapNo > 0 && kitapNo <= kitaplar.Count)
                        {
                            kitaplar.RemoveAt(kitapNo - 1);
                            Console.WriteLine("Kitap başarıyla silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir numara girdiniz?");
                        }
                    }
                }
                else if(secim == "4")
                {
                    Console.WriteLine("Programdan çıkılıyor. Teşekkürler");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                }
            }
            Console.Read();
        }
    }
}
