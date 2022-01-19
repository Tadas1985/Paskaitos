﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
    }
}
