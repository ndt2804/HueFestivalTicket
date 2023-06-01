using HueFestivalTicket.Database;
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
        public static User user = new User();

        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;

        }


    }
}
