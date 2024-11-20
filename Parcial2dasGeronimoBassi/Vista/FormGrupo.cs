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
    public partial class FormGrupo : Form
    {
        ControladoraGrupos controladoragrupos;
        public FormGrupo()
        {
            controladoragrupos = new ControladoraGrupos();
            InitializeComponent();
        }
        public bool validardatos()
        {

            if (string.IsNullOrEmpty(txtGrupo.Text))
            {
                MessageBox.Show("El campo grupo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void actualizarvista()
        {
            dgvGrupos.DataSource = controladoragrupos.listargrupos();



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                Grupo grupo = new Grupo();
                grupo.Tipo = txtGrupo.Text;
                if (controladoragrupos.AgregarGrupo(grupo))
                {

                    MessageBox.Show("Se agrego correctamente el grupo");
                }
                else MessageBox.Show("No Se agrego correctamente el grupo");


            }

        }
    }
}

