using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {


        private static List<News> news = new List<News>
        {
            new News
            {
                Id = 1,
                Title = "Hôm nay troi dep qua",
                Decriptions = "Hôm nay troi nang to rat dep, phu hop cho cac cap  doi di choi  vao ngay hom nay",
                Date = new DateTime(2023, 5, 15, 10, 30, 0),
                Image_URL = "Anis.png",
                Place = "Quảng Trường 10/3",
                Price = 0,
                Type_Inoff = 0,
                Type_Program = 1,
            },
            new News
            {       
                Id = 2,
                Title = "Hôm kia troi dep qua",
                Decriptions = "Hôm nay troi nang to rat dep, phu hop cho cac cap  doi di choi  vao ngay hom nay",
                Date = new DateTime(2023, 5, 20, 10, 30, 0),
                Image_URL = "Anis.png",
                Place = "Quảng Trường 10/9",
                Price = 15000,
                Type_Inoff = 1,
                Type_Program = 2,
            },
            new News
            {
                Id = 3,
                Title = "Hôm qua troi dep qua",
                Decriptions = "Hôm nay troi nang to rat dep, phu hop cho cac cap  doi di choi  vao ngay hom nay",
                Date = new DateTime(2023, 5, 15, 10, 30, 0),
                Image_URL = "Anis.png",
                Place = "Quảng Trường 10/3",
                Price = 15000,
                Type_Inoff = 1,
                Type_Program = 1,
            },
        };

        [HttpGet]
        public async Task<ActionResult<List<News>>> GetNews()
        {
            return Ok(news);
        }

        //[HttpGet("{Id}")]

        //public async Task<ActionResult<List<News>>> GetNew(int Id)
        //{
        //    var ne = news.Find(i => i.Id == Id);
        //    if (ne == null)
        //    {
        //        return BadRequest("Not Found");
        //    }
        //    return Ok(ne);
        //}
        [HttpGet("{Type_Program}")]

        public async Task<ActionResult<List<News>>> GetTypeProgram(int Type_Program)
        {
            var ne = news.FindAll(i => i.Type_Program == Type_Program);
            if (ne == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(ne);
        }
        [HttpPost]
        public async Task<ActionResult<List<News>>> AddNews(News ne )
        {
            news.Add(ne);
            return Ok(news);
        }

    }

}
