using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay_4_part_2
{
    public class Paper : LibraryItem
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }

        public override string GetInfo()
        {
            return $"{Date}, {Name}, {Publisher}";
        }
        public override string ToString()
        {
            return Name;
        }
    }

}
