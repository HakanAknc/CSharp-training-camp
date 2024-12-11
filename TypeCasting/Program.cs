using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type casting
            // GetType() --> değişkenin türünü gösterir.
            #region  Tür Dönüşümü
            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //int c = 123;
            //double d = Convert.ToDouble(c);

            //int e = 321;
            //string f = Convert.ToString(e);

            //string g = "$";
            //char h = Convert.ToChar(g);

            //string i = "true";
            //bool j = Convert.ToBoolean(i);

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(d.GetType());
            //Console.WriteLine(f.GetType());
            //Console.WriteLine(h.GetType());
            //Console.WriteLine(j.GetType());
            #endregion

            #region User input

            Console.Write("What's your nam? ");
            string name = Console.ReadLine();

            Console.Write("What's your nam? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");
            
            #endregion


            Console.Read();
        }
    }
}
