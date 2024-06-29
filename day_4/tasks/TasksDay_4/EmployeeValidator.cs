using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_4
{
    public class EmployeeValidator : Employee
    {
        public EmployeeValidator(string name, string position, int salary, string email, string address) : base(name, position, salary, email, address)
        {
            name = Name;
            position= Position;
            salary = Salary;
            email= Email;
            address = Address;
        }
        public bool ValidateEmail(string email)
        {
            if (email == Email)
            {
                Console.WriteLine("Everything is fine");
                return true;
            }
            Console.WriteLine($"EROR! Your salary {email} is wrong!");
            return false;
        }
       public bool ValidateAddress(string address)
        {
            if (address == Address)
            {
                Console.WriteLine("Everything is fine");
                return true;
            }
            Console.WriteLine($"EROR! Your salary {address} is wrong!");
            return false;
        }
       public bool ValidateSalary(int salary)
        {
            if (salary == Salary)
            {
                Console.WriteLine("Everything is fine");
                return true;
            }
            Console.WriteLine($"EROR! Your salary {salary} is wrong!");
            return false;
        }
    }
}
