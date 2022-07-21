using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Products[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public string GetAllProducts()
        {
            return "All of the products";
        }
        [HttpGet("id")]
        public string GetSpecificProduct(int id)
        {
            return $"There is a product with id #{id}";
        }
    }
}
