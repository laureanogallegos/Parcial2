using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=(localdb)\\MssqllocalDb;Initial Catalog=Users;Integrated Security=true;");
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Usuario>().HasKey(n => n.NombreUsuario);
        }

    }
}
