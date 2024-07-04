using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public interface IIcon : IMenuName
    {
        public string Icon { get; set; }
        public string GenerateIcon()
        {
            StringBuilder builder = new StringBuilder();
            if (!string.IsNullOrEmpty(Icon))
            {
                builder.AppendLine("<img src= ");
                builder.AppendLine(Icon);
                builder.AppendLine(" \t alt= ");
                builder.AppendLine(MenuName);
                builder.AppendLine(" > ");
            }
            return builder.ToString();
        }
    }
}
