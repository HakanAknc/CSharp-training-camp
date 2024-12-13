using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Diziler, her değer için ayrı değişkenler tanımlamak yerine, tek bir değişkende birden fazla değeri depolamak için kullanılır.
            Bir diziyi bildirmek için değişken türünü köşeli parantezlerle tanımlayın 
            */

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //int[] myNum = { 10, 20, 30, 40 };

            //cars[0] = "Hakan";

            //Console.WriteLine(cars[0]);  // volvo

            // Not: Dizi dizinleri 0 ile başlar: [0] ilk öğedir. [1] ikinci öğedir, vb.

            /*
             Dizi Uzunluğu
             Bir dizinin kaç elemandan oluştuğunu bulmak için şu Lengthözelliği kullanın:
             */
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Console.WriteLine(cars.Length);

            /*
             Dizi Oluşturmanın Diğer Yolları
            C# ile aşinaysanız, newanahtar sözcükle oluşturulan dizileri görmüş olabilirsiniz ve belki de belirli bir boyuta sahip dizileri de görmüşsünüzdür. 
            C#'ta, bir dizi oluşturmanın farklı yolları vardır:
             */

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };

            // Not : Ancak, bir diziyi bildirip daha sonra başlatırsanız, şu anahtar sözcüğü kullanmanız gerektiğini unutmamalısınız new:


            for (int i = 0; i < cars3.Length; i++)
            {
                Console.WriteLine(cars3[i]);
            }

            Console.WriteLine("**************");

            foreach (string car in cars2)
            {
                Console.WriteLine(car);
            }

            Console.Read();



        }
    }
}
