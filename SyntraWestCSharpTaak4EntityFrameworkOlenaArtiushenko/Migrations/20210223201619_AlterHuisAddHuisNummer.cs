using Microsoft.EntityFrameworkCore.Migrations;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Migrations
{
    public partial class AlterHuisAddHuisNummer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HuisNummer",
                table: "Huis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HuisNummer",
                table: "Huis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
