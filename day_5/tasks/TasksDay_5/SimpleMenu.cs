using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class SimpleMenu : IMenu<SimpleMenu>
    {
        public string MenuName { get; set; }
        public List<SimpleMenu> Childs { get; } = new List<SimpleMenu>();

        public string Generate()
        {
            return MenuName;
        }
    }
    public class ComplexMenu : IMenu<ComplexMenu>
    {
        public string MenuName { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }

        public List<ComplexMenu> Childs { get; } = new List<ComplexMenu>();
        StringBuilder builder = new StringBuilder();
        public string Generate()
        {
            builder.Append(@"<img width=""50"" height=""50"" src= """);
            builder.Append(Icon);
            
            builder.Append(@"""/>");

            builder.Append("<a href= ");
            builder.Append(Url);
            builder.Append(" >");
            builder.Append(MenuName);
            builder.Append("</a>");

            return builder.ToString();
        }
    }
}
