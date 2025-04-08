using coreApi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace coreApi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MyDbContext _context;
        public ProductController(MyDbContext db)
        {
            _context = db;
        }

        //get all products

        [HttpGet("getProducts")]
        public IActionResult getProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        //get product by id
        [HttpGet("getProductById")]
        public IActionResult getProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // get product by name
        [HttpGet("getProductByName")]
        public IActionResult getProductByName(string name)
        {
            var products = _context.Products.Where(c => c.ProductName == name).ToList();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        // GET FIRST PRODUCT
        [HttpGet("getFirstProduct")]
        public IActionResult getFirstProduct()
        {
            var product = _context.Products.Take(1);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
