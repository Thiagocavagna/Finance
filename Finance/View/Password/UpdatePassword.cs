using Finance.Helpers.Validations;
using System.ComponentModel;
using System.Windows.Forms;

namespace Finance.View.Password
{

    public partial class UpdatePassword : Form
    {
        private readonly UserController _userController;
        private bool _shouldValidate;
        public UpdatePassword()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var SenhaAtual = txtSenhaAtual.Text;
                var SenhaNova = txtNovaSenha.Text;
                var SenhaConfirm = txtConfirmSenha.Text;
                
                _userController.UpdatePassword(SenhaAtual, SenhaNova, SenhaConfirm);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void txtSenhaAtual_Validating(object sender, CancelEventArgs e)
        {
            string senha = txtSenhaAtual.Text.Trim();
            if (string.IsNullOrEmpty(senha)) {
                errorPassword.SetError(txtSenhaAtual, "O campo Senha não pode estar vazio.");
                e.Cancel = _shouldValidate;
            }
            else if (!Validations.PasswordIsValid(txtSenhaAtual.Text))
            {
                errorPassword.SetError(txtSenhaAtual, "Senha inválida. A senha deve conter no mínimo 8 caracteres e um caracter especial.");
                if (_shouldValidate) e.Cancel = true;
            }
            else
            {
                errorPassword.SetError(txtSenhaAtual, null);
            }
        }

        private void txtNovaSenha_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
            {
                errorPassword.SetError(txtNovaSenha, "O campo nova senha esta vazio");
                e.Cancel = _shouldValidate;
            }
            else if (!Validations.PasswordIsValid(txtNovaSenha.Text)) //TODO: VALIDAR SE EXISTE
            {
                errorPassword.SetError(txtNovaSenha, "Senha não esta no formato valido.");
                e.Cancel= _shouldValidate;
            }
            else
            {
                errorPassword.SetError(txtNovaSenha, null);
            }
        }

        private void txtConfirmSenha_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmSenha.Text))
            {
                errorPassword.SetError(txtConfirmSenha, "O campo nova senha esta vazio");
                e.Cancel = _shouldValidate;
            }
            else if (!Validations.PasswordIsValid(txtConfirmSenha.Text)) //TODO: VALIDAR SE EXISTE
            {
                errorPassword.SetError(txtConfirmSenha, "Senha não esta no formato valido.");
                e.Cancel = _shouldValidate;
            }
            else
            {
                errorPassword.SetError(txtConfirmSenha, null);
            }
        }
    }
}
