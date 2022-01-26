using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rectangle
    {
        public Rectangle(double width, double length)
        {
            if (width < 0 && length < 0)
            {
                Width = 0;
                Length = 0;
            }
            else
            {
                Width = width;
                Length = length;
            }
        }

        public double Width { get; set; }
        public double Length { get; set; }

        public double GetArea()
        {
            return Width * Length;
        }
    }
}
