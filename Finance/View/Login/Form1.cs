namespace MeuProjeto
{
    public partial class Login : Form
    {
        private readonly UserController _controller;

        public Login()
        {
            InitializeComponent();
            _controller = new UserController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            bool isValid = _controller.Login(password);

            if (isValid)
            {
                MessageBox.Show("Login successful!");
                // Continue to the next form or functionality
            }
            else
            {
                MessageBox.Show("Invalid password!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Visible = false;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
