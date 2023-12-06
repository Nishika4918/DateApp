using Microsoft.AspNetCore.Mvc;
using API.Models;
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
       public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _context.Users;
            return users;
        }

         [HttpGet("{id}")]
       public ActionResult<User> GetUser(int id)
        {
            return _context.Users.Find(id);
        }

    }
}