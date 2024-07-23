using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CommandLineStrategyResolver : ICommandLineStrategyResolver
    {
        private readonly IEnumerable<ICommandLineStrategy> _strategies;

        public CommandLineStrategyResolver(IEnumerable<ICommandLineStrategy> strategies)
        {
            _strategies = strategies;
        }

        public ICommandLineStrategy GetResolver(ConsoleKey consoleKey)
        {
            var strategy = _strategies.FirstOrDefault(s => s.StrategyKey == consoleKey);
            return strategy;
        }
    }
}
