using Microsoft.EntityFrameworkCore;
using PS_1_Backend.Models;

namespace PS_1_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<CHO_Activity> CHO_Activities { get; set; }
        public DbSet<Insert_Activity> Insert_Activities { get; set; }

    }
}
