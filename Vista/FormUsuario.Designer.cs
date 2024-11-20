namespace Vista
{
    partial class FormUsuario
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtNombreUsuario = new TextBox();
            txtEmail = new TextBox();
            txtClave = new TextBox();
            txtClave2 = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            checkBoxEstado = new CheckBox();
            label9 = new Label();
            btnEliminarGrupo = new Button();
            btnAgregarGrupo = new Button();
            cBoxGrupos = new ComboBox();
            label8 = new Label();
            dgvGrupos = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(txtClave2);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(checkBoxEstado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnEliminarGrupo);
            groupBox1.Controls.Add(btnAgregarGrupo);
            groupBox1.Controls.Add(cBoxGrupos);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dgvGrupos);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(182, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(31, 351);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(157, 46);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(157, 113);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 17;
            // 
            // txtClave2
            // 
            txtClave2.Location = new Point(157, 152);
            txtClave2.Name = "txtClave2";
            txtClave2.Size = new Size(100, 23);
            txtClave2.TabIndex = 16;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(157, 256);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 223);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 14;
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Location = new Point(157, 195);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(15, 14);
            checkBoxEstado.TabIndex = 13;
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(505, 98);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 12;
            label9.Text = "Grupos del Usuario:";
            // 
            // btnEliminarGrupo
            // 
            btnEliminarGrupo.Location = new Point(502, 351);
            btnEliminarGrupo.Name = "btnEliminarGrupo";
            btnEliminarGrupo.Size = new Size(113, 23);
            btnEliminarGrupo.TabIndex = 11;
            btnEliminarGrupo.Text = "Eliminar Grupo";
            btnEliminarGrupo.UseVisualStyleBackColor = true;
            btnEliminarGrupo.Click += btnEliminarGrupo_Click;
            // 
            // btnAgregarGrupo
            // 
            btnAgregarGrupo.Location = new Point(502, 60);
            btnAgregarGrupo.Name = "btnAgregarGrupo";
            btnAgregarGrupo.Size = new Size(113, 23);
            btnAgregarGrupo.TabIndex = 10;
            btnAgregarGrupo.Text = "Agregar Grupo";
            btnAgregarGrupo.UseVisualStyleBackColor = true;
            btnAgregarGrupo.Click += btnAgregarGrupo_Click;
            // 
            // cBoxGrupos
            // 
            cBoxGrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxGrupos.FormattingEnabled = true;
            cBoxGrupos.Location = new Point(454, 31);
            cBoxGrupos.Name = "cBoxGrupos";
            cBoxGrupos.Size = new Size(231, 23);
            cBoxGrupos.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(388, 34);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 8;
            label8.Text = "Grupos:";
            // 
            // dgvGrupos
            // 
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(338, 116);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.Size = new Size(432, 229);
            dgvGrupos.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 259);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Apellido:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 226);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 195);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 155);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Repetir Clave:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 116);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Clave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario:";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(groupBox1);
            Name = "FormUsuario";
            Load += FormUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private CheckBox checkBoxEstado;
        private Label label9;
        private Button btnEliminarGrupo;
        private Button btnAgregarGrupo;
        private ComboBox cBoxGrupos;
        private Label label8;
        private DataGridView dgvGrupos;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNombreUsuario;
        private TextBox txtEmail;
        private TextBox txtClave;
        private TextBox txtClave2;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}