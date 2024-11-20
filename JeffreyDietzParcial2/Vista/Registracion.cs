using JeffreyDietzParcial2.Controlador;
using JeffreyDietzParcial2.Modelo;

namespace JeffreyDietzParcial2
{
    public partial class Registracion : Form
    {
        UsuarioController controladora;

        public Registracion()
        {

            InitializeComponent();
            controladora = new UsuarioController();

        }

        private void Registracion_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Administrador");
            checkedListBox1.Items.Add("Usuario");
            checkedListBox1.Items.Add("Invitado");
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controladora.RecuperarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbConfContraseña.Text == tbContraseña.Text && tbUsername != null)
            {
                var usuario = new Usuario();
                usuario.EstaHabilitado = cbHablitado.Checked;
                usuario.Nombre = tbNombre.Text;
                usuario.Apellido = tbApellido.Text;
                usuario.Email = tbEmail.Text;
                usuario.Username = tbUsername.Text;
                usuario.Clave = tbContraseña.Text;
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    var grupo = new Grupo();
                    grupo.Nombre = (string)item;
                    usuario.Grupos.Add(grupo);
                }

                var seAgrego = controladora.AgregarUsuario(usuario);

                if ( seAgrego)
                {
                    
                    MessageBox.Show("Usuario agregado");
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = controladora.RecuperarUsuarios();
                }
                else if ()
                {
                    MessageBox.Show("No se pudo agregar el usuario");
                }

            }
        }
    }
}
