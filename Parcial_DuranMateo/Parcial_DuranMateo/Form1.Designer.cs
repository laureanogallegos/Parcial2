namespace Parcial_DuranMateo
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
            dgvUsuario = new DataGridView();
            label1 = new Label();
            gbDatos = new GroupBox();
            gbEstado = new GroupBox();
            label4 = new Label();
            rbInhabilitado = new RadioButton();
            rbHabilitado = new RadioButton();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            gbGrupo = new GroupBox();
            rbInvitado = new RadioButton();
            rbAdministrador = new RadioButton();
            rbUsuario = new RadioButton();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtUsuario = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            gbDatos.SuspendLayout();
            gbEstado.SuspendLayout();
            gbGrupo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(12, 219);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(634, 150);
            dgvUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de usuario:";
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(gbEstado);
            gbDatos.Controls.Add(btnModificar);
            gbDatos.Controls.Add(btnEliminar);
            gbDatos.Controls.Add(btnAgregar);
            gbDatos.Controls.Add(gbGrupo);
            gbDatos.Controls.Add(txtClave);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(txtApellido);
            gbDatos.Controls.Add(txtEmail);
            gbDatos.Controls.Add(txtUsuario);
            gbDatos.Controls.Add(label7);
            gbDatos.Controls.Add(label5);
            gbDatos.Controls.Add(label3);
            gbDatos.Controls.Add(label2);
            gbDatos.Controls.Add(label1);
            gbDatos.Location = new Point(12, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(650, 167);
            gbDatos.TabIndex = 2;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // gbEstado
            // 
            gbEstado.Controls.Add(label4);
            gbEstado.Controls.Add(rbInhabilitado);
            gbEstado.Controls.Add(rbHabilitado);
            gbEstado.Location = new Point(199, 90);
            gbEstado.Name = "gbEstado";
            gbEstado.Size = new Size(195, 71);
            gbEstado.TabIndex = 25;
            gbEstado.TabStop = false;
            gbEstado.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 19);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 4;
            label4.Click += label4_Click;
            // 
            // rbInhabilitado
            // 
            rbInhabilitado.AutoSize = true;
            rbInhabilitado.Location = new Point(6, 31);
            rbInhabilitado.Name = "rbInhabilitado";
            rbInhabilitado.Size = new Size(80, 19);
            rbInhabilitado.TabIndex = 15;
            rbInhabilitado.TabStop = true;
            rbInhabilitado.Text = "Habilitado";
            rbInhabilitado.UseVisualStyleBackColor = true;
            // 
            // rbHabilitado
            // 
            rbHabilitado.AutoSize = true;
            rbHabilitado.Location = new Point(92, 31);
            rbHabilitado.Name = "rbHabilitado";
            rbHabilitado.Size = new Size(88, 19);
            rbHabilitado.TabIndex = 14;
            rbHabilitado.TabStop = true;
            rbHabilitado.Text = "Inhabilitado";
            rbHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(491, 121);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(76, 23);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(568, 121);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(76, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(409, 121);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(76, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbGrupo
            // 
            gbGrupo.Controls.Add(rbInvitado);
            gbGrupo.Controls.Add(rbAdministrador);
            gbGrupo.Controls.Add(rbUsuario);
            gbGrupo.Location = new Point(409, 22);
            gbGrupo.Name = "gbGrupo";
            gbGrupo.Size = new Size(225, 85);
            gbGrupo.TabIndex = 24;
            gbGrupo.TabStop = false;
            gbGrupo.Text = "Grupo";
            // 
            // rbInvitado
            // 
            rbInvitado.AutoSize = true;
            rbInvitado.Location = new Point(145, 39);
            rbInvitado.Name = "rbInvitado";
            rbInvitado.Size = new Size(68, 19);
            rbInvitado.TabIndex = 21;
            rbInvitado.TabStop = true;
            rbInvitado.Text = "Invitado";
            rbInvitado.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            rbAdministrador.AutoSize = true;
            rbAdministrador.Location = new Point(6, 39);
            rbAdministrador.Name = "rbAdministrador";
            rbAdministrador.Size = new Size(101, 19);
            rbAdministrador.TabIndex = 19;
            rbAdministrador.TabStop = true;
            rbAdministrador.Text = "Administrador";
            rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbUsuario
            // 
            rbUsuario.AutoSize = true;
            rbUsuario.Location = new Point(93, 60);
            rbUsuario.Name = "rbUsuario";
            rbUsuario.Size = new Size(65, 19);
            rbUsuario.TabIndex = 20;
            rbUsuario.TabStop = true;
            rbUsuario.Text = "Usuario";
            rbUsuario.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(63, 117);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(294, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(294, 60);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(132, 26);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 63);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 7;
            label7.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 32);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Clave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(586, 375);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(76, 23);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 405);
            Controls.Add(btnCerrar);
            Controls.Add(gbDatos);
            Controls.Add(dgvUsuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbEstado.ResumeLayout(false);
            gbEstado.PerformLayout();
            gbGrupo.ResumeLayout(false);
            gbGrupo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox gbDatos;
        private RadioButton rbInhabilitado;
        private RadioButton rbHabilitado;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtUsuario;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnCerrar;
        private RadioButton rbInvitado;
        private RadioButton rbUsuario;
        private RadioButton rbAdministrador;
        private DataGridView dgvUsuario;
        private GroupBox gbEstado;
        private GroupBox gbGrupo;
    }
}
