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
                    Title = "Hôm nay troi dep qua",
                    Decriptions = "Hôm nay troi nang to rat dep, phu hop cho cac cap  doi di choi  vao ngay hom nay",
                    Image_URL = "Anis.png",
                    Type_Program = 1,
            },
              new News
            {
                    Title = "Hôm nay troi dep qua",
                    Decriptions = "Hôm nay troi nang to rat dep, phu hop cho cac cap  doi di choi  vao ngay hom nay",
                    Image_URL = "Anis.png",
                    Type_Program = 2,
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<News>>> GetNews()
        {
            return Ok(news);
        }
        [HttpGet("{type_program}")]

        public async Task<ActionResult<List<News>>> GetNew(int type_program)
        {
            var ne = news.Find(i => i.Type_Program == type_program);
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
