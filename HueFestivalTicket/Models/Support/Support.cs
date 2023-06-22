﻿using System.ComponentModel.DataAnnotations;

namespace HueFestivalTicket.Models.Support
{
    public class Support
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
}
