using System;
using System.Collections.Generic;
using System.Linq;

namespace SestaPaskaita_METHODS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Randa maziausia ir didziausia skaiciu

            //var numeris=0;
            //var smallestNum = 19;
            //var bigestNum = 0;
            //Random rnd = new Random();
            //var sarasas = new int[10];
            //for (int i = 0; i < sarasas.Length; i++)
            //{
            //    sarasas[i] = rnd.Next(1,10);
            //    numeris++;  
            //    Console.WriteLine($"{numeris} yra {sarasas[i]}");
            //}
            //for (int i = 0; i < sarasas.Length; i++)
            //{
            //    if (sarasas[i] < smallestNum)
            //    {
            //        smallestNum = sarasas[i];
            //    }
            //    if (bigestNum < sarasas[i])
            //    {
            //        bigestNum = sarasas[i];
            //    }
            //}
            //Console.WriteLine("Smalest number is " +  smallestNum);
            //Console.WriteLine("Largest number is: " + bigestNum);

            //---------------------------------------------------------
            // Spausdina is prieko i gala
            //var message = "Labas";

            //for (int i = message.Length -1; i >= 0; i--)
            //{
            //    Console.Write(message[i]);
            //}

            //---------------------------------------------------------

            // Calculator
            //bool state=true;
            //int number = 0;

            //while (state == true)
            //{
            //    Console.WriteLine("Enter a number");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i < 11; i++)
            //    {
            //        Console.WriteLine($"{number} * {i} = {number * i}");
            //    }
            //}

            //Console.WriteLine("Do you want to continuoe? y/n");
            //var answer = Console.ReadLine();
            //if (answer == "n")
            //{
            //    state = false;
            //}
            //else
            //{
            //    Environment.Exit(1);
            //}


            //------------------------------------------------------------

            // PIRAMIDE

            //int rows = 5;
            //for (int i = 0; i <= rows; i++)
            //{
            //    Console.Write(new String(' ', rows -i));
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //-----------------------------------------------------------
            //  ISSPAUSDINA NUMERIUS ATVIRKSCIAI

            //int[] array = new int[5];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = array.Length-1; i >= 0;  i--)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //----------------------------------------------------------

            // Uzpildyti masyva su atsitiktiniais skaiciais ir parodyti didziausia irmaziausia skaiciais

            //int[] randomNumbers = new int[5];
            //Random random = new Random();
            //var smallestNum = 99;
            //var largestNum = 0;

            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    randomNumbers[i] = random.Next(1, 100);
            //}
            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    if (smallestNum > randomNumbers[i])
            //    {
            //        smallestNum = randomNumbers[i];
            //    }
            //    if (largestNum < randomNumbers[i])
            //    {
            //        largestNum = randomNumbers[i];
            //    }
            //}
            //Console.WriteLine($"Smalest number is: {smallestNum} and largest number is {largestNum}");

            //----------------------------------------------------------------

            // int[,] matrix = new int[,] {
            //{1,2,3},
            //{4,5,6},
            //{7,8,9 }
            //};
            // int sum = 0;
            // Console.WriteLine(matrix[0,0]);
            // for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            // {
            //     for (int col = 0; col <= matrix.GetUpperBound(1); col++)
            //     {
            //         Console.WriteLine(matrix[row, col]);
            //         sum +=matrix[row, col];
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine(sum);

            //---------------------------------------------------------------------
            //int []randomNumbers = new int[1000];
            //Random rnd = new Random();
            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    randomNumbers[i]= rnd.Next(1,1000);
            //}
            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    for (int j = 0; j < randomNumbers.Length; j++)
            //    {
            //        if (randomNumbers[i]> randomNumbers[j])
            //        {
            //            int temp = randomNumbers[i];
            //            randomNumbers[i] = randomNumbers[j];
            //            randomNumbers[j] = temp;
            //        }
            //    }
            //}
            //------------------------------------------------------------------
            // LISTAI
            //List <int> randomNumbers = new(); 
            //Random random = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    randomNumbers.Add(random.Next(1,20));
            //}
            //foreach (var item in randomNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //----------------------------------------------------------------------
            //List<int>listOne = new() { 1,2,4,8,16};
            //List<int> ListTwo = new() { 2, 4, 6 };
            //List<int> union = listOne.Intersect(ListTwo).ToList();
            //foreach (var item in union)
            //{
            //    Console.WriteLine(item);
            //}  
        }
    }
}   


