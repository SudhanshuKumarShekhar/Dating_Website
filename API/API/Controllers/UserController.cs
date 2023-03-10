using API.Data;
using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context)
        {
            _context = context;
        }
        // GET: api/UserDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUserDetails()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
