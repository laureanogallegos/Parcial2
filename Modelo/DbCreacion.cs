using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class DbCreacion : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=SistemaRegistro");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(c => c.Id);
            modelBuilder.Entity<Grupo>().HasKey(c => c.Id);
            modelBuilder.Entity<Usuario>().HasMany(c => c.Grupos).WithOne();
            modelBuilder.Entity<Grupo>().HasData(
                new Grupo { Id = 1, Rol = "Administradores" },
                new Grupo { Id = 2, Rol = "Usuarios" },
                new Grupo { Id = 3, Rol = "Invitados" }
            );
            base.OnModelCreating(modelBuilder);
        }
    }

}
