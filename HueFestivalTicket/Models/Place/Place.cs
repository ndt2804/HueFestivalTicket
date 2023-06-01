using HueFestivalTicket.Models.Menu;
using HueFestivalTicket.Models.SubMenu;
using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.Places
{
    public class Place
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Image_Place { get; set; }
        public string Sumary { get; set; }
        public string Content { get; set; }
        public int Type_Data { get; set; }
        public SubMenuDto SubMenu { get; set; }

    }
}
