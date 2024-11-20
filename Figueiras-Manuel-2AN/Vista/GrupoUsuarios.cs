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
    public partial class GrupoUsuarios : Form
    {
        private ControladoraGrupos controladoraGrupos;

        public GrupoUsuarios()
        {
            controladoraGrupos = new ControladoraGrupos();
            InitializeComponent();

            txt_Nombre.KeyPress += SoloLetras_KeyPress;
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GrupoUsuario grupoUsuario = new GrupoUsuario();

                grupoUsuario.Nombre = txt_Nombre.Text;

                if (controladoraGrupos.AgregarGrupo(grupoUsuario))
                {
                    MessageBox.Show("El Grupo " + grupoUsuario.Nombre + " se creó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarVista();
                }
                else
                {
                    MessageBox.Show("El Grupo " + grupoUsuario.Nombre + "  ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Grupos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un grupo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            GrupoUsuario? grupoUsuario = dgv_Grupos.SelectedRows[0].DataBoundItem as GrupoUsuario;

            if (controladoraGrupos.EliminarGrupo(grupoUsuario))
            {
                MessageBox.Show("El grupo " + grupoUsuario.Nombre + " se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarVista();
            }
            else
            {
                MessageBox.Show("El grupo " + grupoUsuario.Nombre + " no se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Grupos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un grupo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            GrupoUsuario? grupoUsuario = dgv_Grupos.SelectedRows[0].DataBoundItem as GrupoUsuario;

            if (ValidarCampos())
            {

                grupoUsuario.Nombre = txt_Nombre.Text;

                if (controladoraGrupos.EditarGrupo(grupoUsuario))
                {
                    MessageBox.Show("El Grupo " + grupoUsuario.Nombre + " se editó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarVista();
                }
                else
                {
                    MessageBox.Show("El Grupo " + grupoUsuario.Nombre + "  no se puede editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }


        public bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void RefrescarVista()
        {
            dgv_Grupos.DataSource = null;
            dgv_Grupos.DataSource = controladoraGrupos.RecuperarGrupos();

            txt_Nombre.Text = string.Empty;
        }

        private void dgv_Grupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_Grupos.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    var grupo = Seleccion.DataBoundItem as GrupoUsuario;

                    txt_Nombre.Text = grupo.Nombre.ToString();

                }
            }
        }

        private void GrupoUsuarios_Load(object sender, EventArgs e)
        {
            RefrescarVista();
        }
    }
}
