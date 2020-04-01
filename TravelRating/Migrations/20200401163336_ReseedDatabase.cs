using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelRating.Migrations
{
    public partial class ReseedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 1,
                column: "Author",
                value: "Ben");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 2,
                column: "Author",
                value: "Matt");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 3,
                column: "Author",
                value: "Katy");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 4,
                column: "Author",
                value: "Steph");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 1,
                column: "Author",
                value: "Ben's Mom");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 2,
                column: "Author",
                value: "Matt's Mom");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 3,
                column: "Author",
                value: "Katy's Mom");

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "ExperienceId",
                keyValue: 4,
                column: "Author",
                value: "Katy's Kids' Mom");
        }
    }
}
