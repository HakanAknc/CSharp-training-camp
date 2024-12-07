using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazırma Komutları 

            //Console.WriteLine("Hakan AKINCI");  // imleci bir alt satıra atar
            //Console.Write("Merhaba Dünya!");  // yanına yazdırır.

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion


            #region String Değişkenler

            // String
            //Değişken_türü değişken_adi;

            //string name;
            //name = "Hakan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ahmethan";
            //customerSurname = "Gezer";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "ahmet@gmail.com";
            //district = "Meram";
            //city = "Konya";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------Kart-1");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" +  city);
            //Console.WriteLine("-------------------------------------------");

            //Console.WriteLine();

            //customerName = "Hakan";
            //customerSurname = "Akıncı";
            //customerPhone = "+90 500 400 70 80";
            //customerEmail = "hakan@gmail.com";
            //district = "Antalya";
            //city = "Kumluca";
            //Console.WriteLine("-------------------------------------Kart-2");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------");
            #endregion

            #region Int Değişknler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****** && Restoran Menü Fiyatı && ******");
            Console.WriteLine();
            Console.WriteLine("----->     Hamburger: " + hamburgerPrice + " TL" + "  -----");
            Console.WriteLine("----->     Pizza: " + pizzaPrice + " TL" + "      -----");
            Console.WriteLine("----->     Kola: " + cokePrice + " TL" + "        -----");
            Console.WriteLine("----->     Limonata: " + lemonadePrice + " TL" + "    -----");
            Console.WriteLine("----->     Kızartma: " + friesPrice + " TL" + "    -----");
            Console.WriteLine("----->     Su: " + waterPrice + " TL" + "          -----");
            Console.WriteLine();
            Console.WriteLine("****** && Restoran Menü Fiyatı && ******");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalCokePrice;
            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice);


            #endregion

            Console.Read();
        }
    }
}
