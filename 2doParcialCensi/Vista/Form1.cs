using Controladora;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        private ControladoraUsuarios controladoraUsuarios;
        private Usuario usuario;
        private Grupo grupo;

        public Form1()
        {
            InitializeComponent();
            controladoraUsuarios = new ControladoraUsuarios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuario");
            comboBox1.Items.Add("Invitado");
        }    

        private void ActualizarVista()
        {
            dgvUsuarios.DataSource = controladoraUsuarios.RecuperarUsuarios();

            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = controladoraUsuarios.RecuperarUsuarios();
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellido", DataPropertyName = "Apellido" });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado" });
        }

        private bool ValidarDatos()
        {
            return true;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                usuario = new Usuario();
                grupo = new Grupo();

                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Clave = txtClave1.Text;
                if(radioButton1.Checked == true)
                {
                    usuario.Estado = "Habilitado";
                }
                else
                {
                    usuario.Estado = "Inhabilitado";
                }

                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Grupo.Tipo = comboBox1.SelectedIndex.ToString();
         

                if (controladoraUsuarios.AgregarUsuario(usuario))
                {
                    ActualizarVista();

                    MessageBox.Show("Usuario añadida con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre o email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;

            if (controladoraUsuarios.EliminarUsuario(usuario))
            {
                ActualizarVista();

                MessageBox.Show("Usuario eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El usuario no se ha podido eliminar de la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Seleccione un usuario para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return; 
            }

            if (ValidarDatos())
            {
                Usuario usuarioSeleccionado = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;

                usuarioSeleccionado.Nombre = txtNombre.Text;
                usuarioSeleccionado.Apellido = txtApellido.Text;
                if (radioButton1.Checked == true)
                {
                    usuarioSeleccionado.Estado = "Habilitado";
                }
                else
                {
                    usuarioSeleccionado.Estado = "Inhabilitado";
                }
                usuarioSeleccionado.Grupo.Tipo = comboBox1.SelectedIndex.ToString();



                if (controladoraUsuarios.ModificarUsuario(usuarioSeleccionado))
                {
                    ActualizarVista();

                    MessageBox.Show("Usuario modificado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario no se ha podido modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
