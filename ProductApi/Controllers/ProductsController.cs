using Microsoft.AspNetCore.Mvc;
using ProductApi.Interfaces;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            var createdProduct = _productService.CreateProduct(product);

            return StatusCode(StatusCodes.Status201Created, createdProduct);
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productService.GetProduct(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, Product updatedProduct)
        {
            if (!_productService.UpdateProduct(id, updatedProduct))
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            if (!_productService.DeleteProduct(id))
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
