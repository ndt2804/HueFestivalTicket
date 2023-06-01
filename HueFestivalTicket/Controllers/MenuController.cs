using HueFestivalTicket.Models.Menu;
using HueFestivalTicket.Models.Places;
using HueFestivalTicket.Models.SubMenu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {   

        private static List<Menu> menu = new List<Menu>
        {
            new Menu
            {
                Id = 1,
                Title = "Điểm tham quan",
                Image_Menu = "Anis.png",
                Type_Data = 1,

            },
            new Menu
            {
                Id = 2,
                Title = "Mua vé",
                Image_Menu = "Anis.png",
                Type_Data = 2,
            },
            new Menu
            {
                Id = 3,
                Title = "Lưu trữ",
                Image_Menu = "Anis.png",
                Type_Data = 3
            },
            new Menu
            {
                Id = 4,
                Title = "Ẩm thực",
                Image_Menu = "Anis.png",
                Type_Data = 4
            },
        };
        private static List<SubMenu> subMenu = new List<SubMenu>
        {
            new SubMenu
            {
                Id = 1,
                Title = "Cung Đình Huế",
                Image_Menu = "Anis.png",
                Type_Data = 1,
                Type_Id_Menu=1,


    },
            new SubMenu
            {
                Id = 2,
                Title = "Đại Nội",
                Image_Menu = "Anis.png",
                Type_Data = 1,
                Type_Id_Menu=1,

            },
            new SubMenu
            {
                Id = 3,
                Title = "Làng Nghề",
                Image_Menu = "Anis.png",
                Type_Data = 1,
                Type_Id_Menu=1,

            },
            new SubMenu
            {
                Id = 4,
                Title = "Di tích lịch sử",
                Image_Menu = "Anis.png",
                Type_Data = 1,
                Type_Id_Menu=1,

            },
        };

        [HttpGet]

        //public ActionResult<IEnumerable<Menu>> GetMenuWithSubMenu()
        //{
        //    var result = menu.Select(m => new Menu
        //    {
        //        Id = m.Id,
        //        Title = m.Title,
        //        Image_Menu = m.Image_Menu,
        //        Type_Data = m.Type_Data,
        //        SubMenu = subMenu.Where(sm => sm.Type_Id_Menu == m.Id).Select(sm => sm.Title).ToList()
        //    }).ToList();

        //    return Ok(result);
        //}
        public IActionResult GetMenuWithSubMenu()
        {
            var result = menu.Select(m => new {
                m.Id,
                m.Title,
                m.Image_Menu,
                m.Type_Data,
                SubMenu = subMenu
                    .Where(sm => sm.Type_Id_Menu == m.Id)
                    .Select(sm => new {
                        sm.Id,
                        sm.Title,
                        sm.Image_Menu,
                        sm.Type_Data
                    })
                    .ToList()
            }).ToList();

            return Ok(result);
        }

    }
}
