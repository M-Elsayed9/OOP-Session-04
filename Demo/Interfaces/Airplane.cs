using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class Airplane : Vehicle, IMoveable, IFlyable
        // Airplace inherit from Vehicle and implement IMoveable and IFlyable
    {
        // implicit implementation of backward
        public void Backward()
        {
            Console.WriteLine("Airplane backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airplane forward on ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane forward in the air");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplane left on ground");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplane left in the air");
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
