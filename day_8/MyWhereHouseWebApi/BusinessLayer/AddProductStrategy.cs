
using DataAccess;

namespace BusinessLayer
{
    public class AddProductStrategy : ICommandLineStrategy
    {
        private readonly IProductRepository _productRepository;

        public AddProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string Description => "Добавить новый продукт";

        public ConsoleKey StrategyKey => ConsoleKey.B;

        public void Execute()
        {
            Console.WriteLine("Добавить продукт:");
            Console.Write("Введите название продукта: ");
            string newProduct = Console.ReadLine();

            Console.Write("Введите кол-во продукта:");
            int newProductQuantity = int.Parse(Console.ReadLine());

            var existingProduct = _productRepository.ProductGetByName(newProduct);
            if (existingProduct != null)
            {
                _productRepository.Add(newProduct, newProductQuantity);
            }
            else
            {
                int newQuantity = existingProduct.Quantity + newProductQuantity;
                _productRepository.UpdateQuantity(newProduct, newQuantity);
            }
        }
    }
}
