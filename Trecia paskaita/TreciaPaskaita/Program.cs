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
            //console.writeline("enter three symbols:");
            //var symbol1 = console.readline();
            //char a = convert.tochar(symbol1.substring(2,1));
            //char b = convert.tochar(symbol1.substring(1, 1));
            //char c = convert.tochar(symbol1.substring(0, 1));

            //console.writeline($" sybol3 is {a}, symbol2 is {b}, symbol1 is {c}");
            //console.readkey();

            //console.writeline("enter distance in meters:");
            //int meters = convert.toint32(console.readline());
            //console.writeline("enter time in seconds");
            //int seconds = convert.toint32(console.readline());
            //var meterspersecond = meters / seconds;
            //var speed = (3.6 * meterspersecond);
            //console.writeline($"{meters} meters per {seconds} second is {speed} km/h");
            //console.readline();

            //console.writeline("enter the radius of the sphere:");
            //var radius = convert.toint32(console.readline());
            //var volume = (float)(4.0 / 3 * math.pi * radius * radius * radius);
            //float area = (float)(4 * math.pi * radius * radius);
            //console.writeline($"sphere volume is {volume}, and area is {area}");
            //console.readline();


            //console.writeline("enter number1: ");
            //var number1 = convert.toint32(console.readline());
            //console.writeline("enter number2:");
            //var number2 = convert.toint32(console.readline());
            //bool iseven = number1 % 2 ==0 && number2 %2 ==0;
            //console.writeline(iseven);
            //console.readline();

            Console.WriteLine("Enter the number of people");
            var numOfPeople = (Console.ReadLine());
            int number;
            if (int.TryParse(numOfPeople, out number))
            {
                if (number == 1)
                {
                    Console.WriteLine("Its solo player");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Its duet");
                }
                else if (number > 2 && number < 10)
                {
                    Console.WriteLine("Its a group");
                }
                else if (number > 10);
                {
                    Console.WriteLine("Its a large group");
                }
               
            }
            else 
            {

                Console.WriteLine("You entered invalid value");
                Environment.Exit(1);
                Console.ReadKey();
            }
            
           Console.ReadKey();

        }
    }
}
