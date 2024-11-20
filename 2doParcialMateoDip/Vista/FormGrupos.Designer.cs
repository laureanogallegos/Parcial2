namespace Vista
{
    partial class FormGrupos
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
            gBoxGrupo = new GroupBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtRol = new TextBox();
            txtCodigo = new TextBox();
            dgvGrupos = new DataGridView();
            btnSalir = new Button();
            label3 = new Label();
            gBoxGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // gBoxGrupo
            // 
            gBoxGrupo.Controls.Add(btnEliminar);
            gBoxGrupo.Controls.Add(btnModificar);
            gBoxGrupo.Controls.Add(btnAgregar);
            gBoxGrupo.Controls.Add(label2);
            gBoxGrupo.Controls.Add(label1);
            gBoxGrupo.Controls.Add(txtRol);
            gBoxGrupo.Controls.Add(txtCodigo);
            gBoxGrupo.Location = new Point(40, 23);
            gBoxGrupo.Name = "gBoxGrupo";
            gBoxGrupo.Size = new Size(209, 228);
            gBoxGrupo.TabIndex = 0;
            gBoxGrupo.TabStop = false;
            gBoxGrupo.Text = "Datos grupo:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(21, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(21, 148);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(165, 23);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(21, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(165, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "Rol:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Codigo:";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(86, 77);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(100, 23);
            txtRol.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(86, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // dgvGrupos
            // 
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(281, 50);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.Size = new Size(295, 159);
            dgvGrupos.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(488, 228);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 32);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Grupos";
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 260);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(dgvGrupos);
            Controls.Add(gBoxGrupo);
            Name = "FormGrupos";
            Text = "FormGrupos";
            gBoxGrupo.ResumeLayout(false);
            gBoxGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBoxGrupo;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private TextBox txtRol;
        private TextBox txtCodigo;
        private DataGridView dgvGrupos;
        private Button btnSalir;
        private Label label3;
    }
}