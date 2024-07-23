

namespace BusinessLayer
{
    public interface ICommandLineStrategy
    {
        string Description { get; }
        ConsoleKey StrategyKey { get; }
        void Execute();
    }
}
