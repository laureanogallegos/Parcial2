namespace Vista
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            btnSalir = new Button();
            dgvUsuarios = new DataGridView();
            gBoxGrupo = new GroupBox();
            label9 = new Label();
            txtApellido = new TextBox();
            label7 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            chBoxEstado = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            txtConfirmacionClave = new TextBox();
            txtClave = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            chBoxListGrupos = new CheckedListBox();
            label8 = new Label();
            dgvGruposDelUsuario = new DataGridView();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gBoxGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGruposDelUsuario).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 185);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Usuarios:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(830, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(318, 209);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(473, 159);
            dgvUsuarios.TabIndex = 9;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // gBoxGrupo
            // 
            gBoxGrupo.Controls.Add(label9);
            gBoxGrupo.Controls.Add(txtApellido);
            gBoxGrupo.Controls.Add(label7);
            gBoxGrupo.Controls.Add(txtNombre);
            gBoxGrupo.Controls.Add(label6);
            gBoxGrupo.Controls.Add(chBoxEstado);
            gBoxGrupo.Controls.Add(label4);
            gBoxGrupo.Controls.Add(label5);
            gBoxGrupo.Controls.Add(txtConfirmacionClave);
            gBoxGrupo.Controls.Add(txtClave);
            gBoxGrupo.Controls.Add(btnEliminar);
            gBoxGrupo.Controls.Add(btnModificar);
            gBoxGrupo.Controls.Add(btnAgregar);
            gBoxGrupo.Controls.Add(label2);
            gBoxGrupo.Controls.Add(label1);
            gBoxGrupo.Controls.Add(txtEmail);
            gBoxGrupo.Controls.Add(txtNombreUsuario);
            gBoxGrupo.Location = new Point(21, 18);
            gBoxGrupo.Name = "gBoxGrupo";
            gBoxGrupo.Size = new Size(261, 409);
            gBoxGrupo.TabIndex = 8;
            gBoxGrupo.TabStop = false;
            gBoxGrupo.Text = "Datos grupo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 297);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 16;
            label9.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(139, 289);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 265);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 14;
            label7.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 257);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 220);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 12;
            label6.Text = "¿Habilitado?";
            // 
            // chBoxEstado
            // 
            chBoxEstado.AutoSize = true;
            chBoxEstado.Location = new Point(179, 220);
            chBoxEstado.Name = "chBoxEstado";
            chBoxEstado.Size = new Size(15, 14);
            chBoxEstado.TabIndex = 11;
            chBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 175);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 10;
            label4.Text = "Confirmar clave:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 129);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Clave:";
            // 
            // txtConfirmacionClave
            // 
            txtConfirmacionClave.Location = new Point(139, 167);
            txtConfirmacionClave.Name = "txtConfirmacionClave";
            txtConfirmacionClave.Size = new Size(100, 23);
            txtConfirmacionClave.TabIndex = 8;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(139, 129);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(21, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(218, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(21, 347);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(218, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(21, 318);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(218, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre usuario:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(139, 47);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // chBoxListGrupos
            // 
            chBoxListGrupos.FormattingEnabled = true;
            chBoxListGrupos.Location = new Point(318, 68);
            chBoxListGrupos.Name = "chBoxListGrupos";
            chBoxListGrupos.Size = new Size(293, 94);
            chBoxListGrupos.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(318, 47);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 13;
            label8.Text = "Grupos:";
            // 
            // dgvGruposDelUsuario
            // 
            dgvGruposDelUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGruposDelUsuario.Location = new Point(809, 209);
            dgvGruposDelUsuario.Name = "dgvGruposDelUsuario";
            dgvGruposDelUsuario.Size = new Size(102, 159);
            dgvGruposDelUsuario.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(809, 185);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 15;
            label10.Text = "Grupos del usuario:";
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 433);
            Controls.Add(label10);
            Controls.Add(dgvGruposDelUsuario);
            Controls.Add(label8);
            Controls.Add(chBoxListGrupos);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(dgvUsuarios);
            Controls.Add(gBoxGrupo);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gBoxGrupo.ResumeLayout(false);
            gBoxGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGruposDelUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnSalir;
        private DataGridView dgvUsuarios;
        private GroupBox gBoxGrupo;
        private Label label7;
        private TextBox txtNombre;
        private Label label6;
        private CheckBox chBoxEstado;
        private Label label4;
        private Label label5;
        private TextBox txtConfirmacionClave;
        private TextBox txtClave;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private CheckedListBox chBoxListGrupos;
        private Label label8;
        private Label label9;
        private TextBox txtApellido;
        private DataGridView dgvGruposDelUsuario;
        private Label label10;
    }
}