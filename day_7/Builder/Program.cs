

using Reporter;

List<Employee> employees = new()
{
    new Employee{Name="Ivan",Salary=100},
    new Employee{Name="Fedor",Salary=50},
    new Employee{Name="Boris",Salary=200}
};

var biulder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(biulder);
director.Build();

var report=biulder.GetReport();

Console.WriteLine(report);

Console.ReadKey();
