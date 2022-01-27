using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hamburger
    {
        public Hamburger(string name, string meat, double price, string breadRollType)
        {
            Name = name;
            Meat = meat;
            Price = price;
            BreadRollType = breadRollType;
        }
        protected Hamburger(string meat, double price) // Protected constructor only visible in inherited class
        {
            Name = meat;
            Price = price;
            
        }

        public Hamburger()
        {
            
        }

        public string Name { get; set; }
        public string Meat { get; set; }
        public double Price { get; set; }
        public string BreadRollType { get; set; }

        public string Addition1Name { get; set; }
        public double Addition1Price { get; set; }
        public string Addition2Name { get; set; }
        public double Addition2Price { get; set; }
        public string Addition3Name { get; set; }
        public double Addition3Price { get; set; }
        public string Addition4Name { get; set; }
        public double Addition4Price { get; set; }

        public virtual void AddHamburgerAddition1(string addition1Name, double addition1Price)
        {
            Addition1Name = addition1Name;
            Addition1Price = addition1Price;
            Console.WriteLine($"Added  {Addition1Name} for an extra {Addition1Price}");
        }
        public virtual void AddHamburgerAddition2(string addition2Name, double addition2Price)
        {
            Addition2Name = addition2Name;
            Addition2Price = addition2Price;
            Console.WriteLine($"Added {Addition2Name} for an extra {Addition2Price}");
        }
        public virtual void AddHamburgerAddition3(string addition3Name, double addition3Price)
        {
            Addition3Name = addition3Name;
            Addition3Price = addition3Price;
            Console.WriteLine($"Added {Addition3Name} for an extra {Addition3Price}");
        }
        public virtual void AddHamburgerAddition4(string addition4Name, double addition4Price)
        {
            Addition4Name = addition4Name;
            Addition4Price = addition4Price;
            Console.WriteLine($"Added {Addition4Name} for an extra {Addition4Price}");
        }
        public virtual double ItemizeHamburger()
        {
            double totalPrice = Price + Addition1Price + Addition2Price + Addition3Price + Addition4Price;
            return totalPrice;
        }
    }
}
