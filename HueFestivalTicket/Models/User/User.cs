using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.User
{
    public class User
    {
        [Key]
        public int  IdUser { get; set; }
        public String Email { get; set; } = String.Empty;
        public String Username { get; set; } = String.Empty;

        [JsonProperty("role_list")]
        public string Role { get; set; } = String.Empty;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
