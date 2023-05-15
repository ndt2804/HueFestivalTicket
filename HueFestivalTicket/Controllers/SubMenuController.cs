using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.Places;
using HueFestivalTicket.Models.SubMenu;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubMenuController : ControllerBase
    {
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
                Type_Data = 2,
                Type_Id_Menu=1,
            },
            new SubMenu
            {
                Id = 3,
                Title = "Làng Nghề",
                Image_Menu = "Anis.png",
                Type_Data = 3,
                Type_Id_Menu=1,
            },
            new SubMenu
            {
                Id = 4,
                Title = "Di tích lịch sử",
                Image_Menu = "Anis.png",
                Type_Data = 4,
                Type_Id_Menu=1,
            },
        };


        private static List<Place> place = new List<Place>
        {
            new Place
            {   Id= 1,
                Title  = "Chùa Từ Hiếu",
                Sumary = "Tọa lạc trên trung tâm thành phố Huế khoảng 5km về phía tây",
                Content = "Năm 1843, sau khi từ chức Tăng Cang Giác Hoàng Quốc Tự và trao quyền điều hành chùa Bảo Quốc cho pháp đệ là Nhất Niệm, Hòa thượng Nhất Định đã đến đây khai sơn, dựng Thảo Am An Dưỡng để tịnh tu và nuôi dưỡng mẹ già [1].Hòa thượng Nhất Định nổi tiếng là người con có hiếu, tương truyền có lần mẹ già bị bệnh rất nặng, hàng ngày ông lo thuốc thang nhưng bà vẫn không khỏi. Có người ái ngại khuyên ông nên mua thêm thịt cá để tẩm bổ cho mẹ, có làm được điều đó mới mong bà chóng hồi sức. Nghe xong, mặc thiên hạ đàm tiếu chê bai, thiền sư vẫn chống gậy băng rừng lội bộ xuống chợ cách đó hơn 5 km để mua cá mang về nấu cháo cho mẹ già ăn. Câu chuyện vang đến tai Tự Đức vốn là vị vua rất hiếu thảo với mẹ, vua rất cảm phục trước tấm lòng của sư Nhất Định nên ban cho Sắc tứ Từ Hiếu tự. Chùa được mang tên Từ Hiếu từ đó.",
                Image_Place = "Anis.png",
                Type_Data = 1,
            },
             new Place
            {
                 Id= 2,
                Title  = "Chùa Từ Hiếu",
                Sumary = "Tọa lạc trên trung tâm thành phố Huế khoảng 5km về phía tây",
                Content = "Năm 1843, sau khi từ chức Tăng Cang Giác Hoàng Quốc Tự và trao quyền điều hành chùa Bảo Quốc cho pháp đệ là Nhất Niệm, Hòa thượng Nhất Định đã đến đây khai sơn, dựng Thảo Am An Dưỡng để tịnh tu và nuôi dưỡng mẹ già [1].Hòa thượng Nhất Định nổi tiếng là người con có hiếu, tương truyền có lần mẹ già bị bệnh rất nặng, hàng ngày ông lo thuốc thang nhưng bà vẫn không khỏi. Có người ái ngại khuyên ông nên mua thêm thịt cá để tẩm bổ cho mẹ, có làm được điều đó mới mong bà chóng hồi sức. Nghe xong, mặc thiên hạ đàm tiếu chê bai, thiền sư vẫn chống gậy băng rừng lội bộ xuống chợ cách đó hơn 5 km để mua cá mang về nấu cháo cho mẹ già ăn. Câu chuyện vang đến tai Tự Đức vốn là vị vua rất hiếu thảo với mẹ, vua rất cảm phục trước tấm lòng của sư Nhất Định nên ban cho Sắc tứ Từ Hiếu tự. Chùa được mang tên Từ Hiếu từ đó.",
                Image_Place = "Anis.png",
                Type_Data = 1,
            },
              new Place
            {
                  Id= 3,
                Title  = "Chùa Từ Hiếu",
                Sumary = "Tọa lạc trên trung tâm thành phố Huế khoảng 5km về phía tây",
                Content = "Năm 1843, sau khi từ chức Tăng Cang Giác Hoàng Quốc Tự và trao quyền điều hành chùa Bảo Quốc cho pháp đệ là Nhất Niệm, Hòa thượng Nhất Định đã đến đây khai sơn, dựng Thảo Am An Dưỡng để tịnh tu và nuôi dưỡng mẹ già [1].Hòa thượng Nhất Định nổi tiếng là người con có hiếu, tương truyền có lần mẹ già bị bệnh rất nặng, hàng ngày ông lo thuốc thang nhưng bà vẫn không khỏi. Có người ái ngại khuyên ông nên mua thêm thịt cá để tẩm bổ cho mẹ, có làm được điều đó mới mong bà chóng hồi sức. Nghe xong, mặc thiên hạ đàm tiếu chê bai, thiền sư vẫn chống gậy băng rừng lội bộ xuống chợ cách đó hơn 5 km để mua cá mang về nấu cháo cho mẹ già ăn. Câu chuyện vang đến tai Tự Đức vốn là vị vua rất hiếu thảo với mẹ, vua rất cảm phục trước tấm lòng của sư Nhất Định nên ban cho Sắc tứ Từ Hiếu tự. Chùa được mang tên Từ Hiếu từ đó.",
                Image_Place = "Anis.png",
                Type_Data = 1,
            },
               new Place
            {
                Id= 4,
                Title  = "Chùa Từ Hiếu",
                Sumary = "Tọa lạc trên trung tâm thành phố Huế khoảng 5km về phía tây",
                Content = "Năm 1843, sau khi từ chức Tăng Cang Giác Hoàng Quốc Tự và trao quyền điều hành chùa Bảo Quốc cho pháp đệ là Nhất Niệm, Hòa thượng Nhất Định đã đến đây khai sơn, dựng Thảo Am An Dưỡng để tịnh tu và nuôi dưỡng mẹ già [1].Hòa thượng Nhất Định nổi tiếng là người con có hiếu, tương truyền có lần mẹ già bị bệnh rất nặng, hàng ngày ông lo thuốc thang nhưng bà vẫn không khỏi. Có người ái ngại khuyên ông nên mua thêm thịt cá để tẩm bổ cho mẹ, có làm được điều đó mới mong bà chóng hồi sức. Nghe xong, mặc thiên hạ đàm tiếu chê bai, thiền sư vẫn chống gậy băng rừng lội bộ xuống chợ cách đó hơn 5 km để mua cá mang về nấu cháo cho mẹ già ăn. Câu chuyện vang đến tai Tự Đức vốn là vị vua rất hiếu thảo với mẹ, vua rất cảm phục trước tấm lòng của sư Nhất Định nên ban cho Sắc tứ Từ Hiếu tự. Chùa được mang tên Từ Hiếu từ đó.",
                Image_Place = "Anis.png",
                Type_Data = 1,
            },
        };
        [HttpGet]
        public IActionResult GetPlaceWithSubMenu()
        {
            var placeWithSubMenu = subMenu.Select(m => new {
                m.Id,
                m.Title,
                m.Image_Menu,
                m.Type_Data,
                Place = place
                    .Where(sm => sm.Type_Data == m.Type_Data)
                    .Select(sm => new {
                        sm.Id,
                        sm.Title,
                        sm.Image_Place,
                        sm.Type_Data,
                        sm.Sumary,
                    })
                    .ToList()
            }).ToList();

            return Ok(placeWithSubMenu);
        }
    }
}
