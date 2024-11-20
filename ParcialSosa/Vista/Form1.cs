using Controladora;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        private ControladoraUsuario controladora;
        public Form1()
        {
            InitializeComponent();
            controladora = new ControladoraUsuario();
            CargarGrupos();
            Actualizar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                if (txtClave.Text == txtRepetirClave.Text)
                {
                    Usuario usuario = new Usuario();
                    usuario.NombreUsuario = txtUsuario.Text;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Clave = controladora.Encrypt(txtUsuario.Text, txtClave.Text);
                    usuario.Estado = cmbEstado.Text;
                    foreach (var grupos in checkedList.CheckedItems)
                    {
                        usuario.AgregarGrupo((Grupo)grupos);
                    }

                    if (controladora.Agregar(usuario))
                    {
                        MessageBox.Show("Agregado.", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualizar();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las Clave tienen que ser iguales!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void CargarGrupos()
        {
            checkedList.DataSource = null;
            checkedList.DataSource = controladora.Grupos();
            checkedList.DisplayMember = "Tipo";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (dgvUsuarios.Rows.Count > 0)
                {
                    if (txtClave.Text == txtRepetirClave.Text)
                    {
                        var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                        usuario.NombreUsuario = txtUsuario.Text;
                        usuario.Nombre = txtNombre.Text;
                        usuario.Apellido = txtApellido.Text;
                        usuario.Email = txtEmail.Text;
                        usuario.Clave = controladora.Encrypt(txtUsuario.Text, txtClave.Text);
                        usuario.Estado = cmbEstado.Text;
                        List<Grupo> grupos = new List<Grupo>();
                        foreach (var grupo in checkedList.CheckedItems)
                        {
                            grupos.Add((Grupo)grupo);
                        }
                        usuario.ModificarGrupo(grupos);

                        if (controladora.Modificar(usuario))
                        {
                            MessageBox.Show("Modificado.", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Actualizar();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                if (controladora.Eliminar(usuario))
                {
                    MessageBox.Show("Eliminado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualizar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Actualizar()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = controladora.Usuarios();
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El campo 'Email' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("El campo 'Clave' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo 'Usuario' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio.", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }

            return true;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            txtNombre.Text = usuario.Nombre;
            txtClave.Text = usuario.Clave;
            txtRepetirClave.Text = usuario.Clave;
            txtApellido.Text = usuario.Apellido;
            cmbEstado.Text = usuario.Estado;
            txtUsuario.Enabled = false;
            txtEmail.Enabled = false;
        }
    }
}
