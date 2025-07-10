using Microsoft.EntityFrameworkCore;
using PS_1_Backend.Models;

namespace PS_1_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
