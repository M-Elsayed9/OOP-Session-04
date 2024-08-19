using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part2_Q1
{
    internal class Circle : ICircle
    {
        public double Area { get { return Math.PI * (Radius * Radius); } }
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle()
        {
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius {Radius} has an area of {Area}");
        }
    }
}
