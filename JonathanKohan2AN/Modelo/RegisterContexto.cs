using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RegisterContexto:DbContext
    {
        public DbSet<Grupo> grupos {  get; set; }
        public DbSet<Usuario> usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source = (localdb)\\MSSQLLocalDb; Initial Catalog = BaseDeDatos; Integrated Security = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>().HasKey(x => x.Id);
            modelBuilder.Entity<Grupo>().HasData(
                new Grupo{Id = 1, Nombre = "Administrador"},
                new Grupo { Id = 2, Nombre = "Usuario" },
                new Grupo { Id = 3, Nombre = "Invitado" }
            );
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuario>().HasMany(x => x.grupos).WithMany();
        }
    }
}
