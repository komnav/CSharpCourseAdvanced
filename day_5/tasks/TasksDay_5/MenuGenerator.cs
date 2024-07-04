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
    public class MenuGenerator<T> where T : class, IIcon, IMenuName, IUrl
    {
        private static string GenerateMenu(Menu<T> menu, IIcon icon, IUrl url)
        {

            if (menu.Childs == null)
            {
                menu.Childs = new List<Menu<T>>();
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<ul>");
            stringBuilder.AppendLine(menu.Generate(icon, url));
            stringBuilder.AppendLine("<ul>");
            return stringBuilder.ToString();
        }
        public static Menu<T> GenerateMenuToFile(Menu<T> menu, IIcon icon, IUrl url)
        {

            string html = GenerateMenu(menu, icon, url);
            File.WriteAllText("index.html", html);
            return menu;
        }
    }
}
