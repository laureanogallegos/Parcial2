using Controladora;
using Modelo;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Parcial_DuranMateo
{
    public partial class Form1 : Form

    {
        ControladoraUsuarios controladoraUsuarios;
        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }

        public Form1()
        {
            InitializeComponent();
            controladoraUsuarios = new ControladoraUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.NombreUsuario = txtUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Clave = txtClave.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;

                if (controladoraUsuarios.AgregarUsuario(usuario))
                {
                    ActualizarDgv();
                    MessageBox.Show("Agregado");
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            var UsSeleccionado = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
            UsSeleccionado.NombreUsuario =
            UsSeleccionado.NombreUsuario = txtUsuario.Text;
            UsSeleccionado.Email = txtEmail.Text;
            UsSeleccionado.Clave = txtClave.Text;
            UsSeleccionado.Nombre = txtNombre.Text;
            UsSeleccionado.Apellido = txtApellido.Text;

            if (controladoraUsuarios.ModificarUsuario(UsSeleccionado))
            {
                ActualizarDgv();
                MessageBox.Show("Usuario modificado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se ha podido modificar.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            var UsSeleccionado = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;

            if (controladoraUsuarios.EliminarUsuario(UsSeleccionado))
            {
                ActualizarDgv(); 
                MessageBox.Show("Usuario eliminado exitosamente.");
            }


        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //---------------------VALIDACIONES-------------------------
        public bool ValidarCampos()
        {
            if (txtUsuario.Text != "")
            {
                if (txtEmail.Text != "")
                {
                    if (txtClave.Text != "")
                    {
                        if (txtNombre.Text != "")
                        {
                            if (txtApellido.Text != "")
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Complete campo APELLIDO");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Complete campo NOMBRE");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complete campo CLAVE");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Complete campo EMAIL");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Complete campo USUARIO");
                return false;
            }
        }
        public void ActualizarDgv()
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = controladoraUsuarios.ListarUsuario();
        }

        


        /*private void radioButton_CheckedChanged(object sender, EventArgs e)
{
   if (rbAdministrador.Checked)
   {
       LlenarGrillaConUsuariosPorGrupo("Administradores");
   }
   else if (rbUsuario.Checked)
   {
       LlenarGrillaConUsuariosPorGrupo("Usuarios");
   }
   else if (rbInvitado.Checked)
   {
       LlenarGrillaConUsuariosPorGrupo("Invitados");
   }
}

private void LlenarGrillaConUsuariosPorGrupo(string nombreGrupo)
{
   var usuarioController = new UsuarioController(new ApplicationDbContext());
   var usuarios = usuarioController.ObtenerUsuariosAsync().Result; 

   var usuariosFiltrados = usuarios.Where(u => u.Grupos.Any(g => g.NombreGrupo == nombreGrupo)).ToList();
   dgvAdministradores.DataSource = usuariosFiltrados.Select(u => new
   {
       u.Id,
       u.NombreUsuario,
       u.Email,
       Estado = u.Estado.ToString()
   }).ToList();
}*/
    }
}
