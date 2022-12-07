using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        // sve zavisnosti u konstruktoru ce takodje biti kreirane
        private readonly DataContext _context;
        public UsersController(DataContext context )
        {
            _context = context; 
        }

        [AllowAnonymous]
        [HttpGet]
        // task represents an async operation that can be return a value
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();

            return users;
        }

        [HttpGet("{id}")] // nece raditi bez {}
        public async Task<ActionResult<AppUser>> GetUser(int id) 
        {
           return await _context.Users.FindAsync(id);
        }


    }
}