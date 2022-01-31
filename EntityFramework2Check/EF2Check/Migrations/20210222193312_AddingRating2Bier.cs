using Microsoft.EntityFrameworkCore.Migrations;

namespace EF2Check.Migrations
{
    public partial class AddingRating2Bier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "bieren",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "bieren");
        }
    }
}
