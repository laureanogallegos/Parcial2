﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUsuarios formusarios = new FormUsuarios();
            formusarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGrupo formGrupo = new FormGrupo();
            formGrupo.Show();
        }
    }
}
