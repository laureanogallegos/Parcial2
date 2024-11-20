using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Model
{
    public class UserContext  : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Rol> Rol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<User>().ToTable("User").HasKey(x =>x.IdUsuario);
            modelBuilder.Entity<Rol>().ToTable("Rol").HasKey(x => x.IdRol);

            base.OnModelCreating(modelBuilder);
        }
    }
}
