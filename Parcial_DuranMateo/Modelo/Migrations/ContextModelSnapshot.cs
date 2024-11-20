﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Modelo.Grupo", b =>
                {
                    b.Property<string>("TipoGrupo")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TipoGrupo");

                    b.ToTable("Grupos", (string)null);
                });

            modelBuilder.Entity("Modelo.Usuario", b =>
                {
                    b.Property<string>("NombreUsuario")
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

                    b.Property<string>("GruposTipoGrupo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NombreUsuario");

                    b.HasIndex("GruposTipoGrupo");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("Modelo.Usuario", b =>
                {
                    b.HasOne("Modelo.Grupo", "Grupos")
                        .WithMany()
                        .HasForeignKey("GruposTipoGrupo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupos");
                });
#pragma warning restore 612, 618
        }
    }
}
