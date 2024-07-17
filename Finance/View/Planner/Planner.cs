using Finance.Controller.TransactionController;
using Finance.Model.Enumerations;
using Finance.Model.Views;
using Finance.View.Password;
using Finance.View.TCategory;
using Finance_Project.Model.Entities;
using System.Globalization;

namespace Finance.View.Planner
{
    public partial class Planner : Form
    {
        private readonly CategoryController _controller;
        private readonly TransactionController _transactionController;
        private TransactionFilter _filter = new();

        public Planner()
        {
            InitializeComponent();
            _controller = new CategoryController();
            _transactionController = new TransactionController();

            dvPlanner.CellEndEdit += dvPlanner_CellEndEdit;

            LoadCategories();
            InitialLoadFilterCategories();
            LoadCategoriesIntoComboBoxColumn();
            InitializeFilters();
            LoadDataIntoDataGridView();
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
            var categories = _controller.GetAllCategories(); ;
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        public void InitialLoadFilterCategories()
        {
            LoadFilterCategories();

            cmbFilterCategory.SelectedIndex = -1;
            _filter.CategoryId = null;
        }

        public void LoadFilterCategories()
        {
            var categoriesFilter = _controller.GetAllCategories();
            cmbFilterCategory.DataSource = categoriesFilter;
            cmbFilterCategory.DisplayMember = "Name";
            cmbFilterCategory.ValueMember = "Id";
        }

        private void EventoLoadCategory(object sender, EventArgs e)
        {
            LoadCategories();
            LoadCategoriesIntoComboBoxColumn();
            InitialLoadFilterCategories();
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
        private void LoadCategoriesIntoComboBoxColumn()
        {
            var categories = _controller.GetAllCategories();
            var comboBoxColumn = dvPlanner.Columns["Category"] as DataGridViewComboBoxColumn;

            if (comboBoxColumn != null)
            {
                comboBoxColumn.DataSource = categories.ToList();
                comboBoxColumn.DisplayMember = "Name";
                comboBoxColumn.ValueMember = "Id";
            }
        }
        private void LoadDataIntoDataGridView()
        {
            dvPlanner.Rows.Clear();
            var transactions = _transactionController.GetByFilter(_filter);

            foreach (var transaction in transactions)
            {
                var formattedAmount = transaction.Amount.ToString("C", new CultureInfo("pt-BR"));
                dvPlanner.Rows.Add(transaction.Id, transaction.Description, formattedAmount, transaction.RegisterDate,
                    transaction.Type, transaction.Category.Id);
            }

            dvPlanner.ReadOnly = false;
            dvPlanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvPlanner.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvPlanner.AllowUserToAddRows = false;

            var expenseSum = transactions.Sum(x => x.Type == TransactionType.Expense ? x.Amount : 0);
            var receiptsSum = transactions.Sum(x => x.Type == TransactionType.Receipts ? x.Amount : 0);
            var balance = receiptsSum - expenseSum;

            dataGridView1.Rows[0].Cells["totalEntrada"].Value = receiptsSum;
            dataGridView1.Rows[0].Cells["totalSaida"].Value = expenseSum;
            dataGridView1.Rows[0].Cells["totalRestante"].Value = balance;
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

                if (_transactionController.Exists(description, amount, transactionType, category.Id, registerDate))
                {
                    MessageBox.Show("Já existe uma transação com esses dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //TODO: retornar um result
                _transactionController.SaveTransaction(description, amount, registerDate, transactionType, category);
                txtDescription.Text = "";
                num_amount.Value = 0;

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
            if (dvPlanner.IsCurrentRowDirty && e.ColumnIndex == dvPlanner.Columns.Count - 1)
            {
                SaveRow(e.RowIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterCategory.SelectedItem != null)
            {
                var selectedValue = cmbFilterCategory.SelectedItem as Category;

                if (Category == null)
                {
                    MessageBox.Show("Categoria inválida.");
                    return;
                }

                _filter.CategoryId = selectedValue.Id;
            }
        }

        private void dvPlanner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dvPlanner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dvPlanner.Columns["btnDeleteTransaction"].Index)
            {
                var transactionId = (Guid)dvPlanner.Rows[e.RowIndex].Cells["Id"].Value;
                var transaction = _transactionController.GetById(transactionId);

                var result = MessageBox.Show("Deseja realmente excluir a transação?",
                    "Excluir Transação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _transactionController.DeleteTransaction(transaction);
                    LoadDataIntoDataGridView();
                }
            }
        }

        private void dvPlanner_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveRow(int rowIndex)
        {
            DataGridViewRow editedRow = dvPlanner.Rows[rowIndex];

            if (editedRow.Cells["Id"].Value == null || editedRow.Cells["Id"].Value == DBNull.Value)
            {
                return;
            }

            var transactionId = (Guid)editedRow.Cells["Id"].Value;

            if (!Guid.TryParse(editedRow.Cells["Category"].Value.ToString(), out var categoryId))
            {
                MessageBox.Show("Categoria inválida.");
                return;
            }
            var amountString = editedRow.Cells["Valor"]?.Value?.ToString();
            var amount = amountString?.Replace("R$ ", "").Replace(",", ".");

            if (!decimal.TryParse(amount, NumberStyles.Number, CultureInfo.InvariantCulture, out var amountDecimal))
            {
                MessageBox.Show("Valor inválido para o campo 'Valor'.");
                return;
            }

            var description = editedRow.Cells["Descricao"].Value.ToString();
            var registerDate = Convert.ToDateTime(editedRow.Cells["Data"].Value);
            var type = (TransactionType)Enum.Parse(typeof(TransactionType), editedRow.Cells["Tipo"]?.Value?.ToString());


            TransactionRequest request = new TransactionRequest
            {
                Description = description,
                Amount = amountDecimal,
                RegisterDate = registerDate,
                CategoryId = categoryId,
                Type = type
            };

            var result = _transactionController.UpdateTransaction(transactionId, request);

            if (result.HasMessage)
                MessageBox.Show(result.Message);
        }

        private void dvPlanner_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dvPlanner.IsCurrentRowDirty)
            {
                SaveRow(e.RowIndex);
            }
        }

        private void dateFilterStart_ValueChanged(object sender, EventArgs e)
        {
            _filter.StartDate = dateFilterStart.Value;
        }

        private void dateFilterEnd_ValueChanged(object sender, EventArgs e)
        {
            _filter.EndDate = dateFilterEnd.Value;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            _filter = new();

            InitializeFilters();
            LoadDataIntoDataGridView();
        }

        private void InitializeFilters()
        {

            dateFilterEnd.Value = DateTime.Now.Date.AddDays(1).AddTicks(-1);
            dateFilterStart.Value = DateTime.Now.Date;
            cmbFilterCategory.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            UpdatePassword password = new UpdatePassword();
            password.Show();
        }

        private void categoryBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
