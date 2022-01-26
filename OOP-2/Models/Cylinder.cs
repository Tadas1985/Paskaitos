using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cylinder: Circle
    {
        public double Height { get; set; }

        public Cylinder(double height, double radius): base(radius)
        {
            if (height < 0)
            {
                Height = 0;
            }
            else 
            {
                Height = height;
            }
            
        }

        public double GetVolume()
        {
            return GetArea()* Height; ;
        }
    }
}
