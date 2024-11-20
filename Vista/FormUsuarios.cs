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
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form form = new FormUsuario();
            form.ShowDialog();
            ActualizarVista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                Form form = new FormUsuario(usuario);
                form.ShowDialog();
                ActualizarVista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var eliminado = ControladoraUsuarios.Instance.EliminarUsuario(usuario);
                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario");
                }
                ActualizarVista();
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = ControladoraUsuarios.Instance.RecuperarUsuarios();
        }
    }
}
