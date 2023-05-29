using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.User
{
    public class UserLogin
    {
        [Required, EmailAddress]
        public String Email { get; set; } = String.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
