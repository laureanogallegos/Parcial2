using Microsoft.EntityFrameworkCore;

namespace MODELO
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext()
        {
        }

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Parcial2;Trusted_Connection=True;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");   
            modelBuilder.Entity<Grupo>().ToTable("Grupos");
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Grupo>().HasKey(g => g.Id);
            modelBuilder.Entity<Usuario>().HasMany(u => u.Grupos).WithMany();

            base.OnModelCreating(modelBuilder);
        }
    }
}
