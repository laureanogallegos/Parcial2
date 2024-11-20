namespace Vista
{
    partial class GrupoUsuarios
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
            btn_Crear = new Button();
            btn_Eliminar = new Button();
            btn_Editar = new Button();
            lbl_Nombre = new Label();
            txt_Nombre = new TextBox();
            dgv_Grupos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Grupos).BeginInit();
            SuspendLayout();
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(173, 42);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(107, 27);
            btn_Crear.TabIndex = 0;
            btn_Crear.Text = "Crear Grupo";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(173, 76);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(107, 27);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar Grupo";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(173, 105);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(107, 27);
            btn_Editar.TabIndex = 2;
            btn_Editar.Text = "Editar Grupo";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(14, 26);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(87, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre Grupo";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(14, 46);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // dgv_Grupos
            // 
            dgv_Grupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Grupos.Location = new Point(2, 162);
            dgv_Grupos.Name = "dgv_Grupos";
            dgv_Grupos.Size = new Size(291, 185);
            dgv_Grupos.TabIndex = 5;
            dgv_Grupos.CellClick += dgv_Grupos_CellClick;
            // 
            // GrupoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 450);
            Controls.Add(dgv_Grupos);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Nombre);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Crear);
            Name = "GrupoUsuarios";
            Text = "GrupoUsuarios";
            Load += GrupoUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Grupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Crear;
        private Button btn_Eliminar;
        private Button btn_Editar;
        private Label lbl_Nombre;
        private TextBox txt_Nombre;
        private DataGridView dgv_Grupos;
    }
}