using Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private readonly EmployeeReport _employeeReport;
        private readonly IEnumerable<Employee> _employees;
        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }
        public void BuildBody()
        {
            _employeeReport.Body = string.Join(Environment.NewLine, _employees.Select
                (s => $"Employee: {s.Name}\t\tSalaru: {s.Salary}$"));
        }

        public void BuildFooter()
        {
            _employeeReport.Footer = 
                "\n-----------------------------------------------------\n";

            _employeeReport.Footer += $"\nTotal employees: {_employees.Count()}," +
                $"Total salary: {_employees.Sum(s => s.Salary)}$";
        }

        public void BuildHeader()
        {
            _employeeReport.Header = $"Employee report on date: {DateTime.Now}\n";

            _employeeReport.Header += "\n-----------------------------------------------------\n";
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;


            return employeeReport;
        }

    }
}
