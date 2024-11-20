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
            cmbGrupos = new ComboBox();
            label1 = new Label();
            btnRegistrarGrupo = new Button();
            btnModificarGrupo = new Button();
            btnEliminarGrupo = new Button();
            dgvGrupos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // cmbGrupos
            // 
            cmbGrupos.FormattingEnabled = true;
            cmbGrupos.Items.AddRange(new object[] { "Administrador", "Usuario", "Invitado" });
            cmbGrupos.Location = new Point(12, 35);
            cmbGrupos.Name = "cmbGrupos";
            cmbGrupos.Size = new Size(204, 23);
            cmbGrupos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar Responsabiliad del Grupo";
            // 
            // btnRegistrarGrupo
            // 
            btnRegistrarGrupo.Location = new Point(12, 64);
            btnRegistrarGrupo.Name = "btnRegistrarGrupo";
            btnRegistrarGrupo.Size = new Size(204, 23);
            btnRegistrarGrupo.TabIndex = 2;
            btnRegistrarGrupo.Text = "Registrar Grupo";
            btnRegistrarGrupo.UseVisualStyleBackColor = true;
            btnRegistrarGrupo.Click += btnRegistrarGrupo_Click;
            // 
            // btnModificarGrupo
            // 
            btnModificarGrupo.Location = new Point(12, 93);
            btnModificarGrupo.Name = "btnModificarGrupo";
            btnModificarGrupo.Size = new Size(204, 23);
            btnModificarGrupo.TabIndex = 3;
            btnModificarGrupo.Text = "Modificar Grupo";
            btnModificarGrupo.UseVisualStyleBackColor = true;
            btnModificarGrupo.Click += btnModificarGrupo_Click;
            // 
            // btnEliminarGrupo
            // 
            btnEliminarGrupo.Location = new Point(12, 122);
            btnEliminarGrupo.Name = "btnEliminarGrupo";
            btnEliminarGrupo.Size = new Size(204, 23);
            btnEliminarGrupo.TabIndex = 4;
            btnEliminarGrupo.Text = "Eliminar Grupo";
            btnEliminarGrupo.UseVisualStyleBackColor = true;
            btnEliminarGrupo.Click += btnEliminarGrupo_Click;
            // 
            // dgvGrupos
            // 
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(222, 35);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.Size = new Size(258, 110);
            dgvGrupos.TabIndex = 5;
            dgvGrupos.CellClick += dgvGrupos_CellClick;
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 166);
            Controls.Add(dgvGrupos);
            Controls.Add(btnEliminarGrupo);
            Controls.Add(btnModificarGrupo);
            Controls.Add(btnRegistrarGrupo);
            Controls.Add(label1);
            Controls.Add(cmbGrupos);
            Name = "FormGrupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGrupos";
            Load += FormGrupos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGrupos;
        private Label label1;
        private Button btnRegistrarGrupo;
        private Button btnModificarGrupo;
        private Button btnEliminarGrupo;
        private DataGridView dgvGrupos;
    }
}