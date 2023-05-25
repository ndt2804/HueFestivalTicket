using HueFestivalTicket.Models.Role;
using HueFestivalTicket.Models.User;
using Microsoft.EntityFrameworkCore;

namespace HueFestivalTicket.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
