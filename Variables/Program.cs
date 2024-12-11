using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 254;

            int y = 321;

            int z = x + y;

            int age = 21;
            double height = 300.5;
            bool alive = false;
            char symbol = '@';
            string name = "BroCode";

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " +height + " cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);
            Console.WriteLine("Hello I am " + name);

            // Sabitler const olarak tanımlanıyor

            const double pi = 3.14159;
            Console.WriteLine(pi);


            Console.Read();
        }
    }
}
