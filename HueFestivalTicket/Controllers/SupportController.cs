using HueFestivalTicket.Database;
using HueFestivalTicket.Models.Support;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportController : ControllerBase
    {

        private readonly DataContext _context;
        public SupportController(DataContext context)
        {
            _context = context;

        }
        private static List<Support> Supports = new List<Support>();

        [HttpGet("listSupport")]
        public async Task<ActionResult<List<Support>>> getSupport()
        {
            var listSupport = await _context.Support.ToListAsync();
           
            return Ok(listSupport);
        }
        [HttpGet("listSupport/{id}")]
        public async Task<ActionResult<List<Support>>> getDeltailSupport(int id)
        {
            var supportDetail = _context.SupportDetails.SingleOrDefault(sd => sd.Id == id);

            if (supportDetail == null)
            {
                return NotFound();
            }

            return Ok(supportDetail);
        }

        [HttpPost("AddSupport")]
        public async Task<ActionResult<List<Support>>> addSupport( Support support)
        {

            var sup = new Support
            {
                Title = support.Title,
            };

            _context.Support.Add(sup);
            await _context.SaveChangesAsync();

            return Ok("News successfully created!");
        }


    }
}
