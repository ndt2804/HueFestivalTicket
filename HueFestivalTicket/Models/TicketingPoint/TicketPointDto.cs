namespace HueFestivalTicket.Models.TicketingPoint
{
    public class TicketPointDto
    {
        public string Title { get; set; } = string.Empty;

        public string Image_Ticketing { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;

        public double phone { get; set; } = double.MaxValue;
    }
}
