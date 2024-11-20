using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source =(localdb)\\MSSQLLocalDb; Initial Catalog = ParcialBD; Integrated Security = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupo>().HasKey(x=> x.Id );
            modelBuilder.Entity<Usuario>().HasKey(x=> x.Id );

            modelBuilder.Entity<Usuario>().HasMany(g => g.Grupos).WithMany();
            base.OnModelCreating(modelBuilder); 
        }
    }
}
