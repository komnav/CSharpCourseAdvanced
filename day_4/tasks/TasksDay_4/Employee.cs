namespace TasksDay_4
{
    public  class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Employee(string name, string position, int salary, string email, string address)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Email = email;
            Address = address;
        }
    }
}
