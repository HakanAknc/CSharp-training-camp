﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oğrenci_Sinav_Not_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, ort;
            Console.Write("Sınav 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sınav 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            ort = (s1 + s2) / 2;
            Console.WriteLine("Ortalamanız: " + ort);


            if (ort >= 50)
            {
                Console.WriteLine("Geçtiniz :)");
            }
            else
            {
                Console.WriteLine("Kaldınız :(");
            }
            Console.Read();
        }
    }
}
