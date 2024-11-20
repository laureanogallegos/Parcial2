using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormUsuarios : Form
    {
        ControladoraUsuarios controladoraUsuarios;
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreDeUsuario = txtNombreUsuario.Text;
            usuario.Mail = TxtMail.Text;
            usuario.clave = txtClave.Text;
            usuario.Estado = cmbGrupo.ToString();
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            if (txtClave != txtVerificarClave)
            {
                if (controladoraUsuarios.AgregarUsuario(usuario))
                {
                    MessageBox.Show("Se agrego el usuario");
                }
                else
                {
                    MessageBox.Show("No se puedo agregar usuario");
                }
            }
            else MessageBox.Show("Las claves no coinciden");


        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
