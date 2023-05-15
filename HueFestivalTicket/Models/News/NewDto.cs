namespace HueFestivalTicket.Models.News
{
    public class NewDto
    {
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;

        public String Decriptions { get; set; } = String.Empty;
        public String Image_URL { get; set; } = String.Empty;

        public DateTime Date { get; set; }

        public String Place { get; set; } = String.Empty;

        public Double Price { get; set; }


        public int Type_Program { get; set; }
        public int Type_Inoff { get; set; }

    }
}
