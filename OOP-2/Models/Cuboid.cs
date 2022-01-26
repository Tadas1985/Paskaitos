using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cuboid : Rectangle
    {
        public double Height { get; set; }

        public Cuboid(double height, double width, double lenght) : base(width, lenght)
        {
            if (height < 0)
            { Height = 0; }
            else
            {
                Height = height;
            }
            
        }
        public double GetVolume()
        {
            return GetArea() * Height;
        }
    }
}
