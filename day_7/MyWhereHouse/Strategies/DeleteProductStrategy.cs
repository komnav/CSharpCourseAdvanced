using MyWarehouse.Repository.Abstractions;
using MyWhereHouse.Strategies.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyWhereHouse.Strategies
{
    public class DeleteProductStrategy : ICommandLineStrategy
    {
        IProductRepository _repository;
        public DeleteProductStrategy(IProductRepository repository)
        {
            _repository = repository;
        }

        public ConsoleKey StrategyKey => ConsoleKey.D;

        public string Description => "Удалить продукт";

        public void Execute()
        {

            Console.WriteLine("Какой продукт хотите удалить?");
            Console.Write("Введите название продукта:");
            string nameOfProduct = Console.ReadLine();



            var existingProduct = _repository.ProductGetByName(nameOfProduct);
            if (existingProduct != null)
            {
                _repository.Delete(nameOfProduct);
                Console.WriteLine($"Продукт {nameOfProduct} удален");
            }
        }
    }
}
