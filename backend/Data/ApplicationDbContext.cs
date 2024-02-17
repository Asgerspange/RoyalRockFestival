using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<News> news { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<Users> rock_users { get; set; }
    }
}
