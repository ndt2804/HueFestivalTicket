using HueFestivalTicket.Database;
using HueFestivalTicket.Models.ProgramFes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramFesController : ControllerBase
    {

        private readonly DataContext _context;
        public ProgramFesController(DataContext context)
        {
            _context = context;

        }
        private static List<ProgramFes> programFes = new List<ProgramFes>();


        //[HttpGet, Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<List<ProgramFes>>> getProgramFes()
        {
            var listProgram = await _context.ProgramFes.ToListAsync();

            return Ok(listProgram);
        }

        [HttpPost("addProgram")]
        public async Task<ActionResult<ProgramFes>> AddNews(ProgramFesDto programs)
        {
            var program = new ProgramFes
            {
                Title = programs.Title,
                Decriptions = programs.Decriptions,
                Image_URL = programs.Image_URL,
                Date = DateTime.Now,
                Place = programs.Place,
                Price = programs.Price,
                Type_Program = programs.Type_Program,
                Type_Inoff = programs.Type_Inoff,
            };

            _context.ProgramFes.Add(program);
            await _context.SaveChangesAsync();

            return Ok("Programs successfully created!");
        }
        [HttpPut("updateProgram/{id}")]
        public async Task<ActionResult<ProgramFes>> UpdateProgram(int id, ProgramFesDto updatedProgram)
        {
            var program = await _context.ProgramFes.FindAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            program.Title = updatedProgram.Title;
            program.Decriptions = updatedProgram.Decriptions;
            program.Image_URL = updatedProgram.Image_URL;
            program.Place = updatedProgram.Place;
            program.Price = updatedProgram.Price;
            program.Type_Program = updatedProgram.Type_Program;
            program.Type_Inoff = updatedProgram.Type_Inoff;

            _context.ProgramFes.Update(program);
            await _context.SaveChangesAsync();

            return Ok(program);
        }
        [HttpDelete("DeleteProgram/{id}")]
        public async Task<ActionResult> DeleteProgram(int id)
        {
            var program = await _context.ProgramFes.FindAsync(id);
            if (program == null)
            {
                return NotFound();
            }

            _context.ProgramFes.Remove(program);
            await _context.SaveChangesAsync();

            return Ok("Program successfully deleted!");
        }

        [HttpGet("{Type_Program}")]
        public async Task<ActionResult<List<ProgramFes>>> GetTypeProgram(int Type_Program)
        {
            var program = await _context.ProgramFes.Where(n => n.Type_Program == Type_Program).ToListAsync();

            if (program == null || program.Count == 0)
            {
                return NotFound("Not Found");
            }

            return Ok(program);
        }

        [HttpGet("programbyDate")]
        public ActionResult<Dictionary<string, List<ProgramFes>>> GetProgramsByDate()
        {
            // Lấy danh sách chương trình từ cơ sở dữ liệu
            var listProgram = _context.ProgramFes.ToList(); 

            // Nhóm danh sách chương trình theo ngày tháng trong bộ nhớ
            var programsByDate = listProgram
                .GroupBy(ne => ne.Date.Date.ToString("dd/MM"))
                .ToDictionary(g => g.Key, g => g.ToList());

            if (programsByDate.Count == 0)
            {
                return NotFound("No programs found.");
            }

            return Ok(programsByDate);
        }


        [HttpGet("program/{date}")]
        public ActionResult<Dictionary<string, List<ProgramFes>>> GetProgramsByDateAndType(DateTime date)
        {
            // Lấy danh sách chương trình theo ngày và loại
            Dictionary<string, List<ProgramFes>> programsByType = _context.ProgramFes
                .Where(programFes => programFes.Date.Date == date.Date)
                .GroupBy(news => news.Type_Inoff.ToString())
                .ToDictionary(g => g.Key, g => g.ToList());

            if (programsByType.Count == 0)
            {
                return NotFound("No programs found for the specified date.");
            }

            return Ok(programsByType);
        }

        [HttpGet("program/detail/{id}")]
        public async Task<ActionResult<List<ProgramFes>>> getProgramById(int id)
        {
            var program = await _context.ProgramFes.Where(n => n.Id == id).ToListAsync();
            if (program == null || program.Count == 0)
            {
                return NotFound("Not Found");
            }

            return Ok(program);

        }



    }
}
