using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DateAppContext _context;
        public UserController(DateAppContext context){
            _context = context;
        }

       [HttpGet]
       public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await  _context.Users.ToListAsync();
            return users;
        }

         [HttpGet("{id}")]
       public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

    }
}