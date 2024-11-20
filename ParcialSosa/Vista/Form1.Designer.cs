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
            groupBox1 = new GroupBox();
            txtRepetirClave = new TextBox();
            label8 = new Label();
            checkedList = new CheckedListBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAceptar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cmbEstado = new ComboBox();
            txtClave = new TextBox();
            txtEmail = new TextBox();
            txtUsuario = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvUsuarios = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRepetirClave);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(checkedList);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 448);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion";
            // 
            // txtRepetirClave
            // 
            txtRepetirClave.Location = new Point(107, 130);
            txtRepetirClave.Name = "txtRepetirClave";
            txtRepetirClave.Size = new Size(100, 23);
            txtRepetirClave.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 133);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 18;
            label8.Text = "Repetir Clave";
            // 
            // checkedList
            // 
            checkedList.FormattingEnabled = true;
            checkedList.Location = new Point(18, 307);
            checkedList.Name = "checkedList";
            checkedList.Size = new Size(210, 76);
            checkedList.TabIndex = 17;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(164, 401);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(83, 401);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(2, 401);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Agregar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(104, 240);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 205);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Habilitado", "Inhabilitado" });
            cmbEstado.Location = new Point(104, 165);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 11;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(107, 93);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(107, 21);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 279);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 7;
            label7.Text = "Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 248);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 213);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 173);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 101);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUsuarios);
            groupBox2.Location = new Point(271, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 398);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Usuario, Email, Clave, Nombre, Apellido, Estado, Grupo });
            dgvUsuarios.Location = new Point(6, 17);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(359, 375);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "NombreUsuario";
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Clave
            // 
            Clave.DataPropertyName = "Clave";
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Grupo
            // 
            Grupo.DataPropertyName = "NombreGrupos";
            Grupo.HeaderText = "Grupo";
            Grupo.Name = "Grupo";
            Grupo.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 472);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cmbEstado;
        private TextBox txtClave;
        private TextBox txtEmail;
        private TextBox txtUsuario;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAceptar;
        private GroupBox groupBox2;
        private CheckedListBox checkedList;
        private TextBox txtRepetirClave;
        private Label label8;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Grupo;
    }
}
