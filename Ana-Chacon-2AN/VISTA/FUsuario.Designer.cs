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
            lblNombreUsuario = new Label();
            label2 = new Label();
            lblEmail = new Label();
            lblClave = new Label();
            lblNombre = new Label();
            gbEstado = new GroupBox();
            rbInhabilitado = new RadioButton();
            rbHabilitado = new RadioButton();
            lblApellido = new Label();
            gbGrupo = new GroupBox();
            btnQuitarGrupo = new Button();
            btnAgregarGrupo = new Button();
            cbGrupos = new ComboBox();
            lblGrupo = new Label();
            txtNombreUsuario = new TextBox();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            gbEstado.SuspendLayout();
            gbGrupo.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(27, 29);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(142, 20);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 78);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 65);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(27, 102);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(48, 20);
            lblClave.TabIndex = 3;
            lblClave.Text = "Clave:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 246);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // gbEstado
            // 
            gbEstado.Controls.Add(rbInhabilitado);
            gbEstado.Controls.Add(rbHabilitado);
            gbEstado.Location = new Point(27, 137);
            gbEstado.Name = "gbEstado";
            gbEstado.Size = new Size(285, 85);
            gbEstado.TabIndex = 5;
            gbEstado.TabStop = false;
            gbEstado.Text = "Estado";
            // 
            // rbInhabilitado
            // 
            rbInhabilitado.AutoSize = true;
            rbInhabilitado.Location = new Point(169, 36);
            rbInhabilitado.Name = "rbInhabilitado";
            rbInhabilitado.Size = new Size(110, 24);
            rbInhabilitado.TabIndex = 1;
            rbInhabilitado.Text = "Inhabilitado";
            rbInhabilitado.UseVisualStyleBackColor = true;
            // 
            // rbHabilitado
            // 
            rbHabilitado.AutoSize = true;
            rbHabilitado.Checked = true;
            rbHabilitado.Location = new Point(14, 36);
            rbHabilitado.Name = "rbHabilitado";
            rbHabilitado.Size = new Size(101, 24);
            rbHabilitado.TabIndex = 0;
            rbHabilitado.TabStop = true;
            rbHabilitado.Text = "Habilitado";
            rbHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(27, 281);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            // 
            // gbGrupo
            // 
            gbGrupo.Controls.Add(btnQuitarGrupo);
            gbGrupo.Controls.Add(btnAgregarGrupo);
            gbGrupo.Controls.Add(cbGrupos);
            gbGrupo.Controls.Add(lblGrupo);
            gbGrupo.Location = new Point(435, 29);
            gbGrupo.Name = "gbGrupo";
            gbGrupo.Size = new Size(320, 144);
            gbGrupo.TabIndex = 7;
            gbGrupo.TabStop = false;
            gbGrupo.Text = "Grupos";
            // 
            // btnQuitarGrupo
            // 
            btnQuitarGrupo.Location = new Point(208, 86);
            btnQuitarGrupo.Name = "btnQuitarGrupo";
            btnQuitarGrupo.Size = new Size(94, 29);
            btnQuitarGrupo.TabIndex = 11;
            btnQuitarGrupo.Text = "Quitar";
            btnQuitarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarGrupo
            // 
            btnAgregarGrupo.Location = new Point(13, 86);
            btnAgregarGrupo.Name = "btnAgregarGrupo";
            btnAgregarGrupo.Size = new Size(94, 29);
            btnAgregarGrupo.TabIndex = 10;
            btnAgregarGrupo.Text = "Agregar";
            btnAgregarGrupo.UseVisualStyleBackColor = true;
            // 
            // cbGrupos
            // 
            cbGrupos.FormattingEnabled = true;
            cbGrupos.Location = new Point(123, 32);
            cbGrupos.Name = "cbGrupos";
            cbGrupos.Size = new Size(151, 28);
            cbGrupos.TabIndex = 9;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(16, 36);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(59, 20);
            lblGrupo.TabIndex = 8;
            lblGrupo.Text = "Grupos:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(181, 26);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(125, 27);
            txtNombreUsuario.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(146, 65);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(146, 99);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(136, 239);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(136, 278);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 12;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 349);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(gbGrupo);
            Controls.Add(lblApellido);
            Controls.Add(gbEstado);
            Controls.Add(lblNombre);
            Controls.Add(lblClave);
            Controls.Add(lblEmail);
            Controls.Add(label2);
            Controls.Add(lblNombreUsuario);
            Name = "Usuario";
            Text = "Usuario";
            gbEstado.ResumeLayout(false);
            gbEstado.PerformLayout();
            gbGrupo.ResumeLayout(false);
            gbGrupo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuario;
        private Label label2;
        private Label lblEmail;
        private Label lblClave;
        private Label lblNombre;
        private GroupBox gbEstado;
        private RadioButton rbInhabilitado;
        private RadioButton rbHabilitado;
        private Label lblApellido;
        private GroupBox gbGrupo;
        private Button btnQuitarGrupo;
        private Button btnAgregarGrupo;
        private ComboBox cbGrupos;
        private Label lblGrupo;
        private TextBox txtNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtApellido;
    }
}