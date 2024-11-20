namespace VISTA
{
    partial class FUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            rbInhabilitado = new RadioButton();
            rbHabilitado = new RadioButton();
            txtNombreUsuario = new TextBox();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label7 = new Label();
            cbGrupo = new ComboBox();
            dgvGrupos = new DataGridView();
            btnAgregaGrupo = new Button();
            btnQuitaGrupo = new Button();
            txtReingresarClave = new TextBox();
            label8 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 48);
            label1.TabIndex = 0;
            label1.Text = "Datos Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 104);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 140);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 3;
            label4.Text = "Clave:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 326);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Nombre: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 361);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 5;
            label6.Text = "Apellido:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbInhabilitado);
            groupBox1.Controls.Add(rbHabilitado);
            groupBox1.Location = new Point(11, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 105);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // rbInhabilitado
            // 
            rbInhabilitado.AutoSize = true;
            rbInhabilitado.Location = new Point(12, 62);
            rbInhabilitado.Name = "rbInhabilitado";
            rbInhabilitado.Size = new Size(131, 29);
            rbInhabilitado.TabIndex = 6;
            rbInhabilitado.TabStop = true;
            rbInhabilitado.Text = "Inhabilitado";
            rbInhabilitado.UseVisualStyleBackColor = true;
            // 
            // rbHabilitado
            // 
            rbHabilitado.AutoSize = true;
            rbHabilitado.Location = new Point(12, 30);
            rbHabilitado.Name = "rbHabilitado";
            rbHabilitado.Size = new Size(119, 29);
            rbHabilitado.TabIndex = 5;
            rbHabilitado.TabStop = true;
            rbHabilitado.Text = "Habilitado";
            rbHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(195, 67);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(214, 31);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(328, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(81, 141);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(328, 31);
            txtClave.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 323);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(100, 361);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(309, 31);
            txtApellido.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 67);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 12;
            label7.Text = "Grupo: ";
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(512, 64);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(352, 33);
            cbGrupo.TabIndex = 9;
            // 
            // dgvGrupos
            // 
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(448, 122);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.RowHeadersWidth = 62;
            dgvGrupos.Size = new Size(416, 212);
            dgvGrupos.TabIndex = 14;
            // 
            // btnAgregaGrupo
            // 
            btnAgregaGrupo.Location = new Point(499, 345);
            btnAgregaGrupo.Name = "btnAgregaGrupo";
            btnAgregaGrupo.Size = new Size(153, 47);
            btnAgregaGrupo.TabIndex = 10;
            btnAgregaGrupo.Text = "Añadir Grupo";
            btnAgregaGrupo.UseVisualStyleBackColor = true;
            btnAgregaGrupo.Click += btnAgregaGrupo_Click;
            // 
            // btnQuitaGrupo
            // 
            btnQuitaGrupo.Location = new Point(658, 345);
            btnQuitaGrupo.Name = "btnQuitaGrupo";
            btnQuitaGrupo.Size = new Size(147, 47);
            btnQuitaGrupo.TabIndex = 11;
            btnQuitaGrupo.Text = "Quitar Grupo";
            btnQuitaGrupo.UseVisualStyleBackColor = true;
            // 
            // txtReingresarClave
            // 
            txtReingresarClave.Location = new Point(159, 178);
            txtReingresarClave.Name = "txtReingresarClave";
            txtReingresarClave.Size = new Size(250, 31);
            txtReingresarClave.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 177);
            label8.Name = "label8";
            label8.Size = new Size(145, 25);
            label8.TabIndex = 17;
            label8.Text = "Reingresar Clave:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(402, 423);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 49);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(284, 423);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 49);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 482);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtReingresarClave);
            Controls.Add(label8);
            Controls.Add(btnQuitaGrupo);
            Controls.Add(btnAgregaGrupo);
            Controls.Add(dgvGrupos);
            Controls.Add(cbGrupo);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            Load += FUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton rbInhabilitado;
        private RadioButton rbHabilitado;
        private TextBox txtNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label7;
        private ComboBox cbGrupo;
        private DataGridView dgvGrupos;
        private Button btnAgregaGrupo;
        private Button btnQuitaGrupo;
        private TextBox txtReingresarClave;
        private Label label8;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}