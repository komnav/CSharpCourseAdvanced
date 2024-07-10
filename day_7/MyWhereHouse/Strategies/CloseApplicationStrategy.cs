using MyWarehouse.Repository.Abstractions;
using MyWhereHouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse.Strategies
{
    public class CloseApplicationStrategy : ICommandLineStrategy
    {
        public ConsoleKey StrategyKey => ConsoleKey.E;

        public void Execute()
        {
            if (StrategyKey == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }


        }
    }
}

