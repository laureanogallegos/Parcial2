namespace Vista
{
    partial class Usuarios
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
            txt_Nombre = new TextBox();
            txt_Apellido = new TextBox();
            label2 = new Label();
            txt_Usuario = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txt_Password = new TextBox();
            label5 = new Label();
            txt_Confirmar = new TextBox();
            label6 = new Label();
            dgv_Usuarios = new DataGridView();
            chk_Estado = new CheckBox();
            cb_Grupos = new ComboBox();
            label7 = new Label();
            btn_Crear = new Button();
            btn_Eliminar = new Button();
            btn_Editar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Usuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(11, 41);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 1;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(10, 98);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 23);
            txt_Apellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(12, 166);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(100, 23);
            txt_Usuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 144);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuario";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(152, 41);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(112, 23);
            txtCorreo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 19);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(152, 102);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(112, 23);
            txt_Password.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 80);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // txt_Confirmar
            // 
            txt_Confirmar.Location = new Point(151, 166);
            txt_Confirmar.Name = "txt_Confirmar";
            txt_Confirmar.Size = new Size(113, 23);
            txt_Confirmar.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 144);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 10;
            label6.Text = "Confirmar Password";
            // 
            // dgv_Usuarios
            // 
            dgv_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Usuarios.Location = new Point(323, 19);
            dgv_Usuarios.Name = "dgv_Usuarios";
            dgv_Usuarios.Size = new Size(465, 211);
            dgv_Usuarios.TabIndex = 12;
            // 
            // chk_Estado
            // 
            chk_Estado.AutoSize = true;
            chk_Estado.Location = new Point(13, 217);
            chk_Estado.Name = "chk_Estado";
            chk_Estado.Size = new Size(60, 19);
            chk_Estado.TabIndex = 13;
            chk_Estado.Text = "Activo";
            chk_Estado.UseVisualStyleBackColor = true;
            // 
            // cb_Grupos
            // 
            cb_Grupos.FormattingEnabled = true;
            cb_Grupos.Location = new Point(151, 217);
            cb_Grupos.Name = "cb_Grupos";
            cb_Grupos.Size = new Size(121, 23);
            cb_Grupos.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 199);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 15;
            label7.Text = "Grupo Usuario";
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(20, 289);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(75, 23);
            btn_Crear.TabIndex = 16;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(119, 289);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 17;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(215, 289);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 18;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Crear);
            Controls.Add(label7);
            Controls.Add(cb_Grupos);
            Controls.Add(chk_Estado);
            Controls.Add(dgv_Usuarios);
            Controls.Add(txt_Confirmar);
            Controls.Add(label6);
            Controls.Add(txt_Password);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txt_Usuario);
            Controls.Add(label3);
            Controls.Add(txt_Apellido);
            Controls.Add(label2);
            Controls.Add(txt_Nombre);
            Controls.Add(label1);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private Label label2;
        private TextBox txt_Usuario;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txt_Password;
        private Label label5;
        private TextBox txt_Confirmar;
        private Label label6;
        private DataGridView dgv_Usuarios;
        private CheckBox chk_Estado;
        private ComboBox cb_Grupos;
        private Label label7;
        private Button btn_Crear;
        private Button btn_Eliminar;
        private Button btn_Editar;
    }
}