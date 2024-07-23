using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CloseApplicationStrategy : ICommandLineStrategy
    {
        public string Description => "Закрыт программу";
        public ConsoleKey StrategyKey => ConsoleKey.E;
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
