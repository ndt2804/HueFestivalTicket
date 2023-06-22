using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.News
{
    public class NewsDto
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; }

        public String Sumary { get; set; } 
        public String Image_URL { get; set; } 

        public DateTime Date { get; set; }


    }
}
