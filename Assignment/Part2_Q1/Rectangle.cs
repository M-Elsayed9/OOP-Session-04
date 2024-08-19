using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part2_Q1
{
    internal class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public double Area { get { return Width * Length; } }

        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public Rectangle()
        {
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width {Width} and length {Length} has an area of {Area}");
        }
    }
}
