namespace Finance.View.Planner
{
    partial class Planner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planner));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            btnPassword = new ToolStripMenuItem();
            btnSave = new Button();
            PainelEntradaSaida = new Panel();
            rdSaida = new RadioButton();
            rdEntrada = new RadioButton();
            DateOfEntryOrExit = new DateTimePicker();
            Titulo = new Label();
            PainelFundoBranco = new Panel();
            BoxFooter = new BoxRadio();
            lblCurrentTime = new Label();
            label2 = new Label();
            BoxPrencher = new BoxRadio();
            num_amount = new NumericUpDown();
            txtDescription = new TextBox();
            btnExcluir = new Button();
            btnAdd = new Button();
            cmbCategory = new ComboBox();
            BoxPlanner = new BoxRadio();
            dataGridView1 = new DataGridView();
            totalEntrada = new DataGridViewTextBoxColumn();
            totalSaida = new DataGridViewTextBoxColumn();
            totalRestante = new DataGridViewTextBoxColumn();
            dvPlanner = new DataGridView();
            boxRadio1 = new BoxRadio();
            btn_limpar = new Button();
            lbla = new Label();
            dateFilterStart = new DateTimePicker();
            label4 = new Label();
            cmbFilterCategory = new ComboBox();
            btnFilter = new Button();
            dateFilterEnd = new DateTimePicker();
            categoryBindingSource = new BindingSource(components);
            timerCurrentTime = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            categoryBindingSource1 = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            cmb_Type = new DataGridViewComboBoxColumn();
            Category = new DataGridViewComboBoxColumn();
            btnDeleteTransaction = new DataGridViewButtonColumn();
            menuStrip1.SuspendLayout();
            PainelEntradaSaida.SuspendLayout();
            PainelFundoBranco.SuspendLayout();
            BoxFooter.SuspendLayout();
            BoxPrencher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_amount).BeginInit();
            BoxPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvPlanner).BeginInit();
            boxRadio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnPassword });
            menuStrip1.Location = new Point(3, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1113, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnPassword
            // 
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(79, 23);
            btnPassword.Text = "Password";
            btnPassword.Click += btnPassword_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 358);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(282, 43);
            btnSave.TabIndex = 7;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // PainelEntradaSaida
            // 
            PainelEntradaSaida.BackColor = SystemColors.ButtonShadow;
            PainelEntradaSaida.Controls.Add(rdSaida);
            PainelEntradaSaida.Controls.Add(rdEntrada);
            PainelEntradaSaida.Location = new Point(27, 292);
            PainelEntradaSaida.Margin = new Padding(3, 2, 3, 2);
            PainelEntradaSaida.Name = "PainelEntradaSaida";
            PainelEntradaSaida.Size = new Size(282, 40);
            PainelEntradaSaida.TabIndex = 6;
            // 
            // rdSaida
            // 
            rdSaida.AutoSize = true;
            rdSaida.Location = new Point(158, 4);
            rdSaida.Margin = new Padding(3, 2, 3, 2);
            rdSaida.Name = "rdSaida";
            rdSaida.Size = new Size(83, 34);
            rdSaida.TabIndex = 6;
            rdSaida.Text = "Saída";
            rdSaida.UseVisualStyleBackColor = true;
            // 
            // rdEntrada
            // 
            rdEntrada.AutoSize = true;
            rdEntrada.BackColor = Color.Transparent;
            rdEntrada.Checked = true;
            rdEntrada.ForeColor = Color.Black;
            rdEntrada.Location = new Point(30, 4);
            rdEntrada.Margin = new Padding(3, 2, 3, 2);
            rdEntrada.Name = "rdEntrada";
            rdEntrada.Size = new Size(104, 34);
            rdEntrada.TabIndex = 5;
            rdEntrada.TabStop = true;
            rdEntrada.Text = "Entrada";
            rdEntrada.UseVisualStyleBackColor = false;
            // 
            // DateOfEntryOrExit
            // 
            DateOfEntryOrExit.CalendarForeColor = SystemColors.ActiveBorder;
            DateOfEntryOrExit.CalendarTitleForeColor = SystemColors.ActiveBorder;
            DateOfEntryOrExit.Format = DateTimePickerFormat.Short;
            DateOfEntryOrExit.Location = new Point(27, 224);
            DateOfEntryOrExit.Margin = new Padding(3, 2, 3, 2);
            DateOfEntryOrExit.Name = "DateOfEntryOrExit";
            DateOfEntryOrExit.Size = new Size(283, 36);
            DateOfEntryOrExit.TabIndex = 4;
            DateOfEntryOrExit.Validating += DateOfEntryOrExit_Validating;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(44, 14);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(262, 25);
            Titulo.TabIndex = 1;
            Titulo.Text = "Preencha os campos abaixo:";
            // 
            // PainelFundoBranco
            // 
            PainelFundoBranco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PainelFundoBranco.BackColor = SystemColors.Window;
            PainelFundoBranco.Controls.Add(BoxFooter);
            PainelFundoBranco.Controls.Add(BoxPrencher);
            PainelFundoBranco.Controls.Add(BoxPlanner);
            PainelFundoBranco.Controls.Add(Titulo);
            PainelFundoBranco.Controls.Add(boxRadio1);
            PainelFundoBranco.Location = new Point(5, 29);
            PainelFundoBranco.Margin = new Padding(3, 2, 3, 2);
            PainelFundoBranco.Name = "PainelFundoBranco";
            PainelFundoBranco.Padding = new Padding(4);
            PainelFundoBranco.Size = new Size(1109, 612);
            PainelFundoBranco.TabIndex = 3;
            // 
            // BoxFooter
            // 
            BoxFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxFooter.AutoSize = true;
            BoxFooter.BackColor = SystemColors.ActiveBorder;
            BoxFooter.BorderRadius = 40;
            BoxFooter.Controls.Add(lblCurrentTime);
            BoxFooter.Controls.Add(label2);
            BoxFooter.Location = new Point(7, 489);
            BoxFooter.Margin = new Padding(3, 2, 3, 2);
            BoxFooter.Name = "BoxFooter";
            BoxFooter.Size = new Size(1095, 117);
            BoxFooter.TabIndex = 5;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentTime.ForeColor = SystemColors.Control;
            lblCurrentTime.Location = new Point(15, 39);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(284, 73);
            lblCurrentTime.TabIndex = 1;
            lblCurrentTime.Text = "22:35:00";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(48, 4);
            label2.Name = "label2";
            label2.Size = new Size(222, 38);
            label2.TabIndex = 0;
            label2.Text = "Hora Atual:";
            // 
            // BoxPrencher
            // 
            BoxPrencher.AccessibleRole = AccessibleRole.TitleBar;
            BoxPrencher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BoxPrencher.AutoSize = true;
            BoxPrencher.BackColor = SystemColors.ActiveBorder;
            BoxPrencher.BorderRadius = 40;
            BoxPrencher.Controls.Add(num_amount);
            BoxPrencher.Controls.Add(txtDescription);
            BoxPrencher.Controls.Add(btnExcluir);
            BoxPrencher.Controls.Add(btnAdd);
            BoxPrencher.Controls.Add(cmbCategory);
            BoxPrencher.Controls.Add(btnSave);
            BoxPrencher.Controls.Add(PainelEntradaSaida);
            BoxPrencher.Controls.Add(DateOfEntryOrExit);
            BoxPrencher.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BoxPrencher.Location = new Point(7, 43);
            BoxPrencher.Margin = new Padding(3, 2, 3, 2);
            BoxPrencher.Name = "BoxPrencher";
            BoxPrencher.Padding = new Padding(4);
            BoxPrencher.Size = new Size(347, 442);
            BoxPrencher.TabIndex = 1;
            // 
            // num_amount
            // 
            num_amount.DecimalPlaces = 2;
            num_amount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            num_amount.Location = new Point(27, 89);
            num_amount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            num_amount.Name = "num_amount";
            num_amount.Size = new Size(286, 36);
            num_amount.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(27, 32);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Descrição";
            txtDescription.Size = new Size(282, 36);
            txtDescription.TabIndex = 1;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ActiveBorder;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ActiveBorder;
            btnExcluir.Location = new Point(311, 157);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(24, 34);
            btnExcluir.TabIndex = 10;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveBorder;
            btnAdd.Location = new Point(279, 157);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(25, 34);
            btnAdd.TabIndex = 9;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(27, 157);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(246, 38);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbCategory.Validating += cmbCategory_Validating;
            // 
            // BoxPlanner
            // 
            BoxPlanner.AccessibleRole = AccessibleRole.TitleBar;
            BoxPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxPlanner.AutoScroll = true;
            BoxPlanner.AutoSize = true;
            BoxPlanner.BackColor = SystemColors.ActiveBorder;
            BoxPlanner.BorderRadius = 40;
            BoxPlanner.Controls.Add(dataGridView1);
            BoxPlanner.Controls.Add(dvPlanner);
            BoxPlanner.Location = new Point(360, 43);
            BoxPlanner.Margin = new Padding(3, 2, 3, 2);
            BoxPlanner.Name = "BoxPlanner";
            BoxPlanner.Padding = new Padding(4);
            BoxPlanner.Size = new Size(745, 442);
            BoxPlanner.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { totalEntrada, totalSaida, totalRestante });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.GridColor = Color.Green;
            dataGridView1.Location = new Point(17, 381);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(716, 44);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // totalEntrada
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            totalEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            totalEntrada.HeaderText = "Entrada";
            totalEntrada.MinimumWidth = 6;
            totalEntrada.Name = "totalEntrada";
            totalEntrada.ReadOnly = true;
            // 
            // totalSaida
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0,00";
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            totalSaida.DefaultCellStyle = dataGridViewCellStyle3;
            totalSaida.HeaderText = "Saida";
            totalSaida.MinimumWidth = 6;
            totalSaida.Name = "totalSaida";
            totalSaida.ReadOnly = true;
            // 
            // totalRestante
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0,00";
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            totalRestante.DefaultCellStyle = dataGridViewCellStyle4;
            totalRestante.HeaderText = "Saldo";
            totalRestante.MinimumWidth = 6;
            totalRestante.Name = "totalRestante";
            totalRestante.ReadOnly = true;
            // 
            // dvPlanner
            // 
            dvPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvPlanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvPlanner.BackgroundColor = SystemColors.ActiveBorder;
            dvPlanner.BorderStyle = BorderStyle.Fixed3D;
            dvPlanner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvPlanner.Columns.AddRange(new DataGridViewColumn[] { Id, Descricao, Valor, Data, cmb_Type, Category, btnDeleteTransaction });
            dvPlanner.Location = new Point(21, 10);
            dvPlanner.Margin = new Padding(3, 2, 3, 2);
            dvPlanner.Name = "dvPlanner";
            dvPlanner.RowHeadersVisible = false;
            dvPlanner.RowHeadersWidth = 51;
            dvPlanner.Size = new Size(717, 367);
            dvPlanner.TabIndex = 0;
            dvPlanner.TabStop = false;
            dvPlanner.CellClick += dvPlanner_CellClick;
            dvPlanner.CellContentClick += dvPlanner_CellContentClick;
            dvPlanner.CellEndEdit += dvPlanner_CellEndEdit;
            dvPlanner.CellValueChanged += dvPlanner_CellValueChanged;
            dvPlanner.RowLeave += dvPlanner_RowLeave;
            dvPlanner.RowValidated += dvPlanner_RowValidated;
            // 
            // boxRadio1
            // 
            boxRadio1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxRadio1.BackColor = SystemColors.ActiveBorder;
            boxRadio1.BorderRadius = 40;
            boxRadio1.Controls.Add(btn_limpar);
            boxRadio1.Controls.Add(lbla);
            boxRadio1.Controls.Add(dateFilterStart);
            boxRadio1.Controls.Add(label4);
            boxRadio1.Controls.Add(cmbFilterCategory);
            boxRadio1.Controls.Add(btnFilter);
            boxRadio1.Controls.Add(dateFilterEnd);
            boxRadio1.Location = new Point(369, 6);
            boxRadio1.Margin = new Padding(3, 2, 3, 2);
            boxRadio1.Name = "boxRadio1";
            boxRadio1.Size = new Size(733, 32);
            boxRadio1.TabIndex = 8;
            // 
            // btn_limpar
            // 
            btn_limpar.Anchor = AnchorStyles.None;
            btn_limpar.Location = new Point(639, 6);
            btn_limpar.Margin = new Padding(3, 2, 3, 2);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(76, 22);
            btn_limpar.TabIndex = 13;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // lbla
            // 
            lbla.Anchor = AnchorStyles.None;
            lbla.AutoSize = true;
            lbla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbla.Location = new Point(429, 5);
            lbla.Name = "lbla";
            lbla.Size = new Size(34, 21);
            lbla.TabIndex = 12;
            lbla.Text = "até";
            // 
            // dateFilterStart
            // 
            dateFilterStart.Anchor = AnchorStyles.None;
            dateFilterStart.Format = DateTimePickerFormat.Short;
            dateFilterStart.Location = new Point(344, 5);
            dateFilterStart.Margin = new Padding(3, 2, 3, 2);
            dateFilterStart.Name = "dateFilterStart";
            dateFilterStart.Size = new Size(79, 23);
            dateFilterStart.TabIndex = 11;
            dateFilterStart.ValueChanged += dateFilterStart_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 5);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 10;
            label4.Text = "Filtro";
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.Anchor = AnchorStyles.None;
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Location = new Point(90, 5);
            cmbFilterCategory.Margin = new Padding(3, 2, 3, 2);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(246, 23);
            cmbFilterCategory.TabIndex = 9;
            cmbFilterCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.None;
            btnFilter.Location = new Point(557, 6);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(76, 22);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Aplicar";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dateFilterEnd
            // 
            dateFilterEnd.Anchor = AnchorStyles.None;
            dateFilterEnd.Format = DateTimePickerFormat.Short;
            dateFilterEnd.Location = new Point(470, 5);
            dateFilterEnd.Margin = new Padding(3, 2, 3, 2);
            dateFilterEnd.Name = "dateFilterEnd";
            dateFilterEnd.Size = new Size(79, 23);
            dateFilterEnd.TabIndex = 6;
            dateFilterEnd.ValueChanged += dateFilterEnd_ValueChanged;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Finance_Project.Model.Entities.Category);
            // 
            // timerCurrentTime
            // 
            timerCurrentTime.Interval = 1000;
            timerCurrentTime.Tick += timerCurrentTime_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeft = true;
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Finance_Project.Model.Entities.Category);
            categoryBindingSource1.CurrentChanged += categoryBindingSource1_CurrentChanged;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Descricao.FillWeight = 40F;
            Descricao.Frozen = true;
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.Width = 217;
            // 
            // Valor
            // 
            Valor.FillWeight = 10F;
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            // 
            // Data
            // 
            Data.FillWeight = 10F;
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            // 
            // cmb_Type
            // 
            cmb_Type.DataPropertyName = "Type";
            cmb_Type.FillWeight = 15F;
            cmb_Type.HeaderText = "Tipo";
            cmb_Type.Items.AddRange(new object[] { "Entrada", "Saida" });
            cmb_Type.MinimumWidth = 6;
            cmb_Type.Name = "cmb_Type";
            cmb_Type.Resizable = DataGridViewTriState.True;
            cmb_Type.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Category
            // 
            Category.DataPropertyName = "CategoryId";
            Category.FillWeight = 20F;
            Category.HeaderText = "Categoria";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Resizable = DataGridViewTriState.True;
            Category.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnDeleteTransaction
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Red;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            btnDeleteTransaction.DefaultCellStyle = dataGridViewCellStyle6;
            btnDeleteTransaction.FillWeight = 5F;
            btnDeleteTransaction.FlatStyle = FlatStyle.Flat;
            btnDeleteTransaction.HeaderText = "Deletar";
            btnDeleteTransaction.MinimumWidth = 6;
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Text = "X";
            btnDeleteTransaction.UseColumnTextForButtonValue = true;
            // 
            // Planner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1119, 646);
            Controls.Add(PainelFundoBranco);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimumSize = new Size(1034, 679);
            Name = "Planner";
            Padding = new Padding(3, 2, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planner";
            WindowState = FormWindowState.Maximized;
            MaximizedBoundsChanged += Planner_MaximizedBoundsChanged;
            Load += Planner_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            PainelEntradaSaida.ResumeLayout(false);
            PainelEntradaSaida.PerformLayout();
            PainelFundoBranco.ResumeLayout(false);
            PainelFundoBranco.PerformLayout();
            BoxFooter.ResumeLayout(false);
            BoxFooter.PerformLayout();
            BoxPrencher.ResumeLayout(false);
            BoxPrencher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_amount).EndInit();
            BoxPlanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvPlanner).EndInit();
            boxRadio1.ResumeLayout(false);
            boxRadio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnPassword;
        private Panel PainelFundoBranco;
        private Label Titulo;
        private DateTimePicker DateOfEntryOrExit;
        private RadioButton rdSaida;
        private RadioButton rdEntrada;
        private Panel PainelEntradaSaida;
        private Button btnSave;
        private BoxRadio BoxPlanner;
        private BoxRadio BoxPrencher;
        private BoxRadio BoxFooter;
        private DataGridView dvPlanner;
        private Button btnAdd;
        private Label lblCurrentTime;
        private Label label2;
        private Button btnExcluir;
        private DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.Timer timerCurrentTime;
        private TextBox txtDescription;
        private ErrorProvider errorProvider1;
        private NumericUpDown num_amount;
        private ComboBox cmbCategory;
        private Button btnFilter;
        private DateTimePicker dateFilterEnd;
        private BoxRadio boxRadio1;
        private ComboBox cmbFilterCategory;
        private Label label4;
        private DataGridView dataGridView1;
        private BindingSource categoryBindingSource;
        private Label lbla;
        private DateTimePicker dateFilterStart;
        private BindingSource categoryBindingSource1;
        private Button btn_limpar;
        private DataGridViewTextBoxColumn totalEntrada;
        private DataGridViewTextBoxColumn totalSaida;
        private DataGridViewTextBoxColumn totalRestante;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewComboBoxColumn cmb_Type;
        private DataGridViewComboBoxColumn Category;
        private DataGridViewButtonColumn btnDeleteTransaction;
    }
}