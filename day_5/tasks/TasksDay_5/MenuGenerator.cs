using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{/*
  * <ul>
<li>Напитки</li>
<ul>
<li>Чай</li>

<li>Сок</li>

</ul>
</ul>
  */
    public class MenuGenerator
    {
        private static string GenerateMenu<T>(Menu<T> menu)
        {
            if (menu.Childs == null)
            {
                menu.Childs = new List<Menu<T>>();
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<ul>");
            stringBuilder.AppendLine(menu.Generate());
            stringBuilder.AppendLine("<ul>");
            return stringBuilder.ToString();
        }
        public static Menu<T> GenerateMenuToFile<T>(Menu<T> menu)
        {

            string html = GenerateMenu(menu);
            File.WriteAllText("index.html", html);
            return menu;
        }
    }
}
