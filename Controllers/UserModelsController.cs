using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectCDN_API.Data;
using ProjectCDN_API.Models;

namespace ProjectCDN_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModelsController : ControllerBase
    {
        private readonly UserModelsContext _context;

        public UserModelsController(UserModelsContext context)
        {
            _context = context;
        }

        // GET: UserModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
        {
            return await _context.UserModel.ToListAsync();
        }

        // GET: UserModels/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUsersById(long id)
        {
            var user = await _context.UserModel.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return user;
            }
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // <snippet_Update>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(long id, UserModel userModel)
        {
            if (id != userModel.Id)
            {
                return BadRequest();
            }

            var user = await _context.UserModel.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserName = userModel.UserName;
            user.EmailAddress = userModel.EmailAddress;
            user.PhoneNumber = userModel.PhoneNumber;
            user.SkillSets = userModel.SkillSets;
            user.Hobbies = userModel.Hobbies;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!UserModelExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: UserModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<ActionResult<UserModel>> PostUsers(UserModel userModel)
        {
            if (userModel == null)
            {
                return BadRequest();
            }

            _context.UserModel.Add(userModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsers), new { id = userModel.Id }, userModel);
        }

        // GET: UserModels/Delete/5
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteUser(long id)
        {
            var user = await _context.UserModel.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.UserModel.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserModelExists(long id)
        {
            return _context.UserModel.Any(e => e.Id == id);
        }
    }
}
