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
            btnGrupos = new Button();
            btnUsuarios = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGrupos
            // 
            btnGrupos.Location = new Point(12, 12);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(167, 61);
            btnGrupos.TabIndex = 0;
            btnGrupos.Text = "Cargar Grupos";
            btnGrupos.UseVisualStyleBackColor = true;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(12, 79);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(167, 61);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Cargar Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(57, 162);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 205);
            Controls.Add(btnSalir);
            Controls.Add(btnUsuarios);
            Controls.Add(btnGrupos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGrupos;
        private Button btnUsuarios;
        private Button btnSalir;
    }
}
