using Azure.Core;
using HueFestivalTicket.Database;
using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.ProgramFes;
using HueFestivalTicket.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {


        private readonly DataContext _context;
        public NewsController(DataContext context)
        {
            _context = context;

        }
        private static List<News> news = new List<News>();
        private static List<NewsDto> newDto = new List<NewsDto>();




        //[HttpGet, Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsDto>>> GetNews()
        {
            var news = _context.News.Select(n => new NewsDto
            {
                Id = n.Id,
                Title = n.Title,
                Image_URL = n.Image_URL,
                Sumary = n.Sumary,
                Date = n.Date
            }).ToList();

            return Ok(news);
        }
        [HttpGet("DetailNews/{{id}}")]
        public async Task<ActionResult<List<News>>> getDeltailNews(int id)
        {
            var newsDetail = await _context.News.Where(n => n.Id == id).ToListAsync();

            if (newsDetail == null || newsDetail.Count == 0)
            {
                return NotFound("Not Found");
            }

            return Ok(newsDetail);
        }


        [HttpPost("AddNews")]
        public async Task<ActionResult<News>> AddNews(News news)
        {
            var ne = new News
            {
                Title = news.Title,
                Sumary = news.Sumary,
                Image_URL = news.Image_URL,
                Date = DateTime.Now,
                Content = news.Content,
                Author = news.Author,
                Keyword = news.Keyword,
            };

            _context.News.Add(ne);
            await _context.SaveChangesAsync();

            return Ok("News successfully created!");
        }

        [HttpGet("RelatedNews/{id}")]
        public ActionResult<IEnumerable<News>> GetRelatedNews(int id)
        {
            // Lấy bài viết chi tiết
            var detailNews = _context.News.SingleOrDefault(n => n.Id == id);

            if (detailNews == null)
            {
                return NotFound("No news found for the specified ID.");
            }
            // Tách các từ khóa của bài viết chi tiết thành một mảng
            var detailNewsKeywords = detailNews.Keyword.Split(", ");

            // Lấy danh sách các bài viết liên quan
            var relatedNews = _context.News
                .Where(n => n.Id != id && detailNewsKeywords.Contains(n.Keyword))
                .ToList();
            if (relatedNews.Count == 0)
            {
                return NotFound("No related news found.");
            }

            return Ok(relatedNews);
        }

      
    }
}
