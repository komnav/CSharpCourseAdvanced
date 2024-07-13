using Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public interface IEmployeeReportBuilder
    {
        void BuildHeader();
        void BuildFooter();
        void BuildBody();

        EmployeeReport GetReport();
    }
}
