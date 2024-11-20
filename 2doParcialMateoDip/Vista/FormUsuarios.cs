using Controladora;
using Modelo;

namespace Vista
{
    public partial class FormUsuarios : Form
    {
        ControladoraUsuarios controladora;
        public FormUsuarios()
        {
            InitializeComponent();
            controladora = new ControladoraUsuarios();
            ActualizarGrilla();
            ActualizarCheckList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == txtConfirmacionClave.Text)
            {
                Usuario usuario = new Usuario();

                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Clave = txtClave.Text;
                usuario.Estado = chBoxEstado.Checked;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                foreach (var grupo in chBoxListGrupos.CheckedItems)
                {
                    var g = grupo as Grupo;
                    usuario.AgregarGrupo(g);
                }


                if (controladora.AgregarUsuario(usuario))
                {
                    MessageBox.Show("Exito en la carga.");
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Usuario o Email ya Registrados.");
                }
            }
            else
            {
                MessageBox.Show("Error en la confirmacion de la cotraseña.");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Email = txtEmail.Text;
            usuario.Clave = txtClave.Text;
            usuario.Estado = chBoxEstado.Checked;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            foreach (var grupo in chBoxListGrupos.CheckedItems)
            {
                var g = grupo as Grupo;
                usuario.AgregarGrupo(controladora.ListarGrupos().FirstOrDefault(x => x.CodigoGrupo == g.CodigoGrupo));
            }
            var UsuarioSeleccionado = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            if (UsuarioSeleccionado.NombreUsuario == usuario.NombreUsuario && UsuarioSeleccionado.Email == usuario.Email)
            {
                if (controladora.ModificarUsuario(usuario))
                {
                    MessageBox.Show("Exito en la modificacion.");
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar.");
                }
            }
            else
            {
                MessageBox.Show("El Nombre de usuario no se puede modificar no se puede modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var UsuarioSeleccionado = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            if (controladora.EliminarUsuario(UsuarioSeleccionado))
            {
                MessageBox.Show("Exito en la eliminacion.");
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controladora.ListarUsuario();
        }

        private void ActualizarCheckList()
        {
            chBoxListGrupos.DataSource = null;
            chBoxListGrupos.DataSource = controladora.ListarGrupos();

        }

        private void ActualizarGrillaGrupos(Usuario usuario)
        {
            dgvGruposDelUsuario.DataSource = null;
            dgvGruposDelUsuario.DataSource = usuario.ListarGrupos();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Usuario = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            var UsuarioSeleccionado = controladora.ListarUsuario().FirstOrDefault(x => x.NombreUsuario == Usuario.NombreUsuario);
            ActualizarGrillaGrupos(UsuarioSeleccionado);
        }
    }
}
