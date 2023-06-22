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
        [HttpPost("addTicketPoint")]
        public async Task<ActionResult<TicketingPoint>> AddPlaceTicket(TicketPointDto ticketingPoint)
        {
            var ticketPoint = new TicketingPoint
            {
                Title = ticketingPoint.Title,
                address = ticketingPoint.address,
                Image_Ticketing = ticketingPoint.Image_Ticketing,
                phone = ticketingPoint.phone,
            };

            _context.TicketingPoint.Add(ticketPoint);
            await _context.SaveChangesAsync();

            return Ok("addTicketPoint successfully created!");
        }

        [HttpGet("priceTicket")]
        public async Task<ActionResult<IEnumerable<ProgramFes>>> GetPriceTicket()
        {
            var priceTickets = await _context.ProgramFes
                .Where(n => n.Type_Inoff == 2) // Lọc các vé có type_Inoff = 2
                .Select(n => new ProgramPriceTicket
                {
                    Title = n.Title,
                    Price = n.Price
                })
                .ToListAsync();

            return Ok(priceTickets);
        }

    }
}
