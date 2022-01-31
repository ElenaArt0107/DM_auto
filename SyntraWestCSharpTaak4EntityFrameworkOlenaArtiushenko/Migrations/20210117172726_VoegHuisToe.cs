using Microsoft.EntityFrameworkCore.Migrations;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Migrations
{
    public partial class VoegHuisToe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Huis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HuisNummer = table.Column<int>(type: "int", nullable: false),
                    StraatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Huis_Straat_StraatId",
                        column: x => x.StraatId,
                        principalTable: "Straat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Huis_StraatId",
                table: "Huis",
                column: "StraatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Huis");
        }
    }
}
