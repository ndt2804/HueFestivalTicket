using HueFestivalTicket.Database;
using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.ProgramFes;
using HueFestivalTicket.Models.Support;
using HueFestivalTicket.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;

        }
        [HttpGet("GetAllUser")]
        public async Task<ActionResult<IEnumerable<UserDb>>> getAllUser()
        {
            var userlist = _context.UsersDb.Select(n => new UserDb
            {
                IdUser = n.IdUser,
                Email = n.Email,
                Username = n.Username,
                Role = n.Role,


            }).ToList();

            return Ok(userlist);
        }
        [HttpGet("GetAllUser/{{id}}")]
        public async Task<ActionResult<IEnumerable<UserDb>>> getUserById(int id)
        {
     
                var userID = await _context.UsersDb.Where(n => n.IdUser == id).ToListAsync();

            if (userID == null || userID.Count == 0)
            {
                return NotFound("Not Found");
            }

            return Ok(userID);
        }
        [HttpPut("api/users/{id}")]
        public async Task<ActionResult<UserDb>> UpdateUser(int id, [FromBody] UserDetail updatedUser)
        {
            var user = await _context.UsersDb.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Username = updatedUser.Username;
            user.Email = updatedUser.Email;

            _context.UsersDb.Update(user);
            await _context.SaveChangesAsync();

            return Ok(user);
        }
        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = await _context.UsersDb.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.UsersDb.Remove(user);
            await _context.SaveChangesAsync();

            return Ok("User successfully deleted!");
        }



    }
}
