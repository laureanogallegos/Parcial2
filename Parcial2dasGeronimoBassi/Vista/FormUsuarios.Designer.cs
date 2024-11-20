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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            cmbGrupo = new ComboBox();
            label8 = new Label();
            txtNombreUsuario = new TextBox();
            TxtMail = new TextBox();
            txtClave = new TextBox();
            txtVerificarClave = new TextBox();
            cmbEstado = new ComboBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dgvUsuario = new DataGridView();
            btnAgregarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre De usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 51);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 87);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 168);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 198);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 236);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 126);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 6;
            label7.Text = "Verificar Clave";
            // 
            // button1
            // 
            button1.Location = new Point(605, 273);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 7;
            button1.Text = "Agregar grupo a la lista";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(605, 244);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(123, 23);
            cmbGrupo.TabIndex = 8;
            cmbGrupo.SelectedIndexChanged += cmbGrupo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 226);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 9;
            label8.Text = "Grupo";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(172, 22);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 10;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(172, 51);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(100, 23);
            TxtMail.TabIndex = 11;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(172, 87);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 12;
            txtClave.TextChanged += txtClave_TextChanged;
            // 
            // txtVerificarClave
            // 
            txtVerificarClave.Location = new Point(163, 126);
            txtVerificarClave.Name = "txtVerificarClave";
            txtVerificarClave.Size = new Size(130, 23);
            txtVerificarClave.TabIndex = 13;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Habilitado", "Inhabilitado" });
            cmbEstado.Location = new Point(163, 165);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(161, 198);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(161, 236);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(123, 23);
            txtApellido.TabIndex = 16;
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(88, 326);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(260, 98);
            dgvUsuario.TabIndex = 17;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(327, 100);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(173, 23);
            btnAgregarUsuario.TabIndex = 18;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(dgvUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cmbEstado);
            Controls.Add(txtVerificarClave);
            Controls.Add(txtClave);
            Controls.Add(TxtMail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label8);
            Controls.Add(cmbGrupo);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
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
        private Label label7;
        private Button button1;
        private ComboBox cmbGrupo;
        private Label label8;
        private TextBox txtNombreUsuario;
        private TextBox TxtMail;
        private TextBox txtClave;
        private TextBox txtVerificarClave;
        private ComboBox cmbEstado;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DataGridView dgvUsuario;
        private Button btnAgregarUsuario;
    }
}