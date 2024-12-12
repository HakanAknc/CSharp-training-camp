using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String Methods
            //string fullName = "Bro Code";
            //string phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();  // Büyük harf
            //fullName = fullName.ToLower();  // Küçük harf

            //phoneNumber = phoneNumber.Replace("-","");  // Krekter değiştirme

            //string username = fullName.Insert(0,"Mr.");    // istediğin indekse veri ekleme
            //Console.WriteLine(username);

            //Console.WriteLine(fullName.Length);    // toplam string sayısı

            //string firsName = fullName.Substring(0, 3);
            //string lastName = fullName.Substring(4, 4);

            //Console.WriteLine(firsName);
            //Console.WriteLine(lastName);
            #endregion

            #region if statements

            //Console.Write("Yaşınızı giriniz: ");
            //int age = int.Parse(Console.ReadLine());
            ////int age = Convert.ToInt32(Console.ReadLine());

            //if (age > 18)
            //{
            //    Console.WriteLine("Yaşınız reşit.");
            //}
            //else if (age < 0)
            //{
            //    Console.WriteLine("Yaş sıfırdan küçük olamaz.");
            //}
            //else
            //{
            //    Console.WriteLine("Yaşınız reşit değil");
            //}



            #endregion

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Hakan");

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Hakan C# öğren");
            //    i++;
            //}


            //for (int i = 1; i <= 5;  i++)
            //{
            //    for (int j = 1;  j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int i = 0;
            //int sum = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    sum += i;  
            //}
            //Console.WriteLine(sum);

            //Console.Write("How many rows? : ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("How many colums? : ");
            //int colums = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What symbol? : ");
            //string symbol = Console.ReadLine();

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < colums; j++)
            //    {
            //        Console.Write(symbol);
            //    }
            //    Console.WriteLine();
            //}

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            

            Console.Read();
        }
    }
}
