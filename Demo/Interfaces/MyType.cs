using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{

    // Interface is a contract between two parties

    // class : class -> inheritance
    // interface : class -> implementation
    // interface : interface -> inheritance
    internal class MyType : IMyType // class MyType is implementing interface IMyType
    {
        
        public int Id { get; set; } // automatic property
        // compiler will geenrate private hidden attribute for this property [backing field]
        // must have get and set because the interface contract says so 
        
        // not static function {Object member function]
        public void MyFun(int X)
        {
            Console.WriteLine($"Hello Route : X = {X}");
        }
    }
}
