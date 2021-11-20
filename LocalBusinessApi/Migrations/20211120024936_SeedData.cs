using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Category", "Description", "Name", "Rate", "Review" },
                values: new object[,]
                {
                    { 1, "Restaurant", "A Chinese resturant that sells authentic Sichuan food.", "Taste of Sichuan", 5, "Love Taste of Sichuan! My favorite item on the menu is the potstickers. They are hand-made and taste like they are made with love. I also love the wontons in chili oil. Highly recommend this place for great Sichuan-style Chinese food in Beaverton." },
                    { 2, "Restaurant", "American chain restaurant offering sizable portions from a vast menu including signature cheesecake", "The Cheesecake Factory", 4, "Consistent each time. No wonder the long wait times esp on weekends. Try blocking a table 5o save you time! Whatever you eat, ensure you keep enough space for the two page dessert options." },
                    { 3, "Shop", "Candies & chocolates are sold by the piece or box at this old-school chain, in business since 1921.", "See's Candies", 3, "Apple pie white chocate truffles are the best! And blueberry truffles too!" },
                    { 4, "Shop", "Toy store in Southgate CPO, Oregon", "Go! Calendars, Toys & Games", 2, "A lot of variety here. The store is not well lit though and feels cluttered. They do have toys for every age child. Prices are reasonable." },
                    { 5, "Resturant", "Fast-food chain for Chinese standards, including some health-conscious options.", "Nori Japan", 1, "The food is overpriced  for the small amount of food, rice was really old, and the lady was really rude." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);
        }
    }
}
