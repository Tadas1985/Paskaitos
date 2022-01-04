using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaPaskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 0; i <= number; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();




            //Console.WriteLine("enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= number; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadLine();

            //Console.WriteLine("enter a number of lines");
            //int numberOfLines = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < numberOfLines+1; i++)
            //{
            //    for (int j = 1; j <= (numberOfLines - i); j++)
            //        Console.Write(" ");
            //    for (int t = 1; t < i * 2; t++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Console.WriteLine("enter a number a text");
            //string text = Console.ReadLine();
            //Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
            //Console.ReadLine();

            bool toContinue = true;
            var calcAnswer = 0;
            var answer = 'y';
            while (toContinue)
            {
                Console.WriteLine("Enter first number:");
                var num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                var num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter opertor");
                char action = Convert.ToChar(Console.ReadLine());
                if (action == '-')
                {
                    calcAnswer = num1 - num2;
                }
                else if (action == '+')
                {
                    calcAnswer = num1 + num2;
                }
                else if (action == '*')
                {
                    calcAnswer = num1 * num2;
                }
                else if (action == '/')
                {
                    calcAnswer = num1 / num2;
                }
                else
                {
                    calcAnswer = num1 % num2;
                }


                Console.WriteLine(calcAnswer);
                Console.WriteLine("Do you want to continue?: y/n");
                answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'n')
                {
                    toContinue = false;
                }



                //var inputs = new int[5];
                //for (int i = 0; i < inputs.Length; i++)
                //{
                //    inputs[i] = Convert.ToInt32(Console.ReadLine());
                //}
                //Array.Reverse(inputs);


                //var list1 = new List<int>(10);
                //Random rnd = new Random();

                //for (int i = 0; i <= list1.Count; i++)
                //{
                //    list1.Add(rnd.Next(1,10));

                //}
                //foreach (var item in list1)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadLine();







            }
        }
    }
}
