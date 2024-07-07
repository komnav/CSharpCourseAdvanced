using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDay_5
{
    public interface IMenu<T> where T : IMenu<T>
    {
        string Generate();
        List<T> Childs { get; }
    }
}
