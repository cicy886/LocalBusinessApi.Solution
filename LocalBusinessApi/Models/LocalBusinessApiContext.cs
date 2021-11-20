using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessApiContext : DbContext
  {
    public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>().HasData(
        new Business { BusinessId = 1, Name = "Taste of Sichuan", Category = "Restaurant", Description = "A Chinese resturant that sells authentic Sichuan food.", Rate = 5, Review = "Love Taste of Sichuan! My favorite item on the menu is the potstickers. They are hand-made and taste like they are made with love. I also love the wontons in chili oil. Highly recommend this place for great Sichuan-style Chinese food in Beaverton."},
        new Business { BusinessId = 2, Name = "The Cheesecake Factory",
        Category = "Restaurant", Description = "American chain restaurant offering sizable portions from a vast menu including signature cheesecake", Rate = 4, Review = "Consistent each time. No wonder the long wait times esp on weekends. Try blocking a table 5o save you time! Whatever you eat, ensure you keep enough space for the two page dessert options."},
        new Business { BusinessId = 3, Name = "See's Candies", Category = "Shop", Description = "Candies & chocolates are sold by the piece or box at this old-school chain, in business since 1921.", Rate = 3, Review = "Apple pie white chocate truffles are the best! And blueberry truffles too!"},
        new Business { BusinessId = 4, Name = "Go! Calendars, Toys & Games", Category = "Shop", Description = "Toy store in Southgate CPO, Oregon", Rate = 2, Review = "A lot of variety here. The store is not well lit though and feels cluttered. They do have toys for every age child. Prices are reasonable."},
        new Business { BusinessId = 5, Name = "Nori Japan", Category = "Resturant", Description = "Fast-food chain for Chinese standards, including some health-conscious options.", Rate = 1, Review ="The food is overpriced  for the small amount of food, rice was really old, and the lady was really rude."}
      );
    }

    public DbSet<Business> Businesses { get; set; }
  }
}