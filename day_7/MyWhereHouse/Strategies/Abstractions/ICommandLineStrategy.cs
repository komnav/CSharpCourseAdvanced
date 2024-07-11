using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhereHouse.Strategies.Abstractions
{
    public interface ICommandLineStrategy
    {
        public string Description { get;}
        ConsoleKey StrategyKey { get; }
        void Execute();
    }
}
