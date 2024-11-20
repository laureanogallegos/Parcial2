using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System;
using Modelo;

namespace Vista1
{
    public partial class Form1 : Form
    {
        private AppDbContext context;

        public Form1()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=Usuarios.db");  // Usa la cadena de conexión adecuada.
            context = new AppDbContext(optionsBuilder.Options);
            CargarUsuarios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            var usuarios = context.Usuarios.Include(u => u.UsuarioGrupos).ThenInclude(ug => ug.Grupo).ToList();
            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != txtReingresarClave.Text)
            {
                MessageBox.Show("Las claves no coinciden.");
                return;
            }

            var existeUsuario = context.Usuarios.Any(u => u.NombreUsuario == txtNombreUsuario.Text);
            var existeEmail = context.Usuarios.Any(u => u.Email == txtEmail.Text);

            if (existeUsuario || existeEmail)
            {
                MessageBox.Show("El nombre de usuario o el email ya están registrados.");
                return;
            }

            var usuario = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text,
                Email = txtEmail.Text,
                Clave = Encrypt(txtNombreUsuario.Text, txtClave.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Estado = "Habilitado"
            };

            context.Usuarios.Add(usuario);
            context.SaveChanges();

            CargarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text != txtReingresarClave.Text)
            {
                MessageBox.Show("Las claves no coinciden.");
                return;
            }

            var usuarioId = txtNombreUsuario.Text;

            var usuario = context.Usuarios.Find(usuarioId);
            if (usuario != null)
            {
                usuario.Email = txtEmail.Text;
                usuario.Clave = Encrypt(txtNombreUsuario.Text, txtClave.Text);
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Estado = "Habilitado";

                context.SaveChanges();
            }

            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var usuarioId = txtNombreUsuario.Text;
            var usuario = context.Usuarios.Find(usuarioId);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
            }

            CargarUsuarios();
        }

        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
    }
}
