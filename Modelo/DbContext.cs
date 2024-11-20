using Microsoft.EntityFrameworkCore;
using System.Text;


namespace Modelo
{
    public class AppDbContext : DbContext
    {
        // Constructor para permitir la configuración de opciones del DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet para las entidades
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => new { u.NombreUsuario, u.Email })
                .IsUnique();

            // Configuración de la relación muchos a muchos entre Usuario y Grupo
            modelBuilder.Entity<UsuarioGrupo>()
                .HasKey(ug => new { ug.NombreUsuario, ug.GrupoId });

            modelBuilder.Entity<UsuarioGrupo>()
                .HasOne(ug => ug.Usuario)
                .WithMany(u => u.UsuarioGrupos)
                .HasForeignKey(ug => ug.NombreUsuario);

            modelBuilder.Entity<UsuarioGrupo>()
                .HasOne(ug => ug.Grupo)
                .WithMany(g => g.UsuarioGrupos)
                .HasForeignKey(ug => ug.GrupoId);

            // Datos precargados para Grupos
            modelBuilder.Entity<Grupo>().HasData(
                new Grupo { GrupoId = 1, Nombre = "Administradores" },
                new Grupo { GrupoId = 2, Nombre = "Usuarios" },
                new Grupo { GrupoId = 3, Nombre = "Invitados" }
            );
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            }
        }
    }


}
