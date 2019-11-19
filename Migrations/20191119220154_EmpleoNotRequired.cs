using Microsoft.EntityFrameworkCore.Migrations;

namespace TestNet.Migrations
{
    public partial class EmpleoNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Empleo",
                table: "Personas");

            migrationBuilder.AlterColumn<int>(
                name: "EmpleoID",
                table: "Personas",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Empleo",
                table: "Personas",
                column: "EmpleoID",
                principalTable: "Empleos",
                principalColumn: "EmpleoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Empleo",
                table: "Personas");

            migrationBuilder.AlterColumn<int>(
                name: "EmpleoID",
                table: "Personas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Empleo",
                table: "Personas",
                column: "EmpleoID",
                principalTable: "Empleos",
                principalColumn: "EmpleoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
