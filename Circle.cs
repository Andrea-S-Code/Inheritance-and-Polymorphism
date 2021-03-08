using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Circle : Shape
    {

        
        public override void GetArea()
        {
            Console.WriteLine("Getting area of a Circle");

        }
        public override int CalculateArea(int Height, int Width)
        {
            return (int)(Width * Height * Math.PI);

        }

    }
}
