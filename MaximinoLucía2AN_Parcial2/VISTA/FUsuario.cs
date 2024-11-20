using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FUsuario : Form
    {
        private readonly Usuario usuario;
        private readonly bool modifica = false;
        public FUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
            ActualizarGrillaGrupos();
            CargarCbGrupos();
        }
        public FUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            modifica = true;
            ActualizarGrillaGrupos();
            CargarCbGrupos();
        }
        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);
            return Convert.ToBase64String(key);
        }
        private void ActualizarGrillaGrupos()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = usuario.Grupos;
        }
        private void CargarCbGrupos()
        {
            cbGrupo.DataSource = null;
            var listaGrupos = CONTROLADORA.ControladoraUsuarios.Instancia.RecuperarGrupos();
            cbGrupo.DataSource = listaGrupos;
        }
        private bool EstadoHabilitado()
        {
            if (rbHabilitado.Checked)
            {
                return true;
            }
            else { return false; }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modifica)
            {
                usuario.Clave = Encrypt(txtNombreUsuario.Text, txtClave.Text);
                if (EstadoHabilitado())
                {
                    usuario.Estado = rbHabilitado.Checked;
                }
                else
                {
                    usuario.Estado = rbInhabilitado.Checked;
                }
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                var mensaje = CONTROLADORA.ControladoraUsuarios.Instancia.ModificarUsuario(usuario);
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
            }
            else
            {
                usuario.NombreUsuario = txtNombreUsuario.Text;
                usuario.Email = txtEmail.Text;
                usuario.Clave = Encrypt(txtNombreUsuario.Text, txtClave.Text);
                if (EstadoHabilitado())
                {
                    usuario.Estado = rbHabilitado.Checked;
                }
                else
                {
                    usuario.Estado = rbInhabilitado.Checked;
                }
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                var mensaje = CONTROLADORA.ControladoraUsuarios.Instancia.AgregarUsuario(usuario);
                if (mensaje != null)
                {
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK);
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregaGrupo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cbGrupo.Text))
            {
                MessageBox.Show("Debe elegir un grupo", "Atención", MessageBoxButtons.OK);
                return;
            }
            var grupoUsuario = cbGrupo.Text;
            var grupoEncontrado = CONTROLADORA.ControladoraUsuarios.Instancia.RecuperarGrupos().FirstOrDefault(g => g.TipoGrupo == grupoUsuario);
            var grupoYaAsignado = usuario.Grupos.FirstOrDefault(g => g.TipoGrupo == grupoUsuario);
            if (grupoYaAsignado != null)
            {
                MessageBox.Show("El grupo ya está asignado a este usuario", "Atención", MessageBoxButtons.OK);
                return;
            }
            var respuesta = CONTROLADORA.ControladoraUsuarios.Instancia.AsignarGrupoAUsuario(usuario, grupoEncontrado);
            if (respuesta != null)
            {
                MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK);
            }
            ActualizarGrillaGrupos();
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            if (modifica && usuario != null)
            {
                this.Text = "Modificar Usuario";
                txtNombreUsuario.Text = usuario.NombreUsuario;
                txtEmail.Text = usuario.Email;
                txtNombreUsuario.Enabled = true;
                txtEmail.Enabled = true;
                txtClave.Text = usuario.Clave;
                if (EstadoHabilitado())
                {
                    rbHabilitado.Checked = true;
                }
                else
                {
                    rbInhabilitado.Checked = false;
                }
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
            }
            else
            {
                this.Text = "Agregar Usuario";
            }
            CargarCbGrupos();
            ActualizarGrillaGrupos();
        }
    }
}
