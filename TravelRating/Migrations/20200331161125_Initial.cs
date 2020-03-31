using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelRating.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(nullable: false),
                    Review = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Hanoi", "Vietnam", "Ha Long Bay" },
                    { 2, "Reykjavik", "Iceland", "Thingvellir Park" },
                    { 3, "Kerry", "Ireland", "Killarney National Park" },
                    { 4, "New York", "United States", "Clock Walk" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "ExperienceId", "Author", "LocationId", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Ben's Mom", 3, 2, "Hanoi" },
                    { 2, "Matt's Mom", 3, 2, "Reykjavik" },
                    { 3, "Katy's Mom", 3, 2, "Kerry" },
                    { 4, "Katy's Kids' Mom", 3, 2, "New York" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_LocationId",
                table: "Experiences",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
