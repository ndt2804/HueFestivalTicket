namespace HueFestivalTicket.Models.News
{
    public class News
    {
        public String Title { get; set; } = String.Empty;

        public String Decriptions { get; set; } = String.Empty;
        public String Image_URL { get; set; } = String.Empty;

        public int Type_Program { get; set; }
    }
}
