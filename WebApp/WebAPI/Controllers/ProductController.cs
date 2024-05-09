using DataAccess.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            IQueryable<Product> products = _productRepository.GetAll();
            return Ok(products);
        }
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            Product product1 = new Product() { Name = "Laptop", Price = 3000 };
            Product product2 = new Product() { Name = "Kamera", Price = 500 };
            Product product3 = new Product() { Name = "Çanta", Price = 100 };

            await _productRepository.Create(product1);
            await _productRepository.Create(product2);
            await _productRepository.Create(product3);

            return Ok("Ürünler eklendi");
        }
    }
}
