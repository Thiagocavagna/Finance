namespace MeuProjeto
{
    public partial class Register : Form
    {
        private readonly UserController _controller;

        public Register()
        {
            InitializeComponent();
            _controller = new UserController();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            _controller.Register(name, email, password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Visible = false;
        }
    }
}
