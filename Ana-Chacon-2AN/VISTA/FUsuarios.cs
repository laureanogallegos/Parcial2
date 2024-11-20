using CONTROLADORA;
using MODELO;
namespace VISTA
{
    public partial class fUsuarios : Form
    {
        public fUsuarios()
        {
            InitializeComponent();
        }

        public void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ControladoraUsuario.Instancia.RecuperarUsuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            var fromUsuario = new FUsuario();
            fromUsuario.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuarios)dgvUsuarios.CurrentRow.DataBoundItem;
                var fromUsuario = new FUsuario(usuario);
                fromUsuario.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                var usuario = (Usuarios)dgvUsuarios.CurrentRow.DataBoundItem;
                var respuesta = ControladoraUsuario.Instancia.QuitarUsuario(usuario);
                MessageBox.Show(respuesta);
            }
            else
            {
                MessageBox.Show("Debes seleccionar algun usuario");
            }
            ActualizarGrilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FUsuario_load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
