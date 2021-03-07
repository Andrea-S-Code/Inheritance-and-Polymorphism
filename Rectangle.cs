using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Rectangle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("Getting area of a rectangle");

        }

        public override int CalculateArea(int Height, int Width)
        {
            var answer = CalculateArea((int)Height, (int)Width);
            return answer;
        }
    }
}
