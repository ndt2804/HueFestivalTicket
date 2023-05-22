namespace HueFestivalTicket.Models.User
{
    public class User
    {
        public String Username { get; set; } = String.Empty;

        public string Role { get; set; } = String.Empty;

        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
