using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JeffreyDietzParcial2.Modelo
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=AdminUsuarios;");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Usuario>().ToTable("Usuarios").HasKey(u => u.Username);

            model.Entity<Grupo>().ToTable("Grupos").HasKey(g => g.CodigoGrupo);
            model.Entity<Grupo>().ToTable("Grupos").HasData(
                new Grupo { CodigoGrupo = 1, Nombre = "Administradores"},
                new Grupo { CodigoGrupo = 2, Nombre = "Usuarios" },
                new Grupo { CodigoGrupo = 3, Nombre = "Invitados" }
                );

            model.Entity<Usuario>()
                .HasMany(u => u.Grupos);
        }

    }
}
