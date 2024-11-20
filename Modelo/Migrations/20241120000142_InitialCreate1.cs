using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Grupos_GrupoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_GrupoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Grupos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_UsuarioId",
                table: "Grupos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioId",
                table: "Grupos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioId",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_UsuarioId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Grupos");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_GrupoId",
                table: "Usuarios",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Grupos_GrupoId",
                table: "Usuarios",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "GrupoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
