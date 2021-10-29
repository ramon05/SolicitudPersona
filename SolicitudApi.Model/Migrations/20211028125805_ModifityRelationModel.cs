using Microsoft.EntityFrameworkCore.Migrations;

namespace SolicitudApi.Model.Migrations
{
    public partial class ModifityRelationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Solicitud_SolicitudId",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_SolicitudId",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "SolicitudId",
                table: "Persona");

            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Solicitud",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_PersonaId",
                table: "Solicitud",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitud_Persona_PersonaId",
                table: "Solicitud",
                column: "PersonaId",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitud_Persona_PersonaId",
                table: "Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_Solicitud_PersonaId",
                table: "Solicitud");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Solicitud");

            migrationBuilder.AddColumn<int>(
                name: "SolicitudId",
                table: "Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_SolicitudId",
                table: "Persona",
                column: "SolicitudId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Solicitud_SolicitudId",
                table: "Persona",
                column: "SolicitudId",
                principalTable: "Solicitud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
