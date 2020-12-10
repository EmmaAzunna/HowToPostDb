using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HowToPostDb.Data;
using HowToPostDb.Model;

namespace HowToPostDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDb>>> GetUserDb()
        {
            return await _context.UserDb.ToListAsync();
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDb>> GetUserDb(int? id)
        {
            var userDb = await _context.UserDb.FindAsync(id);

            if (userDb == null)
            {
                return NotFound();
            }

            return userDb;
        }

        // PUT: api/Employee/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserDb(int? id, UserDb userDb)
        {
            if (id != userDb.EmpId)
            {
                return BadRequest();
            }

            _context.Entry(userDb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDbExists(id))
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

        // POST: api/Employee
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<UserDb>> PostUserDb(UserDb userDb)
        {
            _context.UserDb.Add(userDb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserDb", new { id = userDb.EmpId }, userDb);
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserDb>> DeleteUserDb(int? id)
        {
            var userDb = await _context.UserDb.FindAsync(id);
            if (userDb == null)
            {
                return NotFound();
            }

            _context.UserDb.Remove(userDb);
            await _context.SaveChangesAsync();

            return userDb;
        }

        private bool UserDbExists(int? id)
        {
            return _context.UserDb.Any(e => e.EmpId == id);
        }
    }
}
