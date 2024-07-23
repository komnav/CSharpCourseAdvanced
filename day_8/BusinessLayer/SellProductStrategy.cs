using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SellProductStrategy : ICommandLineStrategy
    {
        private readonly IProductRepository _productRepository;
        public SellProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string Description => "Продать продукт";
        public ConsoleKey StrategyKey => ConsoleKey.C;

        public void Execute()
        {
            Console.WriteLine("Продать продукт:");
            Console.Write("Введите название продукта: ");
            string productForSell = Console.ReadLine();

            Console.Write("Введите кол-во продукта:");
            int sellProductQuantity = int.Parse(Console.ReadLine());

            var product = _productRepository.ProductGetByName(productForSell);
            if (product == null)
            {
                Console.WriteLine("Product ne nayden!");
            }
            else
            {
                int newQuantity = product.Quantity - sellProductQuantity;
                _productRepository.UpdateQuantity(productForSell, newQuantity);
            }
        }
    }


}
