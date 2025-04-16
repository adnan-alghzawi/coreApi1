using coreApi1.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreApi1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly MyDbContext _Context;
        public UsersController(MyDbContext context)
        {
            _Context = context;
        }

        // register a user 
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromForm] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            // Check if the user already exists
            var existingUser = _Context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (existingUser != null)
            {
                return Conflict("User already exists");
            }
           
            _Context.Users.Add(user);
            _Context.SaveChanges();
            return CreatedAtAction(nameof(Register), new { id = user.Id }, user);
        }


        //get user by email 
        [HttpGet("getUserByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getUserByEmail(string email)
        {
            var user = _Context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // login user
        [HttpPost("login/{email}/{password}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Login(string email, string password)
        {
            var user = _Context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(user);
        }

        
    }
}
