using Dating_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dating_App.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base (options)
        { 

        }
        public DbSet<AppUser> Users { get; set; }
    }
}
