using Microsoft.EntityFrameworkCore.Migrations;

namespace Oef3.Migrations
{
    public partial class InintialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afdeling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afdeling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialiteit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialiteit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Werkgever",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werkgever", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Werknemer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AfdelingId = table.Column<int>(type: "int", nullable: false),
                    SpecialiteitId = table.Column<int>(type: "int", nullable: true),
                    WerkgeverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Werknemer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Werknemer_Afdeling_AfdelingId",
                        column: x => x.AfdelingId,
                        principalTable: "Afdeling",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Werknemer_Specialiteit_SpecialiteitId",
                        column: x => x.SpecialiteitId,
                        principalTable: "Specialiteit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Werknemer_Werkgever_WerkgeverId",
                        column: x => x.WerkgeverId,
                        principalTable: "Werkgever",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_AfdelingId",
                table: "Werknemer",
                column: "AfdelingId");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_SpecialiteitId",
                table: "Werknemer",
                column: "SpecialiteitId");

            migrationBuilder.CreateIndex(
                name: "IX_Werknemer_WerkgeverId",
                table: "Werknemer",
                column: "WerkgeverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Werknemer");

            migrationBuilder.DropTable(
                name: "Afdeling");

            migrationBuilder.DropTable(
                name: "Specialiteit");

            migrationBuilder.DropTable(
                name: "Werkgever");
        }
    }
}
