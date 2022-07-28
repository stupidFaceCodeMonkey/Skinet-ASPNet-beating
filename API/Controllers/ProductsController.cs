using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Products[controller]")]
    public class ProductsController : Controller
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products =await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("id")]
        public async Task<ActionResult<Product>> GetSpecificProduct(int id)
        {
           return Ok(await _context.Products.SingleOrDefaultAsync(p => p.Id == id));
        }
    }
}
