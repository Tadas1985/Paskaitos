using System;
using System.Collections.Generic;
using System.Linq;

namespace Penkta_paskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vartotojas įveda 5 skaičius, programa išveda juos atvirkštine tvarka
            //var numbers = new int[5];
            //var j = 0;
            //for (int i = numbers.Length-1; i >=0; i--)
            //{               
            //    Console.WriteLine($"Enter number {j}");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    numbers[i] = number;
            //    j++;
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //-----------------------------------------------------------------------

            //Vartotojas įveda 5 skaičius, programa  išveda jų sumą
            //var numbers = new int[5];
            //var j = 0;
            //var sum = 0;
            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    Console.WriteLine($"Enter number {j}");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    numbers[i] = number;
            //    sum += number;
            //    j++;
            //}
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(sum);

            //---------------------------------------------------------------------

            // Vartotojas įveda 5 skaičius, programa juos išsaugo masyve, nukopijuoja į kitą(naują) masyvą ir parodo naujo masyvo turinį

            //var numbers = new int[5];
            //var j = 0;
            //var k=0;    
            //var copyOfArray= new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter number {j}");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    numbers[i] = number;
            //    j++;
            //}
            //foreach (var item in numbers)
            //{
            //    copyOfArray[k] = item;
            //    Console.WriteLine($"Original array: {item}");
            //    Console.WriteLine($"Copy from original array: {copyOfArray[k]}");
            //}

            //---------------------------------------------------------------------

            // Užpildyti masyvą atsitiktiniais skaičiais. Surasti ir parodyti didžiausią ir mažiausią elementą. Masyvą surūšiuoti ir išvesti
            // NEBAIGTAS

            //var array1 = new int[5];
            //var max1 = 0;
            //var array2 = new int[5];
            //var max2 = 0;
            //Random rnd = new Random();
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = rnd.Next(10);
            //    array2[i] = rnd.Next(10);
            //    Console.WriteLine( array1[i]);
            //    Console.WriteLine( array2[i]);
            //}
            //foreach (var item in array1)
            //{

            //}
            //Console.WriteLine(max1 = array1);
            //Console.WriteLine();
            //------------------------------------------------------------
            // Sukurti 2 masyvus ir užpildyti atsitiktiniais skaičiais. Sujungti juos į vieną, surūšiuoti ir išvesti
            //var randomNumber = new Random();
            //int[] myNums = new int[5];
            //int[] myNums2 = new int[5];
            //int[] myNums3 = new int[10];

            //Console.WriteLine("Array1:");
            //for (int i = 0; i < 5; i++)
            //{
            //    myNums[i] = randomNumber.Next(1, 10);
            //}
            //foreach (var item in myNums)
            //{
            //    Console.WriteLine($"{item}, ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Array2:");
            //for (int i = 0; i < 5; i++)
            //{
            //    myNums2[i]= randomNumber.Next(1, 10);    
            //}
            //foreach (var item in myNums2)
            //{
            //    Console.WriteLine($"{item}, ");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Array3:");
            //for (int i = 0; i < 5; i++)
            //{
            //    myNums3[i]= myNums[i]; 
            //}
            //for (int i = 5; i < 10; i++)
            //{
            //    myNums3[i] = myNums2[i - 5];
            //}
            //foreach (var  item in myNums3)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Sorted array3:");
            //Array.Sort(myNums3);
            //foreach (var item in myNums3)
            //{
            //    Console.WriteLine($"{item}, ");
            //}


            //------------------------------------------------------------------------------------------------------
            // Užpildyti masyvą atsitiktiniais skaičiais ir parodyti kiek karų kartojasi kiekvienas elementas
            //var randomNumbers = new List <int>();
            //var random = new Random();
            //for (int i = 0; i < 100; i++)
            //{               
            //    randomNumbers.Add(random.Next(1, 10));
            //}
            //var usedNumbers = new List<int>();


            //foreach (int elementToCount in randomNumbers)
            //{
            //    if (usedNumbers.Contains(elementToCount))
            //    {
            //        continue;
            //    }
            //    int repeatingNumberCount = 0;
            //    foreach (int element in randomNumbers)
            //    {
            //        if (elementToCount == element)
            //        {
            //            repeatingNumberCount++;
            //        }
            //    }
            //    Console.WriteLine($"{elementToCount} repeated {repeatingNumberCount} times");
            //    usedNumbers.Add(elementToCount);

            //}

            // Parašyti programą, kurioje ištrinamas bet kuris masyvo elementas. Pastaba –masyvas nukopijuojamas į naująm masyvą BE pasirinkto elemento Rezultatas parodomas

            //var numberList = new List<int>();   
            //Random rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{

            //    numberList.Add(rnd.Next(1,10));
            //}
            //foreach (var item in numberList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================");
            //numberList.RemoveAt(rnd.Next(1, 10));
            //foreach (var item in numberList)
            //{
            //    Console.WriteLine(item);
            //}
            //numberList.CopyTo
            //List<int> clonedList = numberList.ToList();
            //Console.WriteLine("--------------------------");
            //foreach (var item in clonedList)
            //{
            //    Console.WriteLine(item);
            //}


            // Parodyti antra didžiausią ir antrą mažiausią elementą masyve
            // NEBAIGTAS
            //var numberList = new List<int>();
            //Random rnd = new Random();
            //var  sorted = new List<int>();
            //var secondSmallestNumber = 0;
            //var secondMaxNumber = 0;

            //for (int i = 0; i < 10; i++)
            //{

            //    numberList.Add(rnd.Next(1, 10));
            //}
            //numberList.Sort();
            //foreach ( var item in numberList)
            //{
            //    if (secondSmallestNumber > item)
            //    {
            //        secondSmallestNumber = item;
            //    }
            //    if (secondMaxNumber < item)
            //    {
            //        secondMaxNumber = item;
            //    }
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Smallest {secondSmallestNumber}");
            //Console.WriteLine($"Largestlest {secondMaxNumber}");
            //---------------------------------------------------------------------
            // NEBAIGTAS
            //int i, j, temp;
            //var NumberList = new List<int>();
            //Random rnd = new Random();


            //for (i = 0; i < 10; i++)
            //{
            //    NumberList.Add(rnd.Next(1, 10));
            //}
            //foreach (int item in NumberList)
            //{
            //    Console.WriteLine(item);
            //}
            //for (i = 0; i < NumberList.Count; i++)
            //{
            //    for (j = i + 1; j < NumberList.Count; j++)
            //    {
            //        if (NumberList[i] > NumberList[j])
            //        {
            //            temp = NumberList[i];
            //            NumberList[i] = NumberList[j];
            //            NumberList[j] = temp;
            //        }
            //    }
            //}
        
            //Console.WriteLine(i);
            //Console.WriteLine("Second smallest element:" + NumberList[1]);
            // Sukurti 3x3 matricą.  Išvesti:   1.visų matricos elementų sumą 2.kiekvienos eilutės elementų sumą 3.kiekvieno stulpelio elementų sumą

            //  Parašyti masyvo rūšiavimo algoritmą



            //-----------------------------------------------------------------------------
           
        }
    }

}
