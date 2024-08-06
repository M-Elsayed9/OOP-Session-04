using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    interface IMyType
    {
        // Default access modifier inside interface is public 
        // private access modifier is not allowed inside the interface


        // What you can write inside the interface
        // 1. Signature for Property [Name - Type [Get] [Set]] -> Signature for property


        public int Id { get; set; }
        // signature for property because its is inside an interface and not an automatic property
        // inside class or struct -> automatic property
        // Compiler will generate private hidden attribute [Backing Field]
        // inside interface -> signature for property


        // 2. Signature for methods [Name - Return Type - Parameters]

        void MyFun(int X);
        // cannot be private, protected, internal, protected internal, private protected
        // 


        // 3. Default Implmented methods [C# 8.0] feature (.NetCore 3.1 2019)

        public void print()
        {
            Console.WriteLine("Hello default implmented method");
        }



    }
}
