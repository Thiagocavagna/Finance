using System.ComponentModel;

namespace Finance.View.TCategory
{
    public partial class RegisterCategory : Form
    {
        private readonly CategoryController _controller;
        public event EventHandler CategoryAdded;
        private bool _shouldValidate;


        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public RegisterCategory()
        {
            InitializeComponent();
            _controller = new CategoryController();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _shouldValidate = true;
            if (ValidateChildren())
            {
                if (_controller.AlreadyExists(txtNameCategory.Text))
                {
                    MessageBox.Show("Já existe uma categoria com esse nome cadastrado!");
                    return;
                }

                CategoryName = txtNameCategory.Text;
                CategoryDescription = txtDescriptionCategory.Text;
                _controller.AddCategory(CategoryName, CategoryDescription);
                
                CategoryAdded.Invoke(this, EventArgs.Empty);
                txtDescriptionCategory.Text = "";
                txtNameCategory.Text = "";
                this.Close();
            }
            _shouldValidate = false;
        }

        private void txtNameCategory_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNameCategory.Text)) {
                txtNameCategory.Focus();
                errorCategory.SetError(txtNameCategory, "Campo obrigatório");
                e.Cancel = _shouldValidate;
            }
            else if (txtNameCategory.Text.Length > 100)
            {
                errorCategory.SetError(txtNameCategory, "A descrição não pode ter mais de 100 caracteres.");
                e.Cancel = _shouldValidate;
            }
            else
            {
                errorCategory.SetError(txtNameCategory, null);
            }
        }

        private void txtDescriptionCategory_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescriptionCategory.Text)) {
                txtDescriptionCategory.Focus();
                errorCategory.SetError(txtDescriptionCategory, "Campo obrigatório");
                e.Cancel = _shouldValidate;
            }
            else if (txtDescriptionCategory.Text.Length > 200)
            {
                errorCategory.SetError(txtDescriptionCategory, "A descrição não pode ter mais de 200 caracteres.");
                e.Cancel = _shouldValidate;
            }
            else
            {
                errorCategory.SetError(txtDescriptionCategory, null);
            }
        }
    }
}
