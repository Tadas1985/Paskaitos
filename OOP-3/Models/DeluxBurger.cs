using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DeluxBurger: Hamburger
    {
        public DeluxBurger()
        {
            Name = "DeluxBurger";
            BreadRollType = "White";
            Meat = "Sausage & Bacon";
            Price = 19.10;
        }
        public override void AddHamburgerAddition1(string name, double price)
        {
            Console.WriteLine($"No additional items can be added to a deluxe burger");
        }
        public override void AddHamburgerAddition2(string name, double price)
        {
            Console.WriteLine($"No additional items can be added to a deluxe burger");
        }
        public override void AddHamburgerAddition3(string name, double price)
        {
            Console.WriteLine($"No additional items can be added to a deluxe burger");
        }
        public override void AddHamburgerAddition4(string name, double price)
        {
            Console.WriteLine($"No additional items can be added to a deluxe burger");
        }

        public override double ItemizeHamburger()
        {
            double chips = 1.75;
            double drink = 1.81;
            Console.WriteLine($"Added chips for an extra {chips}");
            Console.WriteLine($"Added drink for an extra {drink}");
            return Price + chips + drink;
        }
    }
}
