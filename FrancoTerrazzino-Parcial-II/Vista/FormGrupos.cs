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
        public FormGrupos()
        {
            InitializeComponent();
        }
        ControladoraGrupos conGrupos = new ControladoraGrupos();
        int index;
        string nombre;

        private Grupo ValidarCampo()
        {
            if (cmbGrupos.Text != "")
            {
                Grupo grupo = new Grupo()
                {
                    NombreDelGrupo = cmbGrupos.Text,
                };
                return grupo;
            }
            else
            {
                return null;
            }
        }

        private void btnRegistrarGrupo_Click(object sender, EventArgs e)
        {
            var grup = ValidarCampo();
            if (grup != null)
            {
                conGrupos.RegistrarGrupo(grup);
                ActualizarGrilla();
            }
        }

        private void btnModificarGrupo_Click(object sender, EventArgs e)
        {
            var busqueda = conGrupos.LeerGrupos().FirstOrDefault(gru => gru.NombreDelGrupo == nombre);
            conGrupos.ModificarUsuario(busqueda);
            ActualizarGrilla();
        }

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            nombre = dgvGrupos.Rows[index].Cells[1].Value.ToString();
        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvGrupos.DataSource = null;
            dgvGrupos.DataSource = conGrupos.LeerGrupos();
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            var busqueda = conGrupos.LeerGrupos().FirstOrDefault(gru => gru.NombreDelGrupo == nombre);
            conGrupos.EliminarUsuario(busqueda);
            ActualizarGrilla();
        }
    }
}
