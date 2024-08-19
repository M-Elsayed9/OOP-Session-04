using Demo.IClonable_Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            // x.Id > y.Id => +ve
            // x.Id < y.Id => -ve
            // x.Id = y.Id => 0
            // employeeX is null => +ve
            // employeeY is null => -ve
            // employee x is null && employeeY is null => 0

            Employee? employeeX = x as Employee;
            Employee? employeeY = y as Employee;

            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY is null ? 0 : -1);
        }
    }
}
