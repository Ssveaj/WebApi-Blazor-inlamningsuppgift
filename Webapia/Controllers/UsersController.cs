using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Webapia.Data;
using Webapia.Models.User;
using Webapia.Services;


namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public IConfiguration Configuration { get; }

        public UsersController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUser()
        {
            return await _context.User.Select(user => new UserModel(user)).ToListAsync();
        }
        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUser(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var usermodel = new UserModel(user);
            return usermodel;
        }
        // PUT: api/Users/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<User>> Create([FromBody] UserRegisterModel model)
        {
            if (_context.User.Any(u => u.Email == model.Email))
                return BadRequest();

            byte[] passwordHash;
            byte[] passwordSalt;

            AuthServices.CreatePasswordHash(model.Password, out passwordHash, out passwordSalt);

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = model.Role
            };

            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserLoginModel model)
        {
            var user = await _context.User.FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user == null)
                return BadRequest();

            if (!AuthServices.ValidatePassword(model.Password, user.PasswordHash, user.PasswordSalt))
                return BadRequest();

            var token = AuthServices.GenerateJwtToken(user.Id, Configuration.GetSection("SecretKey").Value);

            return Ok(new { user.Id, user.Email, token, user.Role });
        }
        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }
        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
