﻿using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.News
{
    public class News
    {

        [Key]
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;

        public String Sumary { get; set; } = String.Empty;
        public String Content { get; set; } = String.Empty;
        public String Keyword { get; set; } = String.Empty;

        public String Image_URL { get; set; } = String.Empty;

        public DateTime Date { get; set; }

        public String Author { get; set; } = String.Empty;
    }
}
