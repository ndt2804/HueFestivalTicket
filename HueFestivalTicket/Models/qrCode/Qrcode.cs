using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.qrCode
{
    public class Qrcode
    {
        [Key]
        public int Id { get; set; }
        public string qrcode { get; set; }
    }
}
