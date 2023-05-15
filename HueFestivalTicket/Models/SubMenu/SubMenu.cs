using HueFestivalTicket.Models.Menu;
using System.Text.Json.Serialization;

namespace HueFestivalTicket.Models.SubMenu
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Image_Menu { get; set; } = string.Empty;

        public int Type_Data { get; set; }

        public MenuDto Menu { get; set; }
        public int Type_Id_Menu { get; set; }

        [JsonPropertyName("Place")]
        public List<string> Place { get; set; }

    }
}
