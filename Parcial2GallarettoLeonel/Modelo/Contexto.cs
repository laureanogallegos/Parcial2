using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)


        {
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            
            modelBuilder.Entity<Grupo>().HasKey(g => g.Id);
            modelBuilder.Entity<Grupo>().HasData(new Grupo { Id = 1, Roll = "Invitado" });
            modelBuilder.Entity<Grupo>().HasData(new Grupo { Id = 2, Roll = "Usuario" });
            modelBuilder.Entity<Grupo>().HasData(new Grupo { Id = 3, Roll = "Administrador" });


            modelBuilder.Entity<Usuario>().HasMany(g => g.Grupos).WithMany();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }


       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog= Parcial2G_EF;");
    }
}
