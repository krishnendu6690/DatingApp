using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context; 
        public UsersController(DataContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            //return _context.User.ToList();
            return await _context.User.ToListAsync(); // or return _context.User.ToListAsync().Result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            //return _context.User.Find(id);
            return await _context.User.FindAsync(id);
        }
    }
    

}