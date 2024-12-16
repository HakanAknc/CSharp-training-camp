using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje1
{
    internal class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            _ogrenciNo = ogrenciNo;
            _isim = isim;
            _soyisim = soyisim;
            _vize1 = vize1;
            _vize2 = vize2;
            _final = final;
            _okulIsmi = okulIsmi;
        }

        public void ogrenciBilgiGoster()
        {
            Console.WriteLine("**** Öğrenci Bilgileri ****");
            Console.WriteLine("Öğrenci No: " + ogrenciNo);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("vize 1: " + vize1);
            Console.WriteLine("vize 2: " + vize2);
            Console.WriteLine("final: " + final);
        }

        public double ogrenciOrtalamsiBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Okul ismi: " + okulIsmi);
        }
    }
}
