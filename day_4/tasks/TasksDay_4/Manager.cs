using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_4
{
    public class Manager
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public DateTime HireDate { get; set; }

        public Manager(string name, string position, int salary, string email,string address,string department,DateTime hireDate)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Email = email;
            Address = address;
            Department = department;
            HireDate = hireDate;

        }
    }
}
