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
            btnModificarUsuario = new Button();
            btnEliminarUsuario = new Button();
            radioButton1 = new RadioButton();
            btnAgregarUsuario = new Button();
            label7 = new Label();
            label6 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            txtClave2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtClave1 = new TextBox();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            groupBox2 = new GroupBox();
            dgvUsuarios = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnModificarUsuario);
            groupBox1.Controls.Add(btnEliminarUsuario);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(btnAgregarUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtClave2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtClave1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 528);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(16, 444);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(185, 29);
            btnModificarUsuario.TabIndex = 14;
            btnModificarUsuario.Text = "Modificar Usuario\r\n";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(16, 479);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(185, 29);
            btnEliminarUsuario.TabIndex = 13;
            btnEliminarUsuario.Text = "Eliminar Usuario\r\n";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(163, 363);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Habilitado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(16, 409);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(185, 29);
            btnAgregarUsuario.TabIndex = 11;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 321);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 10;
            label7.Text = "Apellido\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 268);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 9;
            label6.Text = "Nombre\r\n";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(163, 314);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 265);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 219);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 6;
            label5.Text = "Repetir Clave";
            // 
            // txtClave2
            // 
            txtClave2.Location = new Point(163, 212);
            txtClave2.Name = "txtClave2";
            txtClave2.Size = new Size(125, 27);
            txtClave2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 167);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 4;
            label4.Text = "Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 107);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre Usuario";
            // 
            // txtClave1
            // 
            txtClave1.Location = new Point(163, 160);
            txtClave1.Name = "txtClave1";
            txtClave1.Size = new Size(125, 27);
            txtClave1.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(163, 60);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(125, 27);
            txtNombreUsuario.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUsuarios);
            groupBox2.Location = new Point(555, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 528);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(6, 26);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(770, 496);
            dgvUsuarios.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(347, 410);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 413);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 16;
            label1.Text = "Grupo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 570);
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
        private GroupBox groupBox2;
        private DataGridView dgvUsuarios;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private TextBox txtClave1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtClave2;
        private RadioButton radioButton1;
        private Button btnAgregarUsuario;
        private Label label7;
        private Label label6;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnModificarUsuario;
        private Button btnEliminarUsuario;
        private Label label1;
        private ComboBox comboBox1;
    }
}
