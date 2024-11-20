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
        DbSet<Usuario> usuarios;
        DbSet<Grupo> grupos;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>().HasKey(c=> c.Id);
            modelBuilder.Entity<Grupo>().HasKey(c => c.Id);


            modelBuilder.Entity<Usuario>().HasMany(x=>x.grupos);
        }

        
    }
}