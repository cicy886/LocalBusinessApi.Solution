using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessApiContext : DbContext
  {
    public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options) : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }
  }
}