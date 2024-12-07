using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingColoredTextOnTheScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("GÖKKUŞAĞI RENKLERİ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SARI");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("YEŞİL");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("KIRMIZI");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gri");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("KIRMIZI");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("LACİVERT");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CAMGÖBEĞİ");


            Console.Read();
        }
    }
}
