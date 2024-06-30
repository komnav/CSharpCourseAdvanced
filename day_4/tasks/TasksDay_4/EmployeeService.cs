using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TasksDay_4
{
    public class EmployeeService
    {
        private Employee[] _employees;
        public Employee[] GetEmployees(int salary)
        {
            return _employees.Where(x => x.Salary < salary).ToArray();
        }
    }
}
