using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.User
{
    public class UserDto
    {
        [Required]
        public String Username { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;

    }
}
