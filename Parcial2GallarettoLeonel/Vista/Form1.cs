using Controladora;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        ControladoraUsuarios controladora;
        public Form1()
        {
            InitializeComponent();
            controladora = new ControladoraUsuarios();
            ActualizarGrilla();
            ActualizarTipos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Email = txtEmail.Text;
            usuario.Habilitado = RadioBtn.Checked;
            usuario.Clave = TxtClave.Text;
            if (TxtClave.Text == txtClave2.Text)
            {
                usuario.Clave = TxtClave.Text;
            }
            else MessageBox.Show("Las Claves no Coinciden");

            foreach (var grupo in TipoUsuarios.CheckedItems)
            {
                usuario.AsignarGrupo((Grupo)grupo);
            }

            var respuesta = controladora.Agregar(usuario);
            MessageBox.Show(respuesta);
            ActualizarGrilla();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.Rows[0].DataBoundItem;
                usuario.Nombre = txtNombre.Text;
                usuario.Email = txtEmail.Text;
                usuario.Habilitado = RadioBtn.Checked;
                usuario.Clave = TxtClave.Text;
                if (TxtClave.Text == txtClave2.Text)
                {
                    usuario.Clave = TxtClave.Text;
                }
                else MessageBox.Show("Las Claves no Coinciden");

                foreach (var tipo in TipoUsuarios.CheckedItems)
                {
                    usuario.AsignarGrupo((Grupo)tipo);
                }

                var respuesta = controladora.Modificar(usuario);
                MessageBox.Show(respuesta);
            }
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.Rows[0].DataBoundItem;
                var respuesta = controladora.Eliminar(usuario);
                MessageBox.Show(respuesta);
                ActualizarGrilla();
            }
        }

        private void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controladora.Listar();
        }

        private void ActualizarTipos()
        {
            TipoUsuarios.DataSource = null;
            TipoUsuarios.DataSource = controladora.Grupos();
        }
    }
}
