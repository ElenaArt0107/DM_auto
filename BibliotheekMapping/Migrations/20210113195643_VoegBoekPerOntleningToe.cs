using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotheekMapping.Migrations
{
    public partial class VoegBoekPerOntleningToe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoekenPerOntlening",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OntleningId = table.Column<int>(type: "int", nullable: false),
                    BoekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoekenPerOntlening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoekenPerOntlening_Boeken_BoekId",
                        column: x => x.BoekId,
                        principalTable: "Boeken",
                        principalColumn: "BoekID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoekenPerOntlening_Ontleningen_OntleningId",
                        column: x => x.OntleningId,
                        principalTable: "Ontleningen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoekenPerOntlening_BoekId",
                table: "BoekenPerOntlening",
                column: "BoekId");

            migrationBuilder.CreateIndex(
                name: "IX_BoekenPerOntlening_OntleningId",
                table: "BoekenPerOntlening",
                column: "OntleningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoekenPerOntlening");
        }
    }
}
