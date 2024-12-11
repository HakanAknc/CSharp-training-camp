using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_MathClas_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetc operators

            int friends = 5;

            //friends = friends + 2;
            //friends += 3;   // friends = friens + 3;
            //friends++;      // friends + 1

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //friends = friends % 2;
            //friends %= 2;

            //Console.WriteLine(friends);

            #endregion

            #region Math Class

            double x = 3.49;
            double y = 5;

            //double a = Math.Pow(x, 3);       // üs alma işlemi yapar
            //double b = Math.Sqrt(x);         // kök alma işlemi yapar
            //double c = Math.Abs(x);          // mutlak değer hesaplama
            //double d = Math.Round(x);          // sayıya göre aşağa veya yukarıya yuvarlama yapar
            //double e = Math.Ceiling(x);      // sayıyı yukarıya yuvarlar
            //double f = Math.Floor(x);       // Sayıyı aşağa yuvarlar
            //double g = Math.Max(x, y);        // büyük değeri alır
            //double h = Math.Min(x, y);        // küçük değeri alır

            //Console.WriteLine(h);

            #endregion

            #region Random numbers

            //Random random = new Random();

            ////random.Next(1, 7);
            //int num1 = random.Next(1, 21);
            //int num2 = random.Next(1, 21);
            //int num3 = random.Next(1, 21);
            ////double num = random.NextDouble();

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.WriteLine(num3);


            #endregion

            #region hypotenuse calculator program

            Console.Write("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c); 

            #endregion


            Console.Read();
        }
    }
}
