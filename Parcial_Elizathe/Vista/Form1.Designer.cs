namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gboxProductos = new GroupBox();
            dgv = new DataGridView();
            gboxControles = new GroupBox();
            txtConfirmarClave = new TextBox();
            label7 = new Label();
            cmbEstado = new ComboBox();
            label6 = new Label();
            checkboxGrupos = new CheckedListBox();
            label9 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtClave = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtNombreUsuario = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gboxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            gboxControles.SuspendLayout();
            SuspendLayout();
            // 
            // gboxProductos
            // 
            gboxProductos.Controls.Add(dgv);
            gboxProductos.ForeColor = SystemColors.ControlText;
            gboxProductos.Location = new Point(342, 11);
            gboxProductos.Margin = new Padding(3, 2, 3, 2);
            gboxProductos.Name = "gboxProductos";
            gboxProductos.Padding = new Padding(3, 2, 3, 2);
            gboxProductos.Size = new Size(647, 444);
            gboxProductos.TabIndex = 9;
            gboxProductos.TabStop = false;
            gboxProductos.Text = "Usuarios";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(5, 20);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(635, 416);
            dgv.TabIndex = 0;
            // 
            // gboxControles
            // 
            gboxControles.Controls.Add(txtConfirmarClave);
            gboxControles.Controls.Add(label7);
            gboxControles.Controls.Add(cmbEstado);
            gboxControles.Controls.Add(label6);
            gboxControles.Controls.Add(checkboxGrupos);
            gboxControles.Controls.Add(label9);
            gboxControles.Controls.Add(btnEliminar);
            gboxControles.Controls.Add(btnModificar);
            gboxControles.Controls.Add(btnAgregar);
            gboxControles.Controls.Add(txtClave);
            gboxControles.Controls.Add(txtEmail);
            gboxControles.Controls.Add(txtApellido);
            gboxControles.Controls.Add(txtNombre);
            gboxControles.Controls.Add(txtNombreUsuario);
            gboxControles.Controls.Add(label5);
            gboxControles.Controls.Add(label4);
            gboxControles.Controls.Add(label3);
            gboxControles.Controls.Add(label2);
            gboxControles.Controls.Add(label1);
            gboxControles.ForeColor = SystemColors.ActiveCaptionText;
            gboxControles.Location = new Point(12, 11);
            gboxControles.Margin = new Padding(3, 2, 3, 2);
            gboxControles.Name = "gboxControles";
            gboxControles.Padding = new Padding(3, 2, 3, 2);
            gboxControles.Size = new Size(326, 472);
            gboxControles.TabIndex = 8;
            gboxControles.TabStop = false;
            gboxControles.Text = "Controles";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(194, 162);
            txtConfirmarClave.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(130, 23);
            txtConfirmarClave.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(5, 165);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 25;
            label7.Text = "Confirmar Clave:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Habilitado", "Inhabilitado" });
            cmbEstado.Location = new Point(191, 192);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(130, 23);
            cmbEstado.TabIndex = 24;
            cmbEstado.DropDownStyleChanged += DropDownList;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 187);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 23;
            label6.Text = "Estado:";
            // 
            // checkboxGrupos
            // 
            checkboxGrupos.FormattingEnabled = true;
            checkboxGrupos.Location = new Point(191, 220);
            checkboxGrupos.Margin = new Padding(3, 2, 3, 2);
            checkboxGrupos.Name = "checkboxGrupos";
            checkboxGrupos.Size = new Size(130, 40);
            checkboxGrupos.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(5, 219);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 19;
            label9.Text = "Grupos:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(13, 423);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(297, 45);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Location = new Point(13, 374);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(297, 45);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar ";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(13, 324);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(297, 45);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(191, 135);
            txtClave.Margin = new Padding(3, 2, 3, 2);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(130, 23);
            txtClave.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 104);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(191, 74);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 45);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(191, 16);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(130, 23);
            txtNombreUsuario.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(5, 136);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Clave:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 105);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(5, 75);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(5, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre De Usuario:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 514);
            Controls.Add(gboxProductos);
            Controls.Add(gboxControles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gboxProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            gboxControles.ResumeLayout(false);
            gboxControles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxProductos;
        private DataGridView dgv;
        private GroupBox gboxControles;
        private CheckedListBox checkboxGrupos;
        private Label label9;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtClave;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtNombreUsuario;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox cmbEstado;
        private TextBox txtConfirmarClave;
        private Label label7;
    }
}
