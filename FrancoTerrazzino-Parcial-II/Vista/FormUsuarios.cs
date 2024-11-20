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
        ControladoraUsuarios conUsuarios = new ControladoraUsuarios();
        private List<Grupo> rolesDelusuario = new List<Grupo>();
        int index;
        string nombreusuario;
        string email;
        bool estado = false;

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarGrillas();
            cmbRollDeGrupo.DataSource = null;
            cmbRollDeGrupo.DataSource = conUsuarios.LeerGrupos();
        }

        public Usuario ValidarCampos()
        {
            if (txtNombreDeUsuario.Text != "" && txtEmail.Text != "" && txtClave.Text != "" && txtNmbre.Text != "" && txtApellido.Text != "" && rolesDelusuario.Count > 0 && txtSegundaClave.Text==txtClave.Text)
            {
                Usuario usuario = new Usuario()
                {
                    NombreDeUsuario = txtNombreDeUsuario.Text,
                    Email = txtEmail.Text,
                    Clave = txtClave.Text,
                    Nombre = txtNmbre.Text,
                    Apellido = txtApellido.Text,
                    Estado = estado,
                };
                foreach (Grupo gru in rolesDelusuario)
                {
                    usuario.AgregarRoll(gru);
                }
                return usuario;
            }
            else
            {
                return null;
            }
        }

        private void ActualizarGrillas()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = conUsuarios.LeerUsuarios();

            dgvRoles.DataSource = null;
            dgvRoles.DataSource = rolesDelusuario;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            nombreusuario = dgvUsuarios.Rows[index].Cells[1].Value.ToString();
            email = dgvUsuarios.Rows[index].Cells[2].Value.ToString();
            var busqueda = conUsuarios.LeerUsuarios().FirstOrDefault(u => u.NombreDeUsuario == nombreusuario);
            txtNombreDeUsuario.Text = busqueda.NombreDeUsuario;
            txtNmbre.Text = busqueda.Nombre;
            txtApellido.Text = busqueda.Apellido;
            txtEmail.Text = busqueda.Email;
            txtClave.Text = busqueda.Clave;
            checkEstado.Checked = busqueda.Estado;
            rolesDelusuario.Clear();
            foreach (Grupo gru in busqueda.GruposDelUsuario)
            {
                rolesDelusuario.Add(gru);
            }
            ActualizarGrillas();
        }

        private void btnAsignarRoll_Click(object sender, EventArgs e)
        {
            var busqueda = conUsuarios.LeerGrupos().FirstOrDefault(gru => gru.NombreDelGrupo == cmbRollDeGrupo.Text);
            var filtrarLista = rolesDelusuario.FirstOrDefault(gr=>gr.NombreDelGrupo==busqueda.NombreDelGrupo);
            if (filtrarLista == null)
            {
                rolesDelusuario.Add(busqueda);
                ActualizarGrillas();
            }

        }

        private void btnCargarUsuari_Click(object sender, EventArgs e)
        {
            var usuario = ValidarCampos();
            if (usuario != null)
            {
                conUsuarios.RegistrarUsuario(usuario);
                rolesDelusuario.Clear();
                ActualizarGrillas();
            }
        }

        private void checkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (estado == false)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            var buscar = conUsuarios.LeerUsuarios().FirstOrDefault(u => u.NombreDeUsuario == nombreusuario);
            conUsuarios.ModificarUsuario(buscar);
            ActualizarGrillas();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var buscar = conUsuarios.LeerUsuarios().FirstOrDefault(u => u.NombreDeUsuario == nombreusuario);
            conUsuarios.EliminarUsuario(buscar);
            ActualizarGrillas();
        }
    }
}
