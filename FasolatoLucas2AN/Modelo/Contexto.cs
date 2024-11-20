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
        public DbSet<Usuario> Usuarios;
        public DbSet<Grupo> Grupos;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LF_USERS_EF;");

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Usuario>().ToTable("Usuarios").HasKey(u => u.UsuarioId);
            model.Entity <Grupo>().ToTable("Grupos").HasKey(g => g.GrupoId);

            //model.Entity<Usuario>().HasMany(u => u.Grupos).WithOne();
            //model.Entity<Grupo>().HasMany(g => g.Usuarios).WithMany();

            model.Entity<Usuario>()
                    .HasMany(u => u.Grupos)
                    .WithMany(g => g.Usuarios)
                    .UsingEntity(j => j.ToTable("UsuarioGrupos")); 
        }
    }
}
