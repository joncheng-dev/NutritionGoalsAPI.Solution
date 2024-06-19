using Microsoft.EntityFrameworkCore;

namespace NutritionGoalsAPI.Models
{
  public class NutritionGoalsAPIContext : DbContext
  {
    public DbSet<User> Users { get; set; }

    public NutritionGoalsAPIContext(DbContextOptions<NutritionGoalsAPIContext> options) : base(options)
    {
    }
  }
}