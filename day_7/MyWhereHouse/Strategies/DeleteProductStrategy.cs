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
        public ConsoleKey StrategyKey => ConsoleKey.D;

        public string Description =>StrategyKey.ToString();

        public void Execute()
        {

            Console.WriteLine("Какой продукт хотите удалить?");
            Console.Write("Введите название продукта:");
            string nameOfProduct = Console.ReadLine();

            Console.WriteLine("Введите кол-во продукта:");
            int newProductQuantity = int.Parse(Console.ReadLine());

            var existingProduct = _repository.ProductGetByName(nameOfProduct);
            if (existingProduct != null)
            {
                if (existingProduct.Quantity == newProductQuantity)
                {
                    _repository.Delete(nameOfProduct);
                    Console.WriteLine("Продукт удален");
                }
            }
            else
            {
                int updateProduct = existingProduct.Quantity - newProductQuantity;
                _repository.UpdateQuantity(nameOfProduct, updateProduct);
                Console.WriteLine($"{newProductQuantity} удален");
            }

        }
    }
}
