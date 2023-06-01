using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HueFestivalTicket.Models.Menu
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Image_Menu { get; set; }

        public int Type_Data { get; set; }

        [JsonPropertyName("SubMenu")]
        public List<string> SubMenu { get; set; }

    }
}
