

namespace BusinessLayer
{
    public class NotFoundStrategy : ICommandLineStrategy
    {
        public string Description => "Операция не найдена";

        public ConsoleKey StrategyKey => ConsoleKey.NoName;

        public void Execute()
        {
            Console.WriteLine("Операция не найдена!");
        }
    }
}