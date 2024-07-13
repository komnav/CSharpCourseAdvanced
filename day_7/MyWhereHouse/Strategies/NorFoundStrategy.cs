using MyWhereHouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhereHouse.Strategies
{
    public class NorFoundStrategy : ICommandLineStrategy
    {
        public string Description => throw new NotImplementedException();

        public ConsoleKey StrategyKey => throw new NotImplementedException();

        public void Execute()
        {
            Console.WriteLine("Операция не найден!");
        }
    }
}
