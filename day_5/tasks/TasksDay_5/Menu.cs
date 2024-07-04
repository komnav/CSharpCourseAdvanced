using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class Menu<T>
    {
        public string Icon { get; set; }
        public string Url { get; set; }
        public string MenuName { get; set; }
        public List<Menu<T>> Childs { get; set; }
        public Menu(string menuName)
        {
            MenuName = menuName;
        }

        public string Generate()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("<li>");
            if (!string.IsNullOrEmpty(Icon))
            {
                builder.AppendLine("<img src= ");
                builder.AppendLine(Icon);
                builder.AppendLine(" \t alt= ");
                builder.AppendLine(MenuName);
                builder.AppendLine(" > ");
            }
            if (!string.IsNullOrEmpty(Url))
            {
                builder.AppendLine("<a href= ");
                builder.AppendLine(Url);
                builder.AppendLine(" >");
                builder.AppendLine(MenuName);
                builder.AppendLine(" </a>");
            }
            builder.AppendLine("</li>");
            if (Childs != null)
            {
                foreach (var child in Childs)
                {
                    builder.AppendLine("<ul>");
                    builder.AppendLine(child.Generate());
                }
                builder.AppendLine("</ul>");
            }
            return builder.ToString();
        }
    }
}
//string result = $"<li>{MenuName}</li>";

//if (Childs != null)
//{
//    result += "<ul>";
//    foreach (var item in Childs)
//    {
//        result = result + $"<li>{item.MenuName} </li>";
//    }
//    result = result + "</ul>";
//}
//return result;
