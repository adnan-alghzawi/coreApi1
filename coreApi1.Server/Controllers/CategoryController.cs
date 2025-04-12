using coreApi1.Server.DataService;
using coreApi1.Server.IDataService;
using coreApi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreApi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IDataServicecs _dataService;

        public CategoryController(IDataServicecs dataService)
        {
            _dataService = dataService;
        }

        //read
        [HttpGet("getCateegories")]
        public IActionResult getCategories()
        {
            var categories = _dataService.getCategories();
            return Ok(categories);
        }

        //get category by id
        [HttpGet("getCateegoryById/{id}")]
        public IActionResult getCategoryById(int id)
        {
            //var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            var category=_dataService.getCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }


        // get category by name
        [HttpGet("getCateegoryByName/{name}")]
        public IActionResult getCategoryByName(string name)
        {
            //var categories = _context.Categories.Where(c => c.CategoryName == name).ToList();
            var categories = _dataService.getCategoryByName(name);
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        // GET FIRST CATEGORY
        //[HttpGet("getFirstCategory")]
        //public IActionResult getFirstCategory()
        //{
        //    var category = _context.Categories.Take(1);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(category);
        //}
        //delete category by id
        //[HttpDelete("deleteCategory/{id}")]
        //public bool deleteCategory(int id)
        //{
        //    //var category = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
        //    var category = _dataService.getCategoryById(id);
        //    if (category == null)
        //    {
        //        return false;
        //    }
        //    _context.Categories.Remove(category);
        //    _context.SaveChanges();
        //    return true;
        //}
        [HttpDelete("deleteCategory")]
        public bool deleteCategory(int id)
        {
            var category = _dataService.deleteCategory(id);

            if (category == null)
            {
                return false;
            }
            return true;

        }

    }
}
