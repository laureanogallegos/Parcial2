using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto: DbContext
    {
        public DbSet<Usuario> Usuarios {  get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ParcialDB;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios").HasKey(U => U.Id);
            modelBuilder.Entity<Grupo>().ToTable("Grupos").HasKey(g => g.Id);
            modelBuilder.Entity<Grupo>().HasData(new Grupo { Id = 1, TipoDeGrupo = "Administrador" }, new Grupo { Id = 2, TipoDeGrupo = "Usuario" }, new Grupo { Id = 3, TipoDeGrupo = "Invitado" });
            modelBuilder.Entity<Usuario>().HasMany(f => f.Grupos).WithMany();
        }
    }
}