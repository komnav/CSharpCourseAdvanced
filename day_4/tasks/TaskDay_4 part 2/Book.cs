using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay_4_part_2
{
    public class Book : LibraryItem
    {
        public int Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public override string GetInfo()
        {
            return $"{Title}, {Author}, {Genre}";
        }
        public override string ToString()
        {
            return Title.ToString();
        }
    }
}
