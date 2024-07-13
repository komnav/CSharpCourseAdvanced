using MyWarehouse.Repositories;
using MyWarehouse.Repository.Abstractions;
using MyWhereHouse.Strategies.Abstractions;
using MyWarehouse.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse
{
    public class Application
    {
        ICommandLineStrategyResolver _resolver;
        IEnumerable<ICommandLineStrategy> _strategys;
        public Application(ICommandLineStrategyResolver commandLineStrategy, IEnumerable<ICommandLineStrategy> commandLines)
        {
            _resolver = commandLineStrategy;
            _strategys = commandLines;
        }

        public void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            bool isContinue = true;

            while (isContinue)
            {
                Console.Clear();
                ShowMenu();

                ConsoleKeyInfo userInput = Console.ReadKey(true);
                var strategy = _resolver.GetResolver(userInput.Key);
                strategy.Execute();

                Console.WriteLine("Нажмите для продолжения.");
                Console.ReadKey();
            }
        }

        private void ShowMenu()
        {
            foreach (var strategy in _strategys)
            {
                Console.WriteLine($"{strategy.StrategyKey})  {strategy.Description}");
            }
            //Console.WriteLine("Выберите действие: \n" +
            //    "а) Показать список продуктов\n" +
            //    "b) Добавить новый продукт\n" +
            //    "c) Продать продукт\n" +
            //    "d)Удалить продукт\n" +
            //    "Esc) Выйти из программы\n");
        }
    }
}