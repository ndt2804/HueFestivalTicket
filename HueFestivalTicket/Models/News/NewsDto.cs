using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.News
{
    public class NewsDto
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;

        public String Sumary { get; set; } = String.Empty;
        public String Image_URL { get; set; } = String.Empty;

        public DateTime Date { get; set; }


    }
}
