using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto:DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ParcialSosa2TN;");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Usuario>().ToTable("Usuarios").HasKey(u => u.Id);
            model.Entity<Grupo>().ToTable("Grupos").HasKey(g => g.Id);
            model.Entity<Grupo>().HasData(new Grupo { Id = 1, Tipo = "Administrador" },new Grupo { Id = 2, Tipo = "Usuario" },new Grupo { Id = 3, Tipo = "Invitado" });

            model.Entity<Usuario>().HasMany(f => f.Grupos).WithMany();
        }
    }
}
