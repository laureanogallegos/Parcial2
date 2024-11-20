namespace JonathanKohan2AN
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
            txtNombreDeUsuario = new TextBox();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cbxEstado = new CheckBox();
            cmbGrupo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvUsuarios = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNombreDeUsuario
            // 
            txtNombreDeUsuario.Location = new Point(30, 40);
            txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            txtNombreDeUsuario.Size = new Size(151, 27);
            txtNombreDeUsuario.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(30, 139);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(151, 27);
            txtClave.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 265);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(30, 317);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 27);
            txtApellido.TabIndex = 4;
            // 
            // cbxEstado
            // 
            cbxEstado.AutoSize = true;
            cbxEstado.Location = new Point(60, 191);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(76, 24);
            cbxEstado.TabIndex = 6;
            cbxEstado.Text = "Estado";
            cbxEstado.UseVisualStyleBackColor = true;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(30, 376);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(151, 28);
            cmbGrupo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.MenuBar;
            label2.AutoSize = true;
            label2.Location = new Point(74, 70);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 116);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 10;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 242);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 295);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 12;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 353);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 13;
            label6.Text = "Grupo";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(203, 27);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(1010, 377);
            dgvUsuarios.TabIndex = 14;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(190, 435);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(342, 435);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1119, 435);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(40, 435);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 501);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvUsuarios);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGrupo);
            Controls.Add(cbxEstado);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(txtNombreDeUsuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreDeUsuario;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private CheckBox cbxEstado;
        private ComboBox cmbGrupo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvUsuarios;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnSalir;
        private Button btnAgregar;
    }
}
