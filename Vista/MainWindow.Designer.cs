namespace Vista
{
    partial class MainWindow
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
            dgvUser = new DataGridView();
            txtUsername = new TextBox();
            label1 = new Label();
            Name = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            btnCreate = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtRepeatPassword = new TextBox();
            clbRol = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(421, 35);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(596, 519);
            dgvUser.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(48, 67);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(339, 27);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(48, 256);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 4;
            Name.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(48, 288);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 337);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "LastName";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(48, 369);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(339, 27);
            txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 415);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(48, 447);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 27);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 493);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(48, 526);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(339, 28);
            cmbStatus.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 569);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 12;
            label6.Text = "Rol";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(511, 585);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(678, 585);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 15;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(840, 585);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(48, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(339, 27);
            txtPassword.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 181);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 20;
            label7.Text = "Repeat Password";
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Location = new Point(48, 213);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(339, 27);
            txtRepeatPassword.TabIndex = 19;
            // 
            // clbRol
            // 
            clbRol.Items.AddRange(new object[] { "Administrator", "User", "Invited" });
            clbRol.Location = new Point(97, 585);
            clbRol.Name = "clbRol";
            clbRol.Size = new Size(120, 92);
            clbRol.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 704);
            Controls.Add(clbRol);
            Controls.Add(label7);
            Controls.Add(txtRepeatPassword);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnCreate);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(Name);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(dgvUser);
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private TextBox txtUsername;
        private Label label1;
        private Label Name;
        private TextBox txtName;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label6;
        private Button btnCreate;
        private Button btnModify;
        private Button btnDelete;
        private Label label2;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtRepeatPassword;
        private CheckedListBox clbRol;
    }
}