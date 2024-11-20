using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Modelo;
public class UsuariosContext : DbContext

{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Grupo> Grupos { get; set; }

    public string DbPath { get; }

    public UsuariosContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "usuario.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source = (localdb)\\MssqlLocalDB; Initial Catalog = DBusuarios; Integrated Security = true;");
}
