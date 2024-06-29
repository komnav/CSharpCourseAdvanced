using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_4
{
    public class ManagerValidator : Manager
    {
        public ManagerValidator(string name, string position, int salary, string email, string address, string department, DateTime hireDate) : base(name, position, salary, email, address, department, hireDate)
        {
            name = Name;
            position = Position;
            salary = Salary;
            email = Email;
            address = Address;
            department = Department;
            hireDate = HireDate;
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
        public bool ValidateDepartment(string department)
        {
            if (department == Department)
            {
                Console.WriteLine("Everything is fine");
                return true;
            }
            Console.WriteLine($"EROR! Your salary {department} is wrong!");
            return false;
        }
        public bool ValidateHireDate(DateTime dateTime)
        {
            if (dateTime == HireDate)
            {
                Console.WriteLine("Everything is fine");
                return true;
            }
            Console.WriteLine($"EROR! Your salary {dateTime} is wrong!");
            return false;
        }
    }
}
