using Controladora;
using Modelo;

namespace JonathanKohan2AN
{
    public partial class Form1 : Form
    {
        ControladoraUsuario controladora;
        public Form1()
        {
            InitializeComponent();
            controladora = new ControladoraUsuario();
            cmbGrupo.DataSource = controladora.ListarGrupos();
            ActualizarDGV();
        }
        public void ActualizarDGV()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controladora.ListarUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                Usuario usuario = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
                controladora.Eliminar(usuario);
                MessageBox.Show("El usuario se elimino");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }

        }
    }
}
