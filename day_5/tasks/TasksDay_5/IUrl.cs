using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public interface IUrl : IMenuName
    {
        string Url { get; set; }

        public string GenerateUrl()
        {
            StringBuilder builder = new StringBuilder();
            if (!string.IsNullOrEmpty(Url))
            {
                builder.AppendLine("<a href=\"");
                builder.AppendLine(Url);
                builder.AppendLine("\">");
                builder.AppendLine(MenuName);
                builder.AppendLine("</a>");
            }
            return builder.ToString();
        }
    }
}
