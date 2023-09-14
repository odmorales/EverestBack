using Microsoft.AspNetCore.Mvc;
using Product.Application.Interfaces;
using Product.Application.Models;
using Product.Domain;

namespace Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProduct()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] ProductDTO producto)
        {
            return Ok(_productService.AddProduct(producto));
        }
        [HttpPut]
        public ActionResult<string> Put([FromBody] ProductUpdate producto)
        {
            return Ok(_productService.UpdateProducts(producto));
        }
        [HttpDelete]
        public ActionResult<string> Delete(int productId)
        {
            return Ok(_productService.DeleteProducts(productId));
        }
    }
}
