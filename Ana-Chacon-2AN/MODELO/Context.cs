using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Context : DbContext
    {
        public Context() { }
        public Context (DbContextOptions<Context> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; DataBase = Parcial2; Trusted_Connection=True;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Grupos>().ToTable("Grupos");
            modelBuilder.Entity<Usuarios>().HasKey(x => x.Id);
            modelBuilder.Entity<Grupos>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuarios>().HasMany(x => x.Grupos).WithMany();
            base.OnModelCreating(modelBuilder);
        }



    }
}
