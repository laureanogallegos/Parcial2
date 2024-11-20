namespace Vista
{
    partial class FormularioPrincipal
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
            dataGridViewListaUsuarios = new DataGridView();
            labelListaUsuarios = new Label();
            textBoxNombreDeUsuario = new TextBox();
            labelNombreDeUsuario = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelClave = new Label();
            textBoxClave = new TextBox();
            labelNombreYApellido = new Label();
            textBoxNombreYApellido = new TextBox();
            labelGrupos = new Label();
            radioButtonHabilitado = new RadioButton();
            radioButtonInhabilitado = new RadioButton();
            groupBoxEstado = new GroupBox();
            buttonAgregarUsuario = new Button();
            comboBoxGruposAAsignar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaUsuarios).BeginInit();
            groupBoxEstado.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewListaUsuarios
            // 
            dataGridViewListaUsuarios.AllowUserToAddRows = false;
            dataGridViewListaUsuarios.AllowUserToDeleteRows = false;
            dataGridViewListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListaUsuarios.Location = new Point(585, 34);
            dataGridViewListaUsuarios.Name = "dataGridViewListaUsuarios";
            dataGridViewListaUsuarios.ReadOnly = true;
            dataGridViewListaUsuarios.RowHeadersWidth = 62;
            dataGridViewListaUsuarios.Size = new Size(673, 234);
            dataGridViewListaUsuarios.TabIndex = 0;
            // 
            // labelListaUsuarios
            // 
            labelListaUsuarios.AutoSize = true;
            labelListaUsuarios.Location = new Point(585, 6);
            labelListaUsuarios.Name = "labelListaUsuarios";
            labelListaUsuarios.Size = new Size(118, 25);
            labelListaUsuarios.TabIndex = 1;
            labelListaUsuarios.Text = "Lista usuarios";
            // 
            // textBoxNombreDeUsuario
            // 
            textBoxNombreDeUsuario.Location = new Point(26, 57);
            textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            textBoxNombreDeUsuario.Size = new Size(150, 31);
            textBoxNombreDeUsuario.TabIndex = 2;
            // 
            // labelNombreDeUsuario
            // 
            labelNombreDeUsuario.AutoSize = true;
            labelNombreDeUsuario.Location = new Point(26, 29);
            labelNombreDeUsuario.Name = "labelNombreDeUsuario";
            labelNombreDeUsuario.Size = new Size(141, 25);
            labelNombreDeUsuario.TabIndex = 3;
            labelNombreDeUsuario.Text = "Nombre usuario";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(26, 91);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(26, 119);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // labelClave
            // 
            labelClave.AutoSize = true;
            labelClave.Location = new Point(26, 153);
            labelClave.Name = "labelClave";
            labelClave.Size = new Size(54, 25);
            labelClave.TabIndex = 7;
            labelClave.Text = "Clave";
            // 
            // textBoxClave
            // 
            textBoxClave.Location = new Point(26, 181);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(150, 31);
            textBoxClave.TabIndex = 6;
            // 
            // labelNombreYApellido
            // 
            labelNombreYApellido.AutoSize = true;
            labelNombreYApellido.Location = new Point(26, 348);
            labelNombreYApellido.Name = "labelNombreYApellido";
            labelNombreYApellido.Size = new Size(163, 25);
            labelNombreYApellido.TabIndex = 9;
            labelNombreYApellido.Text = "Nombre y Apellido";
            // 
            // textBoxNombreYApellido
            // 
            textBoxNombreYApellido.Location = new Point(26, 376);
            textBoxNombreYApellido.Name = "textBoxNombreYApellido";
            textBoxNombreYApellido.Size = new Size(150, 31);
            textBoxNombreYApellido.TabIndex = 8;
            textBoxNombreYApellido.Leave += textBoxNombreYApellido_Leave;
            // 
            // labelGrupos
            // 
            labelGrupos.AutoSize = true;
            labelGrupos.Location = new Point(213, 153);
            labelGrupos.Name = "labelGrupos";
            labelGrupos.Size = new Size(138, 25);
            labelGrupos.TabIndex = 11;
            labelGrupos.Text = "Grupo a asignar";
            // 
            // radioButtonHabilitado
            // 
            radioButtonHabilitado.AutoSize = true;
            radioButtonHabilitado.Location = new Point(6, 34);
            radioButtonHabilitado.Name = "radioButtonHabilitado";
            radioButtonHabilitado.Size = new Size(119, 29);
            radioButtonHabilitado.TabIndex = 12;
            radioButtonHabilitado.TabStop = true;
            radioButtonHabilitado.Text = "Habilitado";
            radioButtonHabilitado.UseVisualStyleBackColor = true;
            // 
            // radioButtonInhabilitado
            // 
            radioButtonInhabilitado.AutoSize = true;
            radioButtonInhabilitado.Location = new Point(6, 69);
            radioButtonInhabilitado.Name = "radioButtonInhabilitado";
            radioButtonInhabilitado.Size = new Size(131, 29);
            radioButtonInhabilitado.TabIndex = 13;
            radioButtonInhabilitado.TabStop = true;
            radioButtonInhabilitado.Text = "Inhabilitado";
            radioButtonInhabilitado.UseVisualStyleBackColor = true;
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Controls.Add(radioButtonInhabilitado);
            groupBoxEstado.Controls.Add(radioButtonHabilitado);
            groupBoxEstado.Location = new Point(26, 218);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(150, 113);
            groupBoxEstado.TabIndex = 14;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "Estado";
            // 
            // buttonAgregarUsuario
            // 
            buttonAgregarUsuario.Location = new Point(213, 54);
            buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            buttonAgregarUsuario.Size = new Size(176, 34);
            buttonAgregarUsuario.TabIndex = 15;
            buttonAgregarUsuario.Text = "Agregar Usuario";
            buttonAgregarUsuario.UseVisualStyleBackColor = true;
            buttonAgregarUsuario.Click += buttonAgregarUsuario_Click;
            // 
            // comboBoxGruposAAsignar
            // 
            comboBoxGruposAAsignar.FormattingEnabled = true;
            comboBoxGruposAAsignar.Location = new Point(213, 181);
            comboBoxGruposAAsignar.Name = "comboBoxGruposAAsignar";
            comboBoxGruposAAsignar.Size = new Size(182, 33);
            comboBoxGruposAAsignar.TabIndex = 16;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 486);
            Controls.Add(comboBoxGruposAAsignar);
            Controls.Add(buttonAgregarUsuario);
            Controls.Add(labelNombreYApellido);
            Controls.Add(groupBoxEstado);
            Controls.Add(labelGrupos);
            Controls.Add(textBoxNombreYApellido);
            Controls.Add(labelClave);
            Controls.Add(textBoxClave);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelNombreDeUsuario);
            Controls.Add(textBoxNombreDeUsuario);
            Controls.Add(labelListaUsuarios);
            Controls.Add(dataGridViewListaUsuarios);
            Name = "FormularioPrincipal";
            Text = "Formulario Principal";
            Load += FormularioPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListaUsuarios).EndInit();
            groupBoxEstado.ResumeLayout(false);
            groupBoxEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListaUsuarios;
        private Label labelListaUsuarios;
        private TextBox textBoxNombreDeUsuario;
        private Label labelNombreDeUsuario;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelClave;
        private TextBox textBoxClave;
        private Label labelNombreYApellido;
        private TextBox textBoxNombreYApellido;
        private Label labelGrupos;
        private RadioButton radioButtonHabilitado;
        private RadioButton radioButtonInhabilitado;
        private GroupBox groupBoxEstado;
        private Button buttonAgregarUsuario;
        private ComboBox comboBoxGruposAAsignar;
    }
}
