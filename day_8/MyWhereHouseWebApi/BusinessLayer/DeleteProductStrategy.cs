using BusinessLayer.Repositories;

namespace BusinessLayer
{
    public class DeleteProductStrategy : ICommandLineStrategy
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public string Description => "Удалить продукт";

        public ConsoleKey StrategyKey => ConsoleKey.D;

        public void Execute()
        {
            Console.WriteLine("Какой продукт хотите удалить?");
            Console.Write("Введите название продукта:");
            string nameOfProduct = Console.ReadLine();



            var existingProduct = _productRepository.ProductGetByName(nameOfProduct);
            if (existingProduct != null)
            {
                _productRepository.Delete(nameOfProduct);
                Console.WriteLine($"Продукт {nameOfProduct} удален");
            }
        }
    }
}
