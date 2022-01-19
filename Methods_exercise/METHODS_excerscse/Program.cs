using System;
using System.Linq;


namespace METHODS_excerscse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintName("Tadas");
            //PrintNameNTimes("Rasa", 100);
            //PrintHashTag("Tadas");
            //Console.WriteLine(KMI(1.8, 110));
            //Console.WriteLine(CountsEmptySpacesInString("Vilnius yra sostine")); 
            //int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            //ArraysElementCountAndElementSum(myArray);
            //Console.WriteLine(RaisingNumberByAnotherNumber(2,3));
            //Console.WriteLine(Fibonacci(6));
            //Fibonacci(7);
            //Console.WriteLine(Factorial(5));
        }

        // 1-Parašyti funkciją, kuri išveda į konsolę Jūsų vardą
        public static void PrintName(string name)
        {
            Console.WriteLine($"Your name is {name}");
        }

        // 2- Parašyti funkciją, kuri išvedą į konsolę bet kokį vardą tiek kartų, kiek nurodo parametras
        public static void PrintNameNTimes(string name, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine($"{name}");
            }
        }

        // 3- Parašyti funkciją, kuri gauna string tipo parametrą. Funkcija turi gražinti eilutę su tiek „#“,kiek simbolių gautame parametre.
        public static void PrintHashTag(string numberOfHashtag) 
        {
            foreach (var item in numberOfHashtag)
            {
                Console.Write("#");
            }
        }

        public static double KMI(double heightInMeters, int kg)
        { 
            double bmi =Convert.ToDouble(kg) / ((heightInMeters / 100) * (heightInMeters / 100)); 
            return bmi;
        }

        // 5- Parašyti funkciją, kuri suskaičiuoja ir gražina, kiek yra tarpų eilutėje

        public static int CountsEmptySpacesInString(string newString)
        {
            int countSpaces = newString.Count(char.IsWhiteSpace);
            return countSpaces;
        }

        // 6- Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų sumą, bei kiek tų elementų yra. Pvz.: Suma: 123, viso: 7 elementai
        public static void ArraysElementCountAndElementSum(int[] array)
        {
            int sum = 0;
            int numberOfElements =0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                numberOfElements++; 
            }
            Console.WriteLine($"Sum: {sum}, number of elements: {numberOfElements}");
        }

        // 7- Parašyti funkciją, kuri pakelią vieną skaičių į antrojo laipsnį Pvz.: 2 ^ 3 = 8

        public static double RaisingNumberByAnotherNumber(int number, int raisedByNumber)
        {
            return Math.Pow(number, raisedByNumber);
            
        }

        // 8- Padaryti funkciją, kuri parodo x Fibonačio skaičių

        public static void Fibonacci(int number)
        {
            int a = 0, b = 1, c=0;

            
           
            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                c +=a;

                Console.WriteLine(a);
            }
            Console.WriteLine($"Sum is {c}");
            
        }

        // 9- Parašyti rekursinę funkciją faktorialo skaičiavimui

        //public static int Factorial(int number)
        //{
        //    if (number == 0)
        //        return 1;
        //    else
        //        return number * Factorial(number - 1);
        //}












    }
}
