using coreApi1.Server.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreApi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly coreApi1.Server.IDataService.IDataServicecs _dataService;

        public ValuesController(coreApi1.Server.IDataService.IDataServicecs dataService)
        {
            _dataService = dataService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromForm] RegisterDTO registerDTO)
        {
            if (registerDTO == null)
            {
                return BadRequest();
            }
            var result = _dataService.Register(registerDTO);
            
            return Ok(result);
        }
    }
}
