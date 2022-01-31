using Microsoft.EntityFrameworkCore.Migrations;

namespace EF2Check.Migrations
{
    public partial class FixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BrNaam",
                table: "brouwers",
                newName: "BrouwerNaam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BrouwerNaam",
                table: "brouwers",
                newName: "BrNaam");
        }
    }
}
