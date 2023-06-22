using HueFestivalTicket.Database;
using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.ProgramFes;
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
        public async Task<ActionResult<IEnumerable<Support>>> getSupport()
        {
            var support = _context.Support.Select(n => new SupportDetail
            {
                Id = n.Id,
                Title = n.Title,

            }).ToList();

            return Ok(support);
        }

        [HttpGet("listSupport/{id}")]
        public async Task<ActionResult<List<Support>>> getDeltailSupport(int id)
        {
            var supportDetail = _context.Support.SingleOrDefault(sd => sd.Id == id);

            if (supportDetail == null)
            {
                return NotFound();
            }

            return Ok(supportDetail);
        }

        [HttpPost("AddSupport")]
        public async Task<ActionResult<List<Support>>> addSupport(SupportDto support)
        {

            var sup = new Support
            {
                Title = support.Title,
                Content = support.Content,
            };

            _context.Support.Add(sup);
            await _context.SaveChangesAsync();

            return Ok("News successfully created!");
        }


    }
}
