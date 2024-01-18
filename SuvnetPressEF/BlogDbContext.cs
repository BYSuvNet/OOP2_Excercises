using Microsoft.EntityFrameworkCore;

namespace SuvnetPressEF;

public class BlogDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase("MinDatabas");
        // options.UseSqlite($"Data Source={"database.db"}");
    }
}