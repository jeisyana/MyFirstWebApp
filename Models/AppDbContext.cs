using Microsoft.EntityFrameworkCore;

namespace MyFirstWebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        // ↓↓↓ ここを追加！！
        public DbSet<Station> Stations { get; set; }
    }

}
