using System;

using Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Tom", "Alex", 201);
            Console.WriteLine(invoice.Receiver);
            //------------------------------------------------

            Palm palm = new Palm(13, 3);
            Console.WriteLine(palm.AddOneMonthToAge(5));
        }
    }
}
