using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotheekMapping.Migrations
{
    public partial class VoegGenreToe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Boeken",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boeken_GenreId",
                table: "Boeken",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boeken_Genres_GenreId",
                table: "Boeken",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boeken_Genres_GenreId",
                table: "Boeken");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Boeken_GenreId",
                table: "Boeken");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Boeken");
        }
    }
}
