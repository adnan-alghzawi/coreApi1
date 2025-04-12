using coreApi1.Server.IDataService;
using coreApi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreApi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class C1Controller : ControllerBase
    {
        private readonly IdataService _data;

        public C1Controller(IdataService data)
        {
            _data = data;
        }

        //get all categories
        [HttpGet("getCategories")]
        public IActionResult getCategories()
        {
            var categories =  _data.GetAll();
            return Ok(categories);
        }
    }
}
