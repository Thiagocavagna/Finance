using Finance.Service;
using Finance_Project.Model.Entities;

namespace MeuProjeto
{
    public partial class Register : Form
    {
        private UserService _usuarioService;
        public Register()
        {
            InitializeComponent();

            //_usuarioService = new UserService(new FinanceDbContext());//
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Visible = false;

            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            User novoUsuario = new User
            {
                Name = name,
                Email = email,
                Password = password
            };
            //bool cadastroSucesso =  

            //if (cadastroSucesso)
            //{
            //    MessageBox.Show("Cadastro realizado com sucesso!");
            //    //LimparCampos();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Visible = false;
        }
    }
}
