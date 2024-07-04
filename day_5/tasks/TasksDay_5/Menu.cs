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
        public Menu(T menuName)
        {
            IMenuName menuName1 = menuName;
            Childs = new List<Menu<T>>();
        }

        public string Generate(IIcon icon, IUrl url)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("<li>");
            icon.GenerateIcon();
            url.GenerateUrl();

            builder.AppendLine("</li>");
            if (Childs != null)
            {
                foreach (var child in Childs)
                {
                    builder.AppendLine("<ul>");
                    builder.AppendLine(child.Generate(icon, url));
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
