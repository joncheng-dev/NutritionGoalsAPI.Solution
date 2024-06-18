using Microsoft.EntityFrameworkCore;

public class YourDbContext : DbContext
{
    public DbSet<YourEntity> YourEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("your_connection_string_here");
        }
    }
}
