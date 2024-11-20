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
       public DbSet<Usuario> Usuarios { get; set; }
       public DbSet<Grupo> Grupo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios").HasKey(p => p.NombreUsuario);
            modelBuilder.Entity<Grupo>().ToTable("Grupos").HasKey(x => x.TipoGrupo);
            
            modelBuilder.Entity<Usuario>().HasOne(g => g.Grupos);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database=2ANDuranMateo; Trusted_Connection=True;");
        }
    }
}
