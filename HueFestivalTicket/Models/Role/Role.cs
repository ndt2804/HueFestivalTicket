using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.Role
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        public string RoleName { get; set; } = string.Empty;
     
    }
}
