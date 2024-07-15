using Finance.Controller.TransactionController;
using Finance.Data.Repositories;
using Finance.Model.Enumerations;
using Finance.View.TCategory;
using Finance_Project.Model.Entities;

namespace Finance.View.Planner
{
    public partial class Planner : Form
    {
        private readonly CategoryController _controller;
        private readonly TransactionController _transactionController;
        public Planner()
        {
            InitializeComponent();
            _controller = new CategoryController();
            _transactionController = new TransactionController();

            dvPlanner.CellEndEdit += dvPlanner_CellEndEdit;

            LoadCategories();
            LoadDataIntoDataGridView();
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

            if (selectedCategory == null)
            {
                MessageBox.Show("Selecione uma categoria para excluir");
                return;
            }

            if (_transactionController.HasAnyTransactionWithCategory(selectedCategory.Id))
            {
                MessageBox.Show("Não é possível excluir uma categoria que possui transações associadas");
                return;
            }

            var confirm = MessageBox.Show("Deseja realmente excluir a categoria?", "Excluir Categoria",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _controller.RemoveCategory(selectedCategory);
                LoadCategories();
                cmbCategory.Text = "";
            }
        }

        private void LoadDataIntoDataGridView()
        {
            var transactions = _transactionController.GetAll();

            dvPlanner.Rows.Clear();

            foreach (var transaction in transactions)
            {
                dvPlanner.Rows.Add(transaction.Description, transaction.Amount, transaction.RegisterDate, transaction.Type,
                    transaction.CategoryName);
            }

            dvPlanner.ReadOnly = true;
            dvPlanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvPlanner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvPlanner.AllowUserToAddRows = false;
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
            if (ValidateChildren())
            {
                string description = txtDescription.Text;
                decimal amount = num_amount.Value;
                DateTime registerDate = Convert.ToDateTime(DateOfEntryOrExit.Text);
                TransactionType transactionType;
                if (rdEntrada.Checked)
                {
                    transactionType = TransactionType.Receipts;
                }
                else
                {
                    transactionType = TransactionType.Expense;
                }
                var category = cmbCategory.SelectedItem as Category;

                if (category == null)
                {
                    MessageBox.Show("Selecione uma Categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_transactionController.Exists(amount, transactionType, category.Id, registerDate))
                {
                    MessageBox.Show("Já existe uma transação com esses dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //TODO: retornar um result
                _transactionController.SaveTransaction(description, amount, registerDate, transactionType, category);

                LoadDataIntoDataGridView();
            }
        }

        private void txtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "A descrição não pode estar vazia.");
            }
            else
            {
                errorProvider1.SetError(txtDescription, string.Empty);
            }
        }

        private void txtAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (num_amount.Value <= 0)
            {
                errorProvider1.SetError(num_amount, "O valor deve ser um número positivo.");
            }
            else
            {
                errorProvider1.SetError(num_amount, string.Empty);
            }
        }

        private void cmbCategory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
            {
                errorProvider1.SetError(cmbCategory, "Selecione uma Categoria.");
            }
            else
            {
                errorProvider1.SetError(cmbCategory, string.Empty);
            }
        }

        private void DateOfEntryOrExit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!DateTime.TryParse(DateOfEntryOrExit.Text, out DateTime registerDate))
            {
                errorProvider1.SetError(DateOfEntryOrExit, "A data informada é inválida.");
            }
            else
            {
                errorProvider1.SetError(DateOfEntryOrExit, string.Empty);
            }
        }

        private void dvPlanner_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvPlanner_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: Metodo para salvar a edição.
            var editedRow = dvPlanner.Rows[e.RowIndex];
            var transactionId = (Guid)editedRow.Cells["id"].Value;
            Transaction transaction = _transactionController.GetById(transactionId);

            if (transaction == null)
            {
                MessageBox.Show("Transação não encontrada");
                return;
            }

            _transactionController.UpdateTransaction(transaction.Description,transaction.Amount,transaction.RegisterDate,transaction.Type,transaction.Category);
        }
    }
}
