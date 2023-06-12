using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.qrCode
{
    public class Qrcode
    {
        [Required]
        public string qrcode { get; set; }
    }
}
