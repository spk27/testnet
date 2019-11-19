using Microsoft.EntityFrameworkCore.Migrations;

namespace TestNet.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleos",
                columns: table => new
                {
                    EmpleoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(maxLength: 255, nullable: false),
                    Empresa = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleos", x => x.EmpleoID);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(maxLength: 255, nullable: true),
                    Cedula = table.Column<string>(maxLength: 15, nullable: false),
                    EmpleoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaID);
                    table.ForeignKey(
                        name: "FK_Personas_Empleo",
                        column: x => x.EmpleoId,
                        principalTable: "Empleos",
                        principalColumn: "EmpleoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EmpleoId",
                table: "Personas",
                column: "EmpleoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Empleos");
        }
    }
}
