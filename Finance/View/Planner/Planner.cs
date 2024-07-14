using Finance.Controller.TransactionController;
using Finance.Data;
using Finance.Data.Repositories;
using Finance.Model.Enumerations;
using Finance.View.TCategory;
using Finance_Project.Model.Entities;
using System.Diagnostics.Eventing.Reader;

namespace Finance.View.Planner
{
    public partial class Planner : Form
    {
        private readonly CategoryController _controller;
        private readonly TransactionController _transactionController;
        public Planner()
        {
            InitializeComponent();
            _controller = new CategoryController(new CategoryRepository(new FinanceDbContext()));
            _transactionController = new TransactionController(new TransactionRepository(new FinanceDbContext()));

            LoadCategories();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxRadio1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Planner_Load(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            timerCurrentTime.Start();
            rdEntrada.Checked = true;
        }

        private void Planner_MaximizedBoundsChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var register = new RegisterCategory();
            register.CategoryAdded += EventoLoadCategory;
            register.Show();
        }
        public void LoadCategories()
        {
            var categories = _controller.GetAllCategories();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name"; // Propriedade a ser exibida
            cmbCategory.ValueMember = "Id";    // Propriedade de valor
        }
        private void EventoLoadCategory(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selectedCategory = (Category)cmbCategory.SelectedItem;
            if (selectedCategory != null)
            {
                _controller.RemoveCategory(selectedCategory);
                LoadCategories();
                cmbCategory.Text = "";
            }
            else
                MessageBox.Show("Selecione uma categoria para excluir");
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            DateTime registerDate = Convert.ToDateTime(DateOfEntryOrExit.Text);
            TransactionType transactionType;
            if(rdEntrada.Checked)
            {
                transactionType = TransactionType.Receipts;
            }
            else
            {
                transactionType = TransactionType.Expense;
            }
            Category category = (Category)cmbCategory.SelectedItem;

            _transactionController.SaveTransaction(description,amount,registerDate,transactionType,category);
        }
    }
}
