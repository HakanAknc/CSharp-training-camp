using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ATM
{
    internal class Program
    {
        private static string seçim;

        static void Main(string[] args)
        {
            // Kullanıcıya soracağız nasıl bir işlem istediğini
            // 1- Bakiye görüntüleme
            // 2- Pare çekme
            // 3- Para yatırma
            // 4- q'ye basınca çıkış yapsın

            int bakiye = 5000;
            string secim;

            Console.WriteLine("***** ATM'ye Hoşgeldiniz   :)");
            Console.WriteLine();
            Console.WriteLine("1- Bakiye görüntüleme");
            Console.WriteLine("2- Pare çekme");
            Console.WriteLine("3- Para yatırma");
            Console.WriteLine("q'ye basınca çıkış yapsın");
            Console.WriteLine();
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");

            secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz : " + bakiye + " TL");
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz : ");
                int cekilen_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilen_tutar<= bakiye)
                {
                    Console.WriteLine("Kalan tutar : " + (bakiye - cekilen_tutar) + " TL");
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.");
                }
                
            }
            else if(secim == "3")
            {
                Console.WriteLine("Yatırmak istediğniz tutarı giriniz : ");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni bakiyeniz : " + (bakiye + yatirilacak_tutar) + " TL");
            }
            else if (secim == "q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor...");
                Console.WriteLine("Çıkış yapıldı İyi günler   :)");
            }
            else
            {
                Console.WriteLine("Bir hata oldu. Lütfrn tekrar deneyin...");
            }

            Console.Read();
        }
    }
}
