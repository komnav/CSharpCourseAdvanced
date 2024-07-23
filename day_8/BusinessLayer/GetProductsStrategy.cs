using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GetProductsStrategy : ICommandLineStrategy
    {
        private readonly IProductRepository _productRepository;
        public GetProductsStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string Description => "Показать продукт";
        public ConsoleKey StrategyKey => ConsoleKey.A;



        public void Execute()
        {
            Console.WriteLine("Список продуктов:");
            var products = _productRepository.GetAll();
            foreach (var productForRead in products)
            {
                Console.WriteLine(productForRead);
            }
        }
    
    }
}
