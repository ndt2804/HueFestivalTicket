using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.User
{
    public class UserDto
    {
        [Required, EmailAddress]
        public String Email { get; set; } = String.Empty;
        public String Username { get; set; } = String.Empty;
        public String Password { get; set; } = String.Empty;

    }
}
