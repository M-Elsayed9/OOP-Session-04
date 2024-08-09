using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class Car : Vehicle, IMoveable
    {
        // speed
        // Forward()
        // Backward()
        // right()
        // Left()
        public void Backward()
        {
            Console.WriteLine("Car backward on ground");
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
