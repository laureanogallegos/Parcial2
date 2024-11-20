using Controladora;
using Modelo;

namespace FasolatoLucas2AN
{
    public partial class Form1 : Form
    {
        UsuarioControladora controladora;
        public Form1()
        {
            controladora = new UsuarioControladora();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cblGrupos.DataSource = null;
            cblGrupos.DataSource = controladora.RecuperarGrupos();
            ActualizarVista();
        }

        private void BtnOpciones_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(cbOpciones.SelectedIndex == 0)
                {
                    Usuario usuario = new Usuario();
                    usuario.NombreUsuario = txtNombreUsuario.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Estado = cbValido.Checked;
                    usuario.Clave = txtClave2.Text;
                    var grupos = cblGrupos.CheckedItems;
                    //foreach (gr in grupos)
                    //{
                    //    usuario.AgregarGrupo(gr);
                    //}
                    controladora.CrearUsuario(usuario);
                } else if (cbOpciones.SelectedIndex == 1)
                {
                    Usuario usuario = new Usuario();
                    usuario.NombreUsuario = txtNombreUsuario.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Estado = cbValido.Checked;
                    usuario.Clave = txtClave2.Text;
                    var grupos = cblGrupos.CheckedItems;
                    //foreach (gr in grupos)
                    //{
                    //    usuario.AgregarGrupo(gr);
                    //}
                    controladora.ModificarUsuario(usuario);
                }
                else if (cbOpciones.SelectedIndex == 2)
                {
                    Usuario usuario = new Usuario();
                    if (txtNombreUsuario.Text != "")
                        usuario.NombreUsuario = txtNombreUsuario.Text;
                    if (txtEmail.Text != "")
                        usuario.Email = txtEmail.Text;
                    controladora.EliminarUsuario(usuario);
                }
            }
        }

        public void ActualizarVista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controladora.RecuperarUsuarios();
        }

        public void LimpiarCampos()
        {
            txtNombreUsuario.Text = null;
            txtEmail.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtClave.Text = null;
            txtClave2.Text = null;
            cbValido.Checked = false;
            //cblGrupos.CheckedItems = null;
        }

        public bool ValidarDatos()
        {
            if(cbOpciones.SelectedIndex == 0 || cbOpciones.SelectedIndex == 1)
            {
                if(txtNombreUsuario.Text != "" && txtEmail.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtClave.Text != "" && txtClave2.Text != "" && cblGrupos.CheckedItems.Count > 0 && txtClave.Text == txtClave2.Text)
                {
                    return true;
                }
            } else if (cbOpciones.SelectedIndex == 2)
            {
                if (txtNombreUsuario.Text != "" || txtEmail.Text != "")
                {
                    return true;
                }
            }
            return false;
        }

        private void cbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            switch (cbOpciones.SelectedIndex) {
                case 0:
                    txtNombreUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtClave.Enabled = true;
                    txtClave2.Enabled = true;
                    lblNombreUsuario.Enabled = true;
                    lblEmail.Enabled = true;
                    lblNombre.Enabled = true;
                    lblApellido.Enabled = true;
                    lblClave.Enabled = true;
                    lblClave2.Enabled = true;
                    cbValido.Enabled = true;
                    cblGrupos.Enabled = true;
                    BtnOpciones.Text = "AGREGAR";
                    break;
                case 1:
                    txtNombreUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtClave.Enabled = true;
                    txtClave2.Enabled = true;
                    lblNombreUsuario.Enabled = true;
                    lblEmail.Enabled = true;
                    lblNombre.Enabled = true;
                    lblApellido.Enabled = true;
                    lblClave.Enabled = true;
                    lblClave2.Enabled = true;
                    cbValido.Enabled = true;
                    cblGrupos.Enabled = true;
                    BtnOpciones.Text = "MODIFICAR";
                    break;
                case 2:
                    txtNombreUsuario.Enabled = true;
                    txtEmail.Enabled = true;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtClave.Enabled = false;
                    txtClave2.Enabled = false;
                    lblNombreUsuario.Enabled = true;
                    lblEmail.Enabled = true;
                    lblNombre.Enabled = false;
                    lblApellido.Enabled = false;
                    lblClave.Enabled = false;
                    lblClave2.Enabled = false;
                    cbValido.Enabled = false;
                    cblGrupos.Enabled = false;
                    BtnOpciones.Text = "ELIMINAR";
                    break;
            }
        }
    }
}
