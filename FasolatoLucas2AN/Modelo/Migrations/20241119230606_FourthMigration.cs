using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioId",
                table: "Grupos");

            migrationBuilder.DropForeignKey(
                name: "FK_GrupoUsuario_Grupos_GrupoId",
                table: "GrupoUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_GrupoUsuario_Usuarios_UsuariosUsuarioId",
                table: "GrupoUsuario");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_UsuarioId",
                table: "Grupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GrupoUsuario",
                table: "GrupoUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Grupos");

            migrationBuilder.RenameTable(
                name: "GrupoUsuario",
                newName: "UsuarioGrupos");

            migrationBuilder.RenameColumn(
                name: "GrupoId",
                table: "UsuarioGrupos",
                newName: "GruposGrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_GrupoUsuario_UsuariosUsuarioId",
                table: "UsuarioGrupos",
                newName: "IX_UsuarioGrupos_UsuariosUsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupos",
                table: "UsuarioGrupos",
                columns: new[] { "GruposGrupoId", "UsuariosUsuarioId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GruposGrupoId",
                table: "UsuarioGrupos",
                column: "GruposGrupoId",
                principalTable: "Grupos",
                principalColumn: "GrupoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Usuarios_UsuariosUsuarioId",
                table: "UsuarioGrupos",
                column: "UsuariosUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GruposGrupoId",
                table: "UsuarioGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Usuarios_UsuariosUsuarioId",
                table: "UsuarioGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupos",
                table: "UsuarioGrupos");

            migrationBuilder.RenameTable(
                name: "UsuarioGrupos",
                newName: "GrupoUsuario");

            migrationBuilder.RenameColumn(
                name: "GruposGrupoId",
                table: "GrupoUsuario",
                newName: "GrupoId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioGrupos_UsuariosUsuarioId",
                table: "GrupoUsuario",
                newName: "IX_GrupoUsuario_UsuariosUsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Grupos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GrupoUsuario",
                table: "GrupoUsuario",
                columns: new[] { "GrupoId", "UsuariosUsuarioId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoUsuario_Grupos_GrupoId",
                table: "GrupoUsuario",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "GrupoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GrupoUsuario_Usuarios_UsuariosUsuarioId",
                table: "GrupoUsuario",
                column: "UsuariosUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
