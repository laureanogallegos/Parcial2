namespace JeffreyDietzParcial2
{
    partial class Registracion
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
            tbContraseña = new TextBox();
            tbConfContraseña = new TextBox();
            contraseñalbl = new Label();
            contraseña2lbl = new Label();
            emaillbl = new Label();
            usernamelbl = new Label();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            label1 = new Label();
            nombrelbl = new Label();
            tbApellido = new TextBox();
            tbNombre = new TextBox();
            cbHablitado = new CheckBox();
            btnRegistrar = new Button();
            dgvUsuarios = new DataGridView();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // tbContraseña
            // 
            tbContraseña.Location = new Point(78, 155);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(160, 23);
            tbContraseña.TabIndex = 0;
            // 
            // tbConfContraseña
            // 
            tbConfContraseña.Location = new Point(78, 208);
            tbConfContraseña.Name = "tbConfContraseña";
            tbConfContraseña.Size = new Size(160, 23);
            tbConfContraseña.TabIndex = 1;
            // 
            // contraseñalbl
            // 
            contraseñalbl.AutoSize = true;
            contraseñalbl.Location = new Point(78, 128);
            contraseñalbl.Name = "contraseñalbl";
            contraseñalbl.Size = new Size(121, 15);
            contraseñalbl.TabIndex = 2;
            contraseñalbl.Text = "Ingrese su contraseña";
            // 
            // contraseña2lbl
            // 
            contraseña2lbl.AutoSize = true;
            contraseña2lbl.Location = new Point(78, 190);
            contraseña2lbl.Name = "contraseña2lbl";
            contraseña2lbl.Size = new Size(133, 15);
            contraseña2lbl.TabIndex = 3;
            contraseña2lbl.Text = "Confirme su contraseña";
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Location = new Point(78, 81);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(36, 15);
            emaillbl.TabIndex = 7;
            emaillbl.Text = "Email";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(78, 19);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(60, 15);
            usernamelbl.TabIndex = 6;
            usernamelbl.Text = "Username";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(78, 99);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(160, 23);
            tbEmail.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(78, 46);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(160, 23);
            tbUsername.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 307);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Apellido";
            // 
            // nombrelbl
            // 
            nombrelbl.AutoSize = true;
            nombrelbl.Location = new Point(78, 245);
            nombrelbl.Name = "nombrelbl";
            nombrelbl.Size = new Size(51, 15);
            nombrelbl.TabIndex = 10;
            nombrelbl.Text = "Nombre";
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(78, 325);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(160, 23);
            tbApellido.TabIndex = 9;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(78, 272);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(160, 23);
            tbNombre.TabIndex = 8;
            // 
            // cbHablitado
            // 
            cbHablitado.AutoSize = true;
            cbHablitado.Location = new Point(78, 364);
            cbHablitado.Name = "cbHablitado";
            cbHablitado.Size = new Size(110, 19);
            cbHablitado.TabIndex = 12;
            cbHablitado.Text = "Esta Habilitado?";
            cbHablitado.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(67, 403);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(181, 23);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar / Modificar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(318, 177);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(447, 249);
            dgvUsuarios.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(353, 41);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(199, 94);
            checkedListBox1.TabIndex = 15;
            // 
            // Registracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnRegistrar);
            Controls.Add(cbHablitado);
            Controls.Add(label1);
            Controls.Add(nombrelbl);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(emaillbl);
            Controls.Add(usernamelbl);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(contraseña2lbl);
            Controls.Add(contraseñalbl);
            Controls.Add(tbConfContraseña);
            Controls.Add(tbContraseña);
            Name = "Registracion";
            Text = "Form1";
            Load += Registracion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbContraseña;
        private TextBox tbConfContraseña;
        private Label contraseñalbl;
        private Label contraseña2lbl;
        private Label emaillbl;
        private Label usernamelbl;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private Label label1;
        private Label nombrelbl;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private CheckBox cbHablitado;
        private Button btnRegistrar;
        private DataGridView dgvUsuarios;
        private CheckedListBox checkedListBox1;
    }
}
