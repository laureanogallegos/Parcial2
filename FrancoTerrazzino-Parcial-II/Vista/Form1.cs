namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarGrupo_Click(object sender, EventArgs e)
        {
            FormGrupos form = new FormGrupos();
            form.Show();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.Show();
        }
    }
}
