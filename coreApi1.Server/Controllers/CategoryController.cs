using coreApi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreApi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CategoryController( MyDbContext db)
        {
            _context = db;
        }

        //read
        [HttpGet("getCateegories")]
        public IActionResult getCategories()
        {
            var categories=_context.Categories.ToList();
            return Ok(categories);
        }

        //get category by id
        [HttpGet("getCateegoryById")]
        public IActionResult getCategoryById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }


        // get category by name
        [HttpGet("getCateegoryByName")]
        public IActionResult getCategoryByName(string name)
        {
            var categories = _context.Categories.Where(c => c.CategoryName == name).ToList();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        // GET FIRST CATEGORY
        [HttpGet("getFirstCategory")]
        public IActionResult getFirstCategory()
        {
            var category = _context.Categories.Take(1);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

    }
}
