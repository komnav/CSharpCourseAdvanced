using BusinessLayer;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MyWarehouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        [HttpGet("{name}")]
        public IActionResult GetByNmae(string name)
        {
            var product = _productRepository.ProductGetByName(name);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _productRepository.Add(product.Name, product.Quantity);
            return Ok();
        }
        [HttpPut("{name}")]
        public IActionResult UpdateQuentity(string name, [FromBody] int quantity)
        {
            var product = _productRepository.ProductGetByName(name);
            if (product == null)
            {
                return NotFound();
            }
            _productRepository.UpdateQuantity(name, quantity);
            return Ok();
        }
        [HttpDelete("{name}")]
        public IActionResult Delete(string name)
        {
            var product = _productRepository.ProductGetByName(name);
            if (product == null)
            {
                return NotFound();
            }
            _productRepository.Delete(name);
            return Ok();
        }
    }
}
