using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TasksDay_4
{
    public class EmployeeService : Employee
    {
        public EmployeeService(string name, string position, int salary, string email, string address) : base(name, position, salary, email, address)
        {
            name = Name;
            position = Position;
            salary = Salary;
            email = Email;
            address = Address;
        }
        public string GetEmployees(int salary)
        {
            if (salary < Salary)
            {
                return $"Name employee {Name}";
            }
            return "Error";
        }
    }
}
