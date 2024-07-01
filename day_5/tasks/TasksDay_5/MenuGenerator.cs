using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class MenuGenerator
    {
        public static Menu<string> GenerateMenu(Menu<string> menu)
        {
            if (menu.Childs == null)
            {
                menu.Childs = new List<Menu<string>>();
            }
            string html = $"<ul>{menu.MenuName}</ul>";
            File.WriteAllText("File.txt", html);
            return menu;
        }
    }
}
