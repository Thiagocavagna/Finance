using Finance.Helpers.Validations;

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

            var result = _controller.Register(name, email, password);


            if (result.Success)
            {
                Login loginForm = new();
                loginForm.Show();

                this.Hide(); //TODO: this.Close() está fechando tudo
            }

            MessageBox.Show(result.Message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Visible = false;
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string nome = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                errorProvider.SetError(txtName, "Campo de nome não pode estar vazio.");
                e.Cancel = false;               
            }
            else if (nome.Length < 3)
            {
                errorProvider.SetError(txtName, "Nome deve conter pelo menos 3 caracteres.");
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtName, null);
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Campo de nome não pode estar vazio.");
                e.Cancel = false;
            }
            if (!Validations.EmailIsValid(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "E-mail em formato inválido.");
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "A senha não pode estar vazio.");
                e.Cancel = false;
            }
            if (!Validations.PasswordIsValid(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Senha inválida. A senha deve conter no mínimo 8 caracteres e um caracter especial.");
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}
