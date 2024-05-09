using DataAccess.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
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
        public IActionResult Get()
        {
            
            Product p = new Product() { Id = 1, CreatedAt = DateTime.Now, Name = "Laptop", Price = 1000 };
            _productRepository.Create(p);


            return Ok(_productRepository.GetAll());
        }
    }
}
