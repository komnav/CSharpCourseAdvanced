using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class Menu<T> where T : class, IIcon, IUrl, IMenuName
    {

        public List<Menu<T>> Childs { get; set; }
        public T GeneralMenu { get; set; }
        public Menu(T generalMenu)
        {
            GeneralMenu = generalMenu;
            Childs = new List<Menu<T>>();
        }

        public string Generate()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("<li>");
            builder.AppendLine(GeneralMenu.GenerateIcon());
            builder.AppendLine(GeneralMenu.GenerateUrl());


            builder.AppendLine("</li>");
            if (Childs != null)
            {
                builder.AppendLine("<ul>");
                foreach (var child in Childs)
                {
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
