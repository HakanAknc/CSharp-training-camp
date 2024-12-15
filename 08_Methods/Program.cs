using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // Bir yapının metot olduğunu anlamak için sonuna mutlaka "()" konması gerekiyor.
            // C# da metotlar "mor renkte bir küp" işareti alırlar. 
            // Geriye değer döndürmeyen metotlar
            // Customer --> Listele, ekle, sil, güncelle
            // Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Hakan Akıncı");
            //    Console.WriteLine("Yusuf Erdem");
            //    Console.WriteLine("Adnan Gündüz");
            //    Console.WriteLine("Ahmethan Gezer");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum(); 

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);

            //}

            //WriteMethod("Hakan AKINCI"); 

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Hakan", "Akıncı");
            //CustomerCard("Caner", "Akıncı");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar


            //void Sum(int number1, int number2, int number3)
            //{
            //    int toplam = number1 + number2 + number3;
            //    Console.WriteLine("Toplam : " + toplam);
            //}
            //Sum(2, 6, 9);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomrtName()
            //{
            //    return "Hakan AKINCI";
            //}
            //CustomrtName();

            //String StudentCard()
            //{
            //    string name = "Hakan";
            //    string surname = "Akıncı";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rnegini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50) 
            //    {
            //        return student + " isimli öğrenci sınavı geçti " + "Ortalam: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Hakan", 25, 41, 96));
            //Console.WriteLine(ExamResult("Yusuf", 25, 52, 45));




            #endregion

            #region Örnek Uygulama

            //void tanitim()
            //{
            //    Console.WriteLine("Hakan Akıncı");
            //    Console.WriteLine("Necmettin Erbakan Üniversitesi");
            //    Console.WriteLine("Yazılım Mühendisi");
            //    Console.WriteLine("Backend Developer");
            //    Console.WriteLine("Antalya");
            //}
            ////tanitim();

            //void tanitim2(string isim, string soyisim, string okul, string alan, string bolüm, int yas)
            //{
            //    Console.WriteLine("*** Tanıtım Kartı ***");
            //    Console.WriteLine($"İsim Soyisim: {isim} {soyisim} - Okul: {okul} - Alan: {alan} - Bölüm: {bolüm} - Yaş: {yas}");
            //}
            ////tanitim2("Hakan", "Akıncı", "Necmettin Erbakan Üniversitesi", "Yazılım Mühendisi", "Backend Developer", 23);

            //void hesapMakinesi (double x, double y)
            //{
            //    Console.WriteLine("*****  Hesap Makinesine HOŞGELDİNZİ  *****");
            //    double toplam = x + y;
            //    double carp = x * y;
            //    double çıkar = x - y;
            //    double bol = x / y;
            //    Console.WriteLine($"Toplam: {toplam} Çarpım: {carp} Çıkrma: {çıkar} Bölme: {bol}");

            //}
            ////hesapMakinesi(45, 10);

            //int toplamYap(int sayi1, int sayi2)
            //{
            //    int sonuc = sayi1 + sayi2;
            //    //Console.WriteLine(sonuc);
            //    return sonuc;
            //}
            //Console.WriteLine("Sonuc : " + toplamYap(6, 7));


            #endregion


            //void ToplaVeYaz(int a, int b)
            //{
            //    Console.WriteLine($"Sonuç : {a + b}");
            //}

            //ToplaVeYaz(3, 5);

            //int sonuc = ToplaVeYaz(3, 5); // HATA! Çünkü void metot geriye değer döndürmez.

            //int Topla(int a, int b)
            //{
            //    return a + b; // Sonucu geri döndür.
            //}

            //int sonuc = Topla(3, 5);
            //int yeniSonuc = sonuc * 2; // 8 * 2 = 16
            //Console.WriteLine(yeniSonuc); // Çıktı: 1


            void ToplamNotuYaz(int not1, int not2)
            {
                int toplam = not1 + not2;
                Console.WriteLine($"Toplam Not: {toplam}");
            }
            ToplamNotuYaz(80, 90); // Çıktı: Toplam Not: 170



            Console.Read();


        }
    }
}
