using Microsoft.EntityFrameworkCore.Migrations;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Migrations
{
    public partial class VoegHobbyPerPersoonToe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HobbyPerPersoon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersoonId = table.Column<int>(type: "int", nullable: false),
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyPerPersoon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HobbyPerPersoon_Hobby_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyPerPersoon_Persoon_PersoonId",
                        column: x => x.PersoonId,
                        principalTable: "Persoon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HobbyPerPersoon_HobbyId",
                table: "HobbyPerPersoon",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyPerPersoon_PersoonId",
                table: "HobbyPerPersoon",
                column: "PersoonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HobbyPerPersoon");
        }
    }
}
