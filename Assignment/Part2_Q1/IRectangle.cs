using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part2_Q1
{
    internal interface IRectangle : IShape
    {
        int Width { get; set; }
        int Length { get; set; }
    }
}
