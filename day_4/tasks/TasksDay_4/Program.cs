using TasksDay_4;

Employee employee = new Employee("Navruz", "student", 0, "test@gmail.com", "O.Abdurahmonov 1");
EmployeeValidator validator = new EmployeeValidator("Navruz", "student", 0, "test@gmail.com", "O.Abdurahmonov 1");
validator.ValidateEmail(validator.Email);
validator.ValidateAddress(validator.Address);
validator.ValidateSalary(5);

Console.WriteLine("_________________________________");

Manager manager = new Manager("Navruz", "student", 0, "test@gmail.com", "O.Abdurahmonov 1", "Mekhmonkhona", new DateTime(2024, 6, 20, 8, 43, 0));
ManagerValidator managerValidator = new ManagerValidator("Navruz", "student", 0, "test@gmail.com", "O.Abdurahmonov 1", "Mekhmonkhona", new DateTime(2024, 6, 20, 8, 43, 0));

managerValidator.ValidateEmail("managerValidatorTest.Email");
managerValidator.ValidateAddress(managerValidator.Address);
managerValidator.ValidateDepartment(managerValidator.Department); 
managerValidator.ValidateHireDate(managerValidator.HireDate);
managerValidator.ValidateSalary(managerValidator.Salary);

Console.WriteLine("___________________________________");

EmployeeService employeeService = new EmployeeService("Navruz", "student", 10, "test@gmail.com", "O.Abdurahmonov 1");
Console.WriteLine(employeeService.GetEmployees(5));

