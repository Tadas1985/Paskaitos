using Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hamburger hamburger = new Hamburger("Basic", "Sausage", 3.56, "White");
            hamburger.AddHamburgerAddition1("Tomato", 0.27);
            hamburger.AddHamburgerAddition2("Lettuce", 0.75);
            hamburger.AddHamburgerAddition3("Cheese", 1.13);
            Console.WriteLine("Total Burger price is " + hamburger.ItemizeHamburger());

            HealthyBurger healthyBurger = new HealthyBurger("Bacon", 5.67);
            healthyBurger.AddHamburgerAddition1("Egg", 5.43);
            healthyBurger.AddHealthyAddition1("Lentils", 3.41);
            Console.WriteLine("Total Healthy Burger price is  " + healthyBurger.ItemizeHamburger());

            DeluxBurger db = new DeluxBurger();
            db.AddHamburgerAddition3("Should not do this", 50.53);
            Console.WriteLine("Total Deluxe Burger price is " + db.ItemizeHamburger());

            healthyBurger.AddHamburgerAddition1("Serniena", 11.2);
            healthyBurger.ItemizeHamburger();
            db.ItemizeHamburger();
        }
    }
}
