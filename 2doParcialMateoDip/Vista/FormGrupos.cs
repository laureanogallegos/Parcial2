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
    public partial class FormGrupos : Form
    {
        ControladoraGrupos controladora;
        public FormGrupos()
        {
            InitializeComponent();
            controladora = new ControladoraGrupos();
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo()
            {
                CodigoGrupo = txtCodigo.Text,
                Rol = txtRol.Text,
            };

            if (controladora.AgregarGrupo(grupo))
            {
                MessageBox.Show("Exito en la carga.");
                ActualizarGrilla();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo()
            {
                CodigoGrupo = txtCodigo.Text,
                Rol = txtRol.Text,
            };
            var grupoSeleccionado = dgvGrupos.CurrentRow.DataBoundItem as Grupo;
            if (grupoSeleccionado.CodigoGrupo == grupo.CodigoGrupo)
            {
                if (controladora.ModificarGrupo(grupo))
                {
                    MessageBox.Show("Exito en la modificacion.");
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar.");
                }
            }
            else
            {
                MessageBox.Show("El codigo de grupo no se puede modificar.");
            }            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var grupoSeleccionado = dgvGrupos.CurrentRow.DataBoundItem as Grupo;
            if (controladora.EliminarGrupo(grupoSeleccionado))
            {
                MessageBox.Show("Exito en la eliminacion.");
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarGrilla()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = controladora.ListarGrupo();
        }
    }
}
