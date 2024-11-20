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
    public partial class FormUsuario : Form
    {
        private Usuario usuario;
        private bool modifica = false;
        public FormUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
        }

        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            modifica = true;
            this.usuario = usuario;
        }

        private bool verificarDatos()
        {
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El Apellido no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El Nombre no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("El Nombre de Usuario no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("El Email no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("La clave no puede ser nula");
                return false;
            }
            if (string.IsNullOrEmpty(txtClave2.Text))
            {
                MessageBox.Show("La repeticion de la clave no puede ser nula");
                return false;
            }
            if (txtClave.Text != txtClave2.Text)
            {
                MessageBox.Show("Las claves deben ser iguales");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                if (dgvGrupos.Rows.Count > 0)
                {
                    usuario.Nombre = txtNombre.Text;
                    usuario.Apellido = txtApellido.Text;
                    usuario.Clave = txtClave.Text;
                    usuario.Estado = checkBoxEstado.Checked;
                    usuario.Email = txtEmail.Text;
                    usuario.NombreDeUsuario = txtNombreUsuario.Text;
                    if (modifica)
                    {
                        var modificado = ControladoraUsuarios.Instance.ModificarUsuario(usuario);
                        if (modificado)
                        {
                            MessageBox.Show("Usuario Modificado con exito");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el usuario");
                        }
                    }
                    else
                    {
                        var agregado = ControladoraUsuarios.Instance.AgregarUsuario(usuario);
                        if (agregado)
                        {
                            MessageBox.Show("Usuario Agregado con exito");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el usuario");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe tener agregado como minimo un rol el usuario");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.Rows.Count > 0)
            {
                var grupo = (Grupo)dgvGrupos.CurrentRow.DataBoundItem;
                var eliminado = usuario.EliminarGrupo(grupo);
                if (eliminado)
                {
                    MessageBox.Show("Grupo eliminado con exito del usuario");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el grupo");
                }
                ActualizarDgv();
                ActualizarCBoxGrupos();
            }
            else
            {
                MessageBox.Show("No hay nada para eliminar");
            }
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            if (cBoxGrupos.Items.Count > 0)
            {
                var grupos = ControladoraUsuarios.Instance.RecuperarGrupos();

                var rolGrupo = cBoxGrupos.SelectedItem;
                var grupoElegido = grupos.FirstOrDefault(c => c.Rol == rolGrupo);
                var agregado = usuario.AgregarGrupo(grupoElegido);
                if (agregado)
                {
                    MessageBox.Show("Grupo agregado con exito al usuario");
                }
                else
                {
                    MessageBox.Show("Error al agregar el grupo");
                }
                ActualizarDgv();
                ActualizarCBoxGrupos();
            }
            else
            {
                MessageBox.Show("No hay nada para agregar");
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            if (modifica)
            {
                txtApellido.Text = usuario.Apellido;
                txtEmail.Text = usuario.Email;
                txtNombre.Text = usuario.Nombre;
                txtNombreUsuario.Text = usuario.NombreDeUsuario;
                txtNombreUsuario.Enabled = false;
                txtEmail.Enabled = false;
                checkBoxEstado.Checked = usuario.Estado;
            }
            ActualizarDgv();
            ActualizarCBoxGrupos();
        }

        private void ActualizarDgv()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = usuario.Grupos.AsReadOnly();
        }

        private void ActualizarCBoxGrupos()
        {
            cBoxGrupos.Items.Clear();
            var grupos = ControladoraUsuarios.Instance.RecuperarGrupos();
            foreach (var grupo in grupos) 
            {
                var yaAgregado = usuario.Grupos.FirstOrDefault(c => c.Rol == grupo.Rol);
                if (yaAgregado == null)
                {
                    cBoxGrupos.Items.Add(grupo.Rol);
                }
            }

            cBoxGrupos.DisplayMember = "Rol";
        }
    }
}
