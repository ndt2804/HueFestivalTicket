using HueFestivalTicket.Models.Menu;
using HueFestivalTicket.Models.SubMenu;

namespace HueFestivalTicket.Models.Places
{
    public class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Image_Place { get; set; }
        public string Sumary { get; set; }
        public string Content { get; set; }
        public int Type_Data { get; set; }
        public SubMenuDto SubMenu { get; set; }

    }
}
