using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.Support
{
    public class Support
    {
        [Key]
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
