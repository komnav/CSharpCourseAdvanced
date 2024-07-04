using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public class GeneralMenu : IIcon, IUrl, IMenuName
    {
        public string Icon { get; set; }
        public string Url { get; set; }
        public string MenuName { get; set; }
    }
}
