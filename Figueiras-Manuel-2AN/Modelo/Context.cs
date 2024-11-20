using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<GrupoUsuario> GrupoUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SistemaUsuarios;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0");


        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<GrupoUsuario>().ToTable("GrupoUsuarios").HasKey(b => b.GrupoUsuarioId);
            model.Entity<Usuario>().ToTable("Usuarios").HasKey(b => b.UsuarioId);


            model.Entity<Usuario>().HasMany(c => c.Grupos).WithMany();
            
            base.OnModelCreating(model);
        }
        
    }

}
