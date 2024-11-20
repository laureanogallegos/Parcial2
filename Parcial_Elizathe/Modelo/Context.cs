using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Grupo> Grupos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Parcial_Elizathe;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios").HasKey(p => p.Id);
            modelBuilder.Entity<Grupo>().ToTable("Grupos").HasKey(p => p.Id);
            modelBuilder.Entity<Usuario>().HasMany(p => p.Grupos).WithMany();

            modelBuilder.Entity<Grupo>().HasData(
            new Grupo { Id = 1, Nombre = "Administradores" },
            new Grupo { Id = 2, Nombre = "Usuarios" },
            new Grupo { Id = 3, Nombre = "Invitados" }
);

            base.OnModelCreating(modelBuilder);
        }
    }
}
