namespace FasolatoLucas2AN
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
            gbABMUsuarios = new GroupBox();
            BtnOpciones = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            cbValido = new CheckBox();
            cblGrupos = new CheckedListBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtClave2 = new TextBox();
            lblClave2 = new Label();
            txtClave = new TextBox();
            lblClave = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            cbOpciones = new ComboBox();
            dataGridView1 = new DataGridView();
            gbABMUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbABMUsuarios
            // 
            gbABMUsuarios.Controls.Add(BtnOpciones);
            gbABMUsuarios.Controls.Add(txtApellido);
            gbABMUsuarios.Controls.Add(lblApellido);
            gbABMUsuarios.Controls.Add(cbValido);
            gbABMUsuarios.Controls.Add(cblGrupos);
            gbABMUsuarios.Controls.Add(txtNombre);
            gbABMUsuarios.Controls.Add(lblNombre);
            gbABMUsuarios.Controls.Add(txtClave2);
            gbABMUsuarios.Controls.Add(lblClave2);
            gbABMUsuarios.Controls.Add(txtClave);
            gbABMUsuarios.Controls.Add(lblClave);
            gbABMUsuarios.Controls.Add(txtEmail);
            gbABMUsuarios.Controls.Add(lblEmail);
            gbABMUsuarios.Controls.Add(txtNombreUsuario);
            gbABMUsuarios.Controls.Add(lblNombreUsuario);
            gbABMUsuarios.Controls.Add(cbOpciones);
            gbABMUsuarios.Location = new Point(12, 12);
            gbABMUsuarios.Name = "gbABMUsuarios";
            gbABMUsuarios.Size = new Size(256, 596);
            gbABMUsuarios.TabIndex = 0;
            gbABMUsuarios.TabStop = false;
            gbABMUsuarios.Text = "groupBox1";
            // 
            // BtnOpciones
            // 
            BtnOpciones.Location = new Point(20, 548);
            BtnOpciones.Name = "BtnOpciones";
            BtnOpciones.Size = new Size(214, 23);
            BtnOpciones.TabIndex = 13;
            BtnOpciones.Text = "AGREGAR";
            BtnOpciones.UseVisualStyleBackColor = true;
            BtnOpciones.Click += BtnOpciones_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(20, 370);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(214, 23);
            txtApellido.TabIndex = 12;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(20, 347);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // cbValido
            // 
            cbValido.AutoSize = true;
            cbValido.Location = new Point(20, 413);
            cbValido.Name = "cbValido";
            cbValido.Size = new Size(72, 19);
            cbValido.TabIndex = 10;
            cbValido.Text = "Es valido";
            cbValido.UseVisualStyleBackColor = true;
            // 
            // cblGrupos
            // 
            cblGrupos.FormattingEnabled = true;
            cblGrupos.Location = new Point(20, 448);
            cblGrupos.Name = "cblGrupos";
            cblGrupos.Size = new Size(214, 76);
            cblGrupos.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 310);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 287);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // txtClave2
            // 
            txtClave2.Location = new Point(20, 249);
            txtClave2.Name = "txtClave2";
            txtClave2.Size = new Size(214, 23);
            txtClave2.TabIndex = 4;
            // 
            // lblClave2
            // 
            lblClave2.AutoSize = true;
            lblClave2.Location = new Point(20, 226);
            lblClave2.Name = "lblClave2";
            lblClave2.Size = new Size(90, 15);
            lblClave2.TabIndex = 3;
            lblClave2.Text = "Reingrese Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(20, 192);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(214, 23);
            txtClave.TabIndex = 6;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(20, 169);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 5;
            lblClave.Text = "Clave";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(20, 83);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(214, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(20, 60);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // cbOpciones
            // 
            cbOpciones.FormattingEnabled = true;
            cbOpciones.Items.AddRange(new object[] { "AGREGAR", "MODIFICAR", "ELIMINAR" });
            cbOpciones.Location = new Point(20, 25);
            cbOpciones.Name = "cbOpciones";
            cbOpciones.Size = new Size(214, 23);
            cbOpciones.TabIndex = 0;
            cbOpciones.SelectedIndexChanged += cbOpciones_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(311, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 276);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 634);
            Controls.Add(dataGridView1);
            Controls.Add(gbABMUsuarios);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbABMUsuarios.ResumeLayout(false);
            gbABMUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbABMUsuarios;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private ComboBox cbOpciones;
        private CheckBox cbValido;
        private CheckedListBox cblGrupos;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtClave2;
        private Label lblClave2;
        private TextBox txtClave;
        private Label lblClave;
        private TextBox txtEmail;
        private Label lblEmail;
        private DataGridView dataGridView1;
        private TextBox txtApellido;
        private Label lblApellido;
        private Button BtnOpciones;
    }
}
