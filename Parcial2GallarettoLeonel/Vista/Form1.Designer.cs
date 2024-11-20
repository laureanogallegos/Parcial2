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
            dgvUsuarios = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            TipoUsuarios = new CheckedListBox();
            txtNombre = new TextBox();
            TxtClave = new TextBox();
            txtEmail = new TextBox();
            RadioBtn = new RadioButton();
            txtClave2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(424, 35);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(544, 426);
            dgvUsuarios.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(444, 477);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(677, 477);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(874, 477);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // TipoUsuarios
            // 
            TipoUsuarios.FormattingEnabled = true;
            TipoUsuarios.Location = new Point(44, 385);
            TipoUsuarios.Name = "TipoUsuarios";
            TipoUsuarios.Size = new Size(150, 114);
            TipoUsuarios.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            // 
            // TxtClave
            // 
            TxtClave.Location = new Point(54, 98);
            TxtClave.Name = "TxtClave";
            TxtClave.PlaceholderText = "Clave";
            TxtClave.Size = new Size(125, 27);
            TxtClave.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 227);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 7;
            // 
            // RadioBtn
            // 
            RadioBtn.AutoSize = true;
            RadioBtn.Location = new Point(54, 282);
            RadioBtn.Name = "RadioBtn";
            RadioBtn.Size = new Size(101, 24);
            RadioBtn.TabIndex = 8;
            RadioBtn.TabStop = true;
            RadioBtn.Text = "Habilitado";
            RadioBtn.UseVisualStyleBackColor = true;
            // 
            // txtClave2
            // 
            txtClave2.Location = new Point(54, 171);
            txtClave2.Name = "txtClave2";
            txtClave2.PlaceholderText = "Repetir Clave";
            txtClave2.Size = new Size(125, 27);
            txtClave2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 532);
            Controls.Add(txtClave2);
            Controls.Add(RadioBtn);
            Controls.Add(txtEmail);
            Controls.Add(TxtClave);
            Controls.Add(txtNombre);
            Controls.Add(TipoUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvUsuarios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private CheckedListBox TipoUsuarios;
        private TextBox txtNombre;
        private TextBox TxtClave;
        private TextBox txtEmail;
        private RadioButton RadioBtn;
        private TextBox txtClave2;
    }
}
