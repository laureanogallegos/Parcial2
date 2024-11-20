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
    public partial class Usuarios : Form
    {
        private ControladoraUsuarios controladoraUsuarios;
        public Usuarios()
        {
            controladoraUsuarios = new ControladoraUsuarios();
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario();

                usuario.Nombre = txt_Nombre.Text;
                usuario.Apellido = txt_Apellido.Text;
                usuario.Correo = txtCorreo.Text;
                usuario.NombreUsuario = txt_Usuario.Text;
                usuario.Estado = chk_Estado.Checked;
                usuario.Clave = txt_Password.Text;

                if (controladoraUsuarios.CrearUsuario(usuario))
                {
                    MessageBox.Show("El usuario se creo exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario ya existe.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
            {
                if (dgv_Usuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Usuario? usuario = dgv_Usuarios.SelectedRows[0].DataBoundItem as Usuario;

                if (controladoraUsuarios.EliminarUsuario(usuario))
                {
                    MessageBox.Show("El usuario   se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarVista();
                }
                else
                {
                    MessageBox.Show("El usuario   se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

            private void Usuarios_Load(object sender, EventArgs e)
            {
                RefrescarVista();
            }

            private bool ValidarCampos()
            {
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    MessageBox.Show("El campo nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txt_Apellido.Text))
                {
                    MessageBox.Show("El campo apellido no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txt_Usuario.Text))
                {
                    MessageBox.Show("El campo usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("El campo correo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    MessageBox.Show("El campo password no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txt_Confirmar.Text))
                {
                    MessageBox.Show("El campo confirmar password no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txt_Confirmar.Text != txt_Password.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

              private void RefrescarVista()
              {
                dgv_Usuarios.AutoGenerateColumns = false;
                dgv_Usuarios.DataSource = controladoraUsuarios.RecuperarUsuarios();

               }

        
    }
}
