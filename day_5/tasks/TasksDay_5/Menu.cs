using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class MenuGenerator
    {

        public static string Generate<T>(IMenu<T> menu) where T : IMenu<T>
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("<li>");
            builder.AppendLine(menu.Generate());

            builder.AppendLine("</li>");

            if (menu.Childs != null)
            {
                builder.AppendLine("<ul>");
                foreach (var child in menu.Childs)
                {
                    builder.AppendLine(Generate(child));
                }

                builder.AppendLine("</ul>");
            }
            return builder.ToString();
        }
        public static IMenu<T> GenerateMenuToFile<T>(IMenu<T> menu, string fileName) where T : IMenu<T>
        {

            string html = Generate(menu);
            File.WriteAllText(fileName, html);
            return menu;
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
