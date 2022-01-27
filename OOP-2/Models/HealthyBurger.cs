using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HealthyBurger: Hamburger
    {
        public string HealthyExtra1Name { get; set; }
        public double HealthyExtra1Price { get; set; }
        public string HealthyExtra2Name { get; set; }
        public double HealthyExtra2Price { get; set; }

        public HealthyBurger(string meat, double price): base(meat, price)
        {
            Name = "Healthy";
            BreadRollType = "Brown rye";
            Console.WriteLine($"{Name} hamburger on a {BreadRollType} roll with {Meat}, price is {Price}");
        }
       

        public void AddHealthyAddition1(string HealthyExtra1Name, double HealthyExtra1Price)
        {
            HealthyExtra1Name = HealthyExtra1Name;
            HealthyExtra1Price = HealthyExtra1Price;
            Console.WriteLine($"Added {HealthyExtra1Name} for an extra {HealthyExtra1Price}");
        }
        public void AddHealthyAddition2(string HealthyExtra2Name, double HealthyExtra2Price)
        {
            HealthyExtra2Name = HealthyExtra2Name;
            HealthyExtra2Price = HealthyExtra2Price;
            Console.WriteLine($"Added {HealthyExtra2Name} for an extra {HealthyExtra2Price}");
        }
        public override double ItemizeHamburger()
        {
            
            return Price + Addition1Price + Addition2Price + Addition3Price + Addition4Price + HealthyExtra1Price + HealthyExtra2Price ;
        }
    }
}
