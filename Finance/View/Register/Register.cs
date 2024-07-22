using Finance.Helpers.Validations;

namespace MeuProjeto
{
    public partial class Register : Form
    {
        private readonly UserController _controller;
        private bool _shouldValidate;

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
            _shouldValidate = true;

            if (ValidateChildren())
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                var result = _controller.Register(name, email, password);

                if (result.Success)
                {
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }

                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
            }

            _shouldValidate = false;
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
                e.Cancel = _shouldValidate;
            }
            else if (nome.Length > 100)  
            {
                errorProvider.SetError(txtName, "Nome  não pode ter mais de 100 caracteres.");
                e.Cancel = _shouldValidate;
            }
            else if (nome.Length < 3)
            {
                errorProvider.SetError(txtName, "Nome deve conter pelo menos 3 caracteres.");
                e.Cancel = _shouldValidate;
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
                errorProvider.SetError(txtEmail, "Campo de e-mail não pode estar vazio.");
                e.Cancel = _shouldValidate;
            }
            else if (txtEmail.Text.Length < 3)
            {
                errorProvider.SetError(txtName, "Nome  não pode ter mais de 200 caracteres.");
                e.Cancel = _shouldValidate;
            }
            else if (!Validations.EmailIsValid(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "E-mail em formato inválido.");
                e.Cancel = _shouldValidate;
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
                errorProvider.SetError(txtPassword, "A senha não pode estar vazia.");
                e.Cancel = _shouldValidate;
            }
            else if (!Validations.PasswordIsValid(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Senha inválida. A senha deve conter no mínimo 8 caracteres, uma letra maíscula e um caracter especial.");
                if (_shouldValidate) e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }
    }
}
