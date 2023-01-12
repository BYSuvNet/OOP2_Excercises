using Microsoft.EntityFrameworkCore;

namespace SuvnetPressEF;

public class BlogDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={"database.db"}");
        // options.UseInMemoryDatabase("MinDatabas");
    }
}