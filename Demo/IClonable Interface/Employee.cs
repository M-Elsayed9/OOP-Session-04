using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.IClonable_Interface
{
    internal class Employee : ICloneable
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        //Copy Constructor

        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
        }

        public Employee() { }

        public object Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}
