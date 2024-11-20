using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JeffreyDietzParcial2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrupoUsuario");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioUsername",
                table: "Grupos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "CodigoGrupo",
                keyValue: 1,
                column: "UsuarioUsername",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "CodigoGrupo",
                keyValue: 2,
                column: "UsuarioUsername",
                value: null);

            migrationBuilder.UpdateData(
                table: "Grupos",
                keyColumn: "CodigoGrupo",
                keyValue: 3,
                column: "UsuarioUsername",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_UsuarioUsername",
                table: "Grupos",
                column: "UsuarioUsername");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioUsername",
                table: "Grupos",
                column: "UsuarioUsername",
                principalTable: "Usuarios",
                principalColumn: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Usuarios_UsuarioUsername",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_UsuarioUsername",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "UsuarioUsername",
                table: "Grupos");

            migrationBuilder.CreateTable(
                name: "GrupoUsuario",
                columns: table => new
                {
                    GruposCodigoGrupo = table.Column<int>(type: "int", nullable: false),
                    UsuarioUsername = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuario", x => new { x.GruposCodigoGrupo, x.UsuarioUsername });
                    table.ForeignKey(
                        name: "FK_GrupoUsuario_Grupos_GruposCodigoGrupo",
                        column: x => x.GruposCodigoGrupo,
                        principalTable: "Grupos",
                        principalColumn: "CodigoGrupo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoUsuario_Usuarios_UsuarioUsername",
                        column: x => x.UsuarioUsername,
                        principalTable: "Usuarios",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrupoUsuario_UsuarioUsername",
                table: "GrupoUsuario",
                column: "UsuarioUsername");
        }
    }
}
