using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MainWindow : Form
    {
        UserController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new UserController();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateWindow();
        }
        public void UpdateWindow()
        {
            dgvUser.AutoGenerateColumns = false;
            dgvUser.Columns.Clear();
            dgvUser.DataSource = controller.GetUser();

            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "IdUser", DataPropertyName = "IdUsuario" });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Username", DataPropertyName = "Usernaem" });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "LastName", DataPropertyName = "LastName" });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
            dgvUser.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Roles", DataPropertyName = "Roles" });

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyContent())
                {
                    //List<Rol> ls
                    User user = new User()
                    {
                        Usernaem = txtUsername.Text,
                        Name = txtName.Text,
                        LastName = txtLastName.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        Status = cmbStatus.SelectedIndex == 0 ? true : false
                    };

                    if (controller.AddUser(user))
                    {
                        MessageBox.Show("The user was created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateWindow();
                    }
                    else MessageBox.Show("The user wasnt created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error create user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerifyContent()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("The username is undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(Name.Text))
            {
                MessageBox.Show("The name is undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("The lastname is undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                MessageBox.Show("The password is undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("The password are different, please check it", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("The email is undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbStatus.SelectedItem is null)
            {
                MessageBox.Show("The status is undefined, please select anything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (clbRol.SelectedItem is null)
            {
                MessageBox.Show("The rol is undefined, please select anything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyContent())
                {
                    var selectedItem = dgvUser.SelectedRows[0].DataBoundItem as User;
                    if (selectedItem != null)
                    {
                        selectedItem.Usernaem = txtUsername.Text;
                        selectedItem.Password = txtPassword.Text;
                        selectedItem.Status = cmbStatus.SelectedIndex == 0 ? true : false;
                        selectedItem.Email = txtEmail.Text;
                        selectedItem.LastName = txtLastName.Text;
                        selectedItem.Name = txtName.Text;
                        selectedItem.Roles.Clear();
                        if (controller.UpdateUser(selectedItem))
                        {
                            MessageBox.Show("The user was modified", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateWindow();
                        }
                        else MessageBox.Show("The user wasnt modified", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Please, select an user", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = dgvUser.SelectedRows[0].DataBoundItem as User;
                if (selectedItem != null)
                {
                    if (controller.DeleteUser(selectedItem))
                    {
                        MessageBox.Show("User was deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Error delete", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error undefined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
