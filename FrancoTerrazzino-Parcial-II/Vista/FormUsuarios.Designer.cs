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
            txtNombreDeUsuario = new TextBox();
            label1 = new Label();
            txtEmail = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            txtClave = new TextBox();
            label4 = new Label();
            txtNmbre = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            checkEstado = new CheckBox();
            cmbRollDeGrupo = new ComboBox();
            label6 = new Label();
            dgvUsuarios = new DataGridView();
            btnCargarUsuari = new Button();
            btnModificarUsuario = new Button();
            btnEliminarUsuario = new Button();
            dgvRoles = new DataGridView();
            btnAsignarRoll = new Button();
            label2 = new Label();
            txtSegundaClave = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // txtNombreDeUsuario
            // 
            txtNombreDeUsuario.Location = new Point(12, 27);
            txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            txtNombreDeUsuario.Size = new Size(160, 23);
            txtNombreDeUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(12, 53);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(36, 15);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 115);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(160, 23);
            txtClave.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Nombre";
            // 
            // txtNmbre
            // 
            txtNmbre.Location = new Point(12, 203);
            txtNmbre.Name = "txtNmbre";
            txtNmbre.Size = new Size(160, 23);
            txtNmbre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 247);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 8;
            // 
            // checkEstado
            // 
            checkEstado.AutoSize = true;
            checkEstado.Location = new Point(12, 360);
            checkEstado.Name = "checkEstado";
            checkEstado.Size = new Size(123, 19);
            checkEstado.TabIndex = 10;
            checkEstado.Text = "Estado del Usuario";
            checkEstado.UseVisualStyleBackColor = true;
            checkEstado.CheckedChanged += checkEstado_CheckedChanged;
            // 
            // cmbRollDeGrupo
            // 
            cmbRollDeGrupo.FormattingEnabled = true;
            cmbRollDeGrupo.Location = new Point(12, 296);
            cmbRollDeGrupo.Name = "cmbRollDeGrupo";
            cmbRollDeGrupo.Size = new Size(160, 23);
            cmbRollDeGrupo.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 273);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Roll del Grupo";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(209, 159);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(471, 116);
            dgvUsuarios.TabIndex = 13;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // btnCargarUsuari
            // 
            btnCargarUsuari.Location = new Point(211, 281);
            btnCargarUsuari.Name = "btnCargarUsuari";
            btnCargarUsuari.Size = new Size(153, 71);
            btnCargarUsuari.TabIndex = 14;
            btnCargarUsuari.Text = "Cargar Usuario";
            btnCargarUsuari.UseVisualStyleBackColor = true;
            btnCargarUsuari.Click += btnCargarUsuari_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(370, 281);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(153, 71);
            btnModificarUsuario.TabIndex = 15;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(529, 281);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(153, 71);
            btnEliminarUsuario.TabIndex = 16;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(211, 27);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.Size = new Size(471, 116);
            dgvRoles.TabIndex = 17;
            // 
            // btnAsignarRoll
            // 
            btnAsignarRoll.Location = new Point(12, 325);
            btnAsignarRoll.Name = "btnAsignarRoll";
            btnAsignarRoll.Size = new Size(162, 29);
            btnAsignarRoll.TabIndex = 18;
            btnAsignarRoll.Text = "Designar Roll";
            btnAsignarRoll.UseVisualStyleBackColor = true;
            btnAsignarRoll.Click += btnAsignarRoll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 20;
            label2.Text = "Ingrese Nuevamente la Clave";
            // 
            // txtSegundaClave
            // 
            txtSegundaClave.Location = new Point(12, 159);
            txtSegundaClave.Name = "txtSegundaClave";
            txtSegundaClave.Size = new Size(160, 23);
            txtSegundaClave.TabIndex = 19;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 392);
            Controls.Add(label2);
            Controls.Add(txtSegundaClave);
            Controls.Add(btnAsignarRoll);
            Controls.Add(dgvRoles);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnCargarUsuari);
            Controls.Add(dgvUsuarios);
            Controls.Add(label6);
            Controls.Add(cmbRollDeGrupo);
            Controls.Add(checkEstado);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNmbre);
            Controls.Add(label3);
            Controls.Add(txtClave);
            Controls.Add(txtEmail);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(txtNombreDeUsuario);
            Name = "FormUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreDeUsuario;
        private Label label1;
        private Label txtEmail;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtClave;
        private Label label4;
        private TextBox txtNmbre;
        private Label label5;
        private TextBox txtApellido;
        private CheckBox checkEstado;
        private ComboBox cmbRollDeGrupo;
        private Label label6;
        private DataGridView dgvUsuarios;
        private Button btnCargarUsuari;
        private Button btnModificarUsuario;
        private Button btnEliminarUsuario;
        private DataGridView dgvRoles;
        private Button btnAsignarRoll;
        private Label label2;
        private TextBox txtSegundaClave;
    }
}