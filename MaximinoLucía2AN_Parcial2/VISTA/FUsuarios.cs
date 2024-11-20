using MODELO;

namespace VISTA
{
    public partial class FUsuarios : Form
    {
        public FUsuarios()
        {
            InitializeComponent();
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            var listaUsuarios = CONTROLADORA.ControladoraUsuarios.Instancia.RecuperarUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var usuarioForm = new FUsuario();
            usuarioForm.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var seleccionaUsuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var usuarioForm = new FUsuario(seleccionaUsuario);
                usuarioForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para modificarlo");
            }
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var respuesta = MessageBox.Show("Está seguro que desea eliminar el usuario?", "Atención", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    var usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                    var eliminaUsuario = CONTROLADORA.ControladoraUsuarios.Instancia.EliminarUsuario(usuarioSeleccionado);
                    if (eliminaUsuario != null)
                    {
                        MessageBox.Show(eliminaUsuario, "Atención", MessageBoxButtons.OK);
                    }
                }
                else return;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista para eliminarlo");
            }
            ActualizarGrilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
