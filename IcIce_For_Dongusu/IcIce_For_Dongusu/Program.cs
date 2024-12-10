using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcIce_For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i<= 10; i++)
            //{
            //    for (int j = 1; j<= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();



            //for (int x = 0; x < 10; x++)
            //{
            //    for (int i = 0; i <= x; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();  // bir alt satıra geçer
            //}
            //Console.Read();




            // Çarpım tablosu

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                }
                Console.WriteLine();
            }
            Console.Read();



        }
    }
}
