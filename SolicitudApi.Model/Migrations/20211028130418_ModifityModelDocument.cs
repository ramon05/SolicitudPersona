using Microsoft.EntityFrameworkCore.Migrations;

namespace SolicitudApi.Model.Migrations
{
    public partial class ModifityModelDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Documents_Foto",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "OriginalName",
                table: "Documento",
                newName: "NombreOriginal");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Documento",
                newName: "NombreArchivo");

            migrationBuilder.RenameColumn(
                name: "ContentType",
                table: "Documento",
                newName: "TipoContenido");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documento",
                table: "Documento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Documento_Foto",
                table: "Persona",
                column: "Foto",
                principalTable: "Documento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Documento_Foto",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documento",
                table: "Documento");

            migrationBuilder.RenameTable(
                name: "Documento",
                newName: "Documents");

            migrationBuilder.RenameColumn(
                name: "NombreOriginal",
                table: "Documents",
                newName: "OriginalName");

            migrationBuilder.RenameColumn(
                name: "NombreArchivo",
                table: "Documents",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "TipoContenido",
                table: "Documents",
                newName: "ContentType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Documents_Foto",
                table: "Persona",
                column: "Foto",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
