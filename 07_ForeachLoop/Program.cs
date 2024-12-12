using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Foreach Döngüsü

            // Foreach Döngüsü

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "rome", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)   // x cities'in içine gidip bütün değerleri üzerine alıcak
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 23, 56, 39, 79, 65, 41, 32, 852, 369 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 23, 56, 39, 79, 65, 41, 32, 852, 369 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 45, 78, 23, 56, 39, 79, 65, 41, 32, 852, 369 };

            //int total = 0;

            //foreach (int number in numbers) 
            //{ 
            //    total += number;
            //}
            //Console.WriteLine(total);


            #endregion

            #region Listeler

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,7,8,9,10
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("**********************");

            //List<string> values = new List<string>()
            //{
            //    "hakan","ahmet","yusuf","salih"
            //};
            //foreach (string number in values)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char name in word)
            //{
            //    Console.WriteLine(name);
            //}


            #endregion

            #region Örnek sınav sistemi

            Console.Write("***** C# EĞİTİM KAMPI SINAV UYGULAMASI *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");

            // Öğrenci isimlerini ve not ortalamarını saklaycak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExampleResult = 0;
                
                // Her öğrenci içim
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());

                    if (value < 100 & value > 0) 
                    {
                        totalExampleResult += value;  // notları topluyoruyz
                    }
                    else
                    {
                        Console.WriteLine("Çok uçtun. Bu öğrenci elendi");
                        break;
                    }
                    
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExampleResult / 3;
            }
            
            // Sınav oralamaları
            for (int i = 0;i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencinin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti :)");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı :(");
                }

                Console.WriteLine("---------------------------------------------");
            }



            #endregion

            Console.Read();
        }
    }
}
