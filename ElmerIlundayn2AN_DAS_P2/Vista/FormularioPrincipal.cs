using Controlador;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Vista
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            textBoxNombreDeUsuario.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxClave.Text = string.Empty;
            textBoxNombreYApellido.Text = string.Empty;

        }
        private void ActualizarVista()
        {
            UsuarioController usuarioController = new UsuarioController();
            dataGridViewListaUsuarios.DataSource = usuarioController.ListarUsuarios();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            ActualizarVista();
            radioButtonHabilitado.Checked = true;
            comboBoxGruposAAsignar.DataSource = usuarioController.ListarGrupos();
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.NombreUsuario = textBoxNombreDeUsuario.Text;
            nuevoUsuario.Email = textBoxEmail.Text;
            nuevoUsuario.Clave = textBoxClave.Text;
            if (radioButtonHabilitado.Checked)
                nuevoUsuario.Estado = radioButtonHabilitado.Text;
            else
                nuevoUsuario.Estado = radioButtonInhabilitado.Text;
            nuevoUsuario.NombreYApellido = textBoxNombreYApellido.Text;
            //nuevoUsuario.GruposAsociados.Add(comboBoxGruposAAsignar.SelectedItem);
            usuarioController.AgregarUsuario(nuevoUsuario);
            ActualizarVista();
            LimpiarCampos();
        }

        private void textBoxNombreYApellido_Leave(object sender, EventArgs e)
        {

        }
    }
}
