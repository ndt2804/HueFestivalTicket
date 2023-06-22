using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.User
{
    public class UserDb
    {
        [Key]
        public int IdUser { get; set; }
        public String Email { get; set; } = String.Empty;
        public String Username { get; set; } = String.Empty;

        public string Role { get; set; } = "User";
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }

        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }

    }
}
