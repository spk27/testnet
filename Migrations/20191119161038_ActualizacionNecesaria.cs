using Microsoft.EntityFrameworkCore.Migrations;

namespace TestNet.Migrations
{
    public partial class ActualizacionNecesaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpleoId",
                table: "Personas",
                newName: "EmpleoID");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_EmpleoId",
                table: "Personas",
                newName: "IX_Personas_EmpleoID");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Personas",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Personas",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroTrabajadores",
                table: "Empleos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "NumeroTrabajadores",
                table: "Empleos");

            migrationBuilder.RenameColumn(
                name: "EmpleoID",
                table: "Personas",
                newName: "EmpleoId");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_EmpleoID",
                table: "Personas",
                newName: "IX_Personas_EmpleoId");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Personas",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
