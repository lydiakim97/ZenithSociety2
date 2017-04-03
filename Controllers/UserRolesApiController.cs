using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ZenithWebsite.Models;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;

namespace ZenithWebsite.Controllers
{
    [Produces("application/json")]
    [Route("api/UsersApi")]
    public class UserRolesApiController : Controller
    {
        private readonly ZenithContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesApiController(ZenithContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }


        // GET: api/UsersApi
        [HttpGet]
        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.Users.Include(r => r.Roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = await _context.Users.Include(r => r.Roles).SingleOrDefaultAsync(m => m.UserName == id);

            if (user == null)
            {
                return BadRequest();
            }


            if (id != user.UserName)
            {
                return BadRequest();
            }

            var userroleId = user.Roles.Select(x => x.RoleId);
            var admin = user.Roles.Select(x => x.RoleId == "2258f9b7-6174-4dff-9232-7a4df2675bb7");
            var member = user.Roles.Select(x => x.RoleId == "2cc7ae15-da98-4168-beea-a872b678f447");
            var guest = user.Roles.Select(x => x.RoleId == "f95df633-e6bc-4f9e-b883-7ed7d84f7a34");

            if (admin.Contains(true) && member.Contains(true) && guest.Contains(true))
            {
                return Content("[\"Admin\", \"Member\", \"Guest\"]");
            } else if (admin.Contains(true) && guest.Contains(true))
            {
                return Content("[\"Admin\", \"Guest\"]");
            } else if (member.Contains(true) && guest.Contains(true))
            {
                return Content("[\"Member\", \"Guest\"]");
            }
            else if (admin.Contains(true) && member.Contains(true))
            {
                return Content("[\"Admin\", \"Member\"]");
            }
            else if (admin.Contains(true))
            {
                return Content("[\"Admin\"]");
            }
            else if (member.Contains(true))
            {
                return Content("[\"Member\"]");
            }
            else if (guest.Contains(true))
            {
                return Content("[\"Guest\"]");
            }

            return NotFound();
        }

 


        // PUT: api/UsersApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] string id, [FromBody] ApplicationUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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


        // POST: api/UsersApi
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostUser([FromBody] ApplicationUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(user);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserExists(user.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/UsersApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationUser user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}