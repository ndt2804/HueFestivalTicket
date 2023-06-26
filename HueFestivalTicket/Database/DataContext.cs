using HueFestivalTicket.Models.Menu;
using HueFestivalTicket.Models.News;
using HueFestivalTicket.Models.ProgramFes;
using HueFestivalTicket.Models.Support;
using HueFestivalTicket.Models.TicketingPoint;
using HueFestivalTicket.Models.User;
using Microsoft.EntityFrameworkCore;

namespace HueFestivalTicket.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //public DbSet<User> Users { get; set; }
        public DbSet<ProgramFes> ProgramFes { get; set; }
        public DbSet<Support>  Support { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<UserDb> UsersDb { get; set; }
        public DbSet<TicketingPoint> TicketingPoint { get; set; }

        //public DbSet<Menu> Menu { get; set; }

    }
}
