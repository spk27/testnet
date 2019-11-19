using Microsoft.EntityFrameworkCore.Migrations;

namespace TestNet.Migrations
{
    public partial class CreacionContacto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    ContactoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.ContactoID);
                });

            migrationBuilder.CreateTable(
                name: "PersonaContacto",
                columns: table => new
                {
                    PersonaID = table.Column<int>(nullable: false),
                    ContactoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaContacto", x => new { x.PersonaID, x.ContactoID });
                    table.ForeignKey(
                        name: "FK_Contacto_Personas",
                        column: x => x.ContactoID,
                        principalTable: "Contactos",
                        principalColumn: "ContactoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Contactos",
                        column: x => x.PersonaID,
                        principalTable: "Personas",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonaContacto_ContactoID",
                table: "PersonaContacto",
                column: "ContactoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonaContacto");

            migrationBuilder.DropTable(
                name: "Contactos");
        }
    }
}
