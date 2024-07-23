
namespace BusinessLayer
{
    public interface ICommandLineStrategyResolver
    {
        ICommandLineStrategy GetResolver(ConsoleKey consoleKey);
    }
}
