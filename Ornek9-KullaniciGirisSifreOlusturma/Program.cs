using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9_KullaniciGirisSifreOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAd;
            int sifre, tel;

            Console.Write("Kullanıcı adınızı giriniz: ");
            kullaniciAd = Console.ReadLine();

            Console.Write("Şifrenizi giriniz: ");
            sifre = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telefon numaranızı giriniz: ");
            tel = Convert.ToInt32(Console.ReadLine());

            if (kullaniciAd == "admin" && sifre == 1234 | tel == 123456789)
            {
                Console.WriteLine("Giriş başarılı :) ");
            }
            else
            {
                Console.WriteLine("Kullanıcı adını veya şifreyi kontrol ediniz");
            }
            Console.Read();
        }
    }
}
