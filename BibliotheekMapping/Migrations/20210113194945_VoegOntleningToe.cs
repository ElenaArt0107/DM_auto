using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotheekMapping.Migrations
{
    public partial class VoegOntleningToe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ontleningen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KalntId = table.Column<int>(type: "int", nullable: false),
                    Van = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Voor = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ontleningen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ontleningen_Leden_KalntId",
                        column: x => x.KalntId,
                        principalTable: "Leden",
                        principalColumn: "LidId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ontleningen_KalntId",
                table: "Ontleningen",
                column: "KalntId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ontleningen");
        }
    }
}
