using Controladora;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        private ControladoraUsuario controladoraUsuario;
        public Form1()
        {
            InitializeComponent();
            controladoraUsuario = new ControladoraUsuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }


        private void ActualizarVista()
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = controladoraUsuario.RecuperarUsuarios();
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Id", DataPropertyName = "Id" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre de Usuario", DataPropertyName = "NombreUsuario" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellido", DataPropertyName = "Apellido" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Grupos", DataPropertyName = "NombreGrupos" });

            checkboxGrupos.DataSource = controladoraUsuario.RecuperarGrupos();
            checkboxGrupos.DisplayMember = "Nombre";
        }

        public bool ValidarDatos()
        {
            
            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("ERROR: Las claves no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("ERROR:  no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("ERROR:  no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("ERROR:  no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("ERROR:  no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("ERROR:  no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string estadoSeleccionado = cmbEstado.SelectedItem.ToString();
            if (estadoSeleccionado != "Habilitado" && estadoSeleccionado != "Inhabilitado")
            {
                MessageBox.Show("ERROR: El estado debe ser 'Habilitado' o 'Inhabilitado'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (checkboxGrupos.CheckedItems.Count == 0)
            {
                MessageBox.Show("ERROR: Debe seleccionar al menos un grupo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Usuario usuario = new Usuario();
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Email = txtEmail.Text;
                usuario.Clave = txtClave.Text;
                usuario.Estado = cmbEstado.SelectedItem.ToString();
                foreach (var grupo in checkboxGrupos.CheckedItems)
                {
                    usuario.Agregar((Grupo)grupo);
                }
                if (controladoraUsuario.Agregar(usuario))
                {
                    MessageBox.Show(" agregado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarVista();
                }
                else
                {
                    MessageBox.Show("ERROR: No se ha podido agregar .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("ERROR: Seleccione un usuario para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarDatos())
            {
                Usuario usuario = dgv.SelectedRows[0].DataBoundItem as Usuario;


                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Email = txtEmail.Text;
                usuario.Clave = txtClave.Text;
                usuario.Estado = cmbEstado.SelectedItem.ToString();

                List<Grupo> grupos = new List<Grupo>();
                foreach (var grupo in checkboxGrupos.CheckedItems)
                {
                    grupos.Add((Grupo)grupo);
                }
                usuario.Modificar(grupos);

                if (controladoraUsuario.Modificar(usuario))
                {
                    MessageBox.Show("Usuario modificado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarVista();
                }
                else
                {
                    MessageBox.Show("ERROR: No se ha podido modificar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (dgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("ERROR: Seleccione  para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = dgv.SelectedRows[0].DataBoundItem as Usuario;

            if (controladoraUsuario.Eliminar(usuario))
            {
                MessageBox.Show(" eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("ERROR: No se ha podido eliminar .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DropDownList(object sender, EventArgs e)
        {

        }
    }
}
