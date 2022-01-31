using Microsoft.EntityFrameworkCore.Migrations;

namespace DMAutoservice.Domain.Migrations
{
    public partial class AddingEngines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerStandard = table.Column<int>(type: "int", nullable: false),
                    PowerAfterTuning = table.Column<int>(type: "int", nullable: false),
                    TorqueStandard = table.Column<int>(type: "int", nullable: false),
                    TorqueAfterTuning = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenerationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engines_Generations_GenerationId",
                        column: x => x.GenerationId,
                        principalTable: "Generations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engines_GenerationId",
                table: "Engines",
                column: "GenerationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engines");
        }
    }
}
