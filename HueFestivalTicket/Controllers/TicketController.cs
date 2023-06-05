using HueFestivalTicket.Database;
using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.ProgramFes;
using HueFestivalTicket.Models.TicketingPoint;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;


namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly DataContext _context;
        public TicketController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketingPoint>>> getPlaceTicket()
        {
            var placeTicket = _context.TicketingPoint.Select(n => new TicketingPoint
            {
                Id = n.Id,
                Title = n.Title,
                Image_Ticketing = n.Image_Ticketing,
                address = n.address,
                phone = n.phone,
            }).ToList();

            return Ok(placeTicket);
        }
        [HttpGet("priceTicket")]
        public async Task<ActionResult<IEnumerable<ProgramFes>>> GetPriceTicket()
        {
            var priceTickets = await _context.ProgramFes
                .Where(n => n.Type_Inoff == 1) // Lọc các vé có type_Inoff = 1
                .Select(n => new ProgramFes
                {
                    Id = n.Id,
                    Title = n.Title,
                    Price = n.Price
                })
                .ToListAsync();

            return Ok(priceTickets);
        }

    }
}
