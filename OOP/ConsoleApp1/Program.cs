using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays_Lists_and_Collections();
            static void Arrays_Lists_and_Collections()
            {
                var names = new List<string>() {"Tom", "John", "Emily" };
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
