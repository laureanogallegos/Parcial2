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
            btnRegistrarGrupo = new Button();
            btnRegistrarUsuario = new Button();
            SuspendLayout();
            // 
            // btnRegistrarGrupo
            // 
            btnRegistrarGrupo.Location = new Point(12, 12);
            btnRegistrarGrupo.Name = "btnRegistrarGrupo";
            btnRegistrarGrupo.Size = new Size(160, 73);
            btnRegistrarGrupo.TabIndex = 0;
            btnRegistrarGrupo.Text = "Registrar Roles";
            btnRegistrarGrupo.UseVisualStyleBackColor = true;
            btnRegistrarGrupo.Click += btnRegistrarGrupo_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Location = new Point(12, 91);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(160, 73);
            btnRegistrarUsuario.TabIndex = 1;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 174);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(btnRegistrarGrupo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarGrupo;
        private Button btnRegistrarUsuario;
    }
}
