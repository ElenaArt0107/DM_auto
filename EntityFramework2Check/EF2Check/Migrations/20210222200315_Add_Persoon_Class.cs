using Microsoft.EntityFrameworkCore.Migrations;

namespace EF2Check.Migrations
{
    public partial class Add_Persoon_Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    FavouriteBierId1 = table.Column<int>(type: "int", nullable: false),
                    FavouriteBierId2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personnen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavouriteBier1",
                        column: x => x.FavouriteBierId1,
                        principalTable: "bieren",
                        principalColumn: "BierNr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteBier2",
                        column: x => x.FavouriteBierId2,
                        principalTable: "bieren",
                        principalColumn: "BierNr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personnen_FavouriteBierId1",
                table: "Personnen",
                column: "FavouriteBierId1");

            migrationBuilder.CreateIndex(
                name: "IX_Personnen_FavouriteBierId2",
                table: "Personnen",
                column: "FavouriteBierId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnen");
        }
    }
}
