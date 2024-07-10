using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhereHouse.Strategies.Abstractions
{
    public interface ICommandLineStrategy
    {
        ConsoleKey StrategyKey { get; }
        void Execute();
    }
}
