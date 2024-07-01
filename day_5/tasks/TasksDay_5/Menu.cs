using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class Menu<T>
    {
        public string MenuName { get; set; }
        public List<Menu<string>> Childs { get; set; } = new List<Menu<string>>();
        public Menu(string menuName)
        {
            MenuName = menuName;
        }

        public string Generate()
        {
            string result = $"<li>{MenuName}</li>";

            if (Childs != null)
            {
                result += "<ul>";
                foreach (var item in Childs)
                {
                    result = result + $"<li>{item.MenuName} </li>";
                }
                result = result + "</ul>";
            }
            return result;
        }
    }
}
