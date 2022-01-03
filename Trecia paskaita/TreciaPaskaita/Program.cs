using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three symbols:");
            var symbol1 = Console.ReadLine();
            char a = Convert.ToChar(symbol1.Substring(2,1));
            char b = Convert.ToChar(symbol1.Substring(1, 1));
            char c = Convert.ToChar(symbol1.Substring(0, 1));

            Console.WriteLine($" Sybol3 is {a}, symbol2 is {b}, symbol1 is {c}");
            Console.ReadKey();

            Console.WriteLine("Enter distance in meters:");
            int meters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter time in seconds");
            int seconds = Convert.ToInt32(Console.ReadLine());
            var metersPerSecond = meters / seconds;
            var speed = (3.6 * metersPerSecond);
            Console.WriteLine($"{meters} meters per {seconds} second is {speed} km/h");
            Console.ReadLine();

            Console.WriteLine("Enter the radius of the sphere:");
            var radius = Convert.ToInt32(Console.ReadLine());
            var volume = (float)(4.0 / 3 * Math.PI * radius * radius * radius);
            float area = (float)(4 * Math.PI * radius * radius);
            Console.WriteLine($"Sphere volume is {volume}, and area is {area}");
            Console.ReadLine();


            Console.WriteLine("Enter number1: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            var number2 = Convert.ToInt32(Console.ReadLine());
            bool isEven = number1 % 2 ==0 && number2 %2 ==0;
            Console.WriteLine(isEven);
            Console.ReadLine();
        }
    }
}
