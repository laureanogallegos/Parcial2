﻿// <auto-generated />
using JeffreyDietzParcial2.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JeffreyDietzParcial2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241119234737_InitialCreate2")]
    partial class InitialCreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JeffreyDietzParcial2.Modelo.Grupo", b =>
                {
                    b.Property<int>("CodigoGrupo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoGrupo"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioUsername")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CodigoGrupo");

                    b.HasIndex("UsuarioUsername");

                    b.ToTable("Grupos", (string)null);

                    b.HasData(
                        new
                        {
                            CodigoGrupo = 1,
                            Nombre = "Administradores"
                        },
                        new
                        {
                            CodigoGrupo = 2,
                            Nombre = "Usuarios"
                        },
                        new
                        {
                            CodigoGrupo = 3,
                            Nombre = "Invitados"
                        });
                });

            modelBuilder.Entity("JeffreyDietzParcial2.Modelo.Usuario", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstaHabilitado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("JeffreyDietzParcial2.Modelo.Grupo", b =>
                {
                    b.HasOne("JeffreyDietzParcial2.Modelo.Usuario", null)
                        .WithMany("Grupos")
                        .HasForeignKey("UsuarioUsername");
                });

            modelBuilder.Entity("JeffreyDietzParcial2.Modelo.Usuario", b =>
                {
                    b.Navigation("Grupos");
                });
#pragma warning restore 612, 618
        }
    }
}
