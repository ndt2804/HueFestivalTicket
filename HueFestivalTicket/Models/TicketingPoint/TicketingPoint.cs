using HueFestivalTicket.Models.Menu;
using System.Text.Json.Serialization;

namespace HueFestivalTicket.Models.TicketingPoint
{
    public class TicketingPoint
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Image_Ticketing { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;

        public double phone { get; set; }

    }
}
