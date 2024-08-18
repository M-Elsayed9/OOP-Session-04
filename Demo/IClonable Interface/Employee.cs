using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.IClonable_Interface
{
    internal class Employee : ICloneable, IComparable
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

        //public int CompareTo(Employee? obj)
        //{
           
        //}

        public int CompareTo(object? obj)
        {
            

            Employee? emp = obj as Employee; // unsafe cast

            if(this.Salary> emp.Salary)
            {
                return 1;
            }
            else if(this.Salary < emp.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }

       
    }
}
