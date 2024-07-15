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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planner));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            passwordToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            btnSave = new Button();
            PainelEntradaSaida = new Panel();
            rdSaida = new RadioButton();
            rdEntrada = new RadioButton();
            DateOfEntryOrExit = new DateTimePicker();
            Titulo = new Label();
            PainelFundoBranco = new Panel();
            BoxFooter = new BoxRadio();
            dataGridView1 = new DataGridView();
            totalEntrada = new DataGridViewTextBoxColumn();
            totalSaida = new DataGridViewTextBoxColumn();
            totalRestante = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblCurrentTime = new Label();
            label2 = new Label();
            BoxPrencher = new BoxRadio();
            num_amount = new NumericUpDown();
            txtDescription = new TextBox();
            btnExcluir = new Button();
            btnAdd = new Button();
            cmbCategory = new ComboBox();
            BoxPlanner = new BoxRadio();
            dvPlanner = new DataGridView();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            btnDeleteTransaction = new DataGridViewButtonColumn();
            boxRadio1 = new BoxRadio();
            label4 = new Label();
            comboBox1 = new ComboBox();
            btnFilter = new Button();
            dateFilter = new DateTimePicker();
            timerCurrentTime = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            PainelEntradaSaida.SuspendLayout();
            PainelFundoBranco.SuspendLayout();
            BoxFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            BoxPrencher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_amount).BeginInit();
            BoxPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvPlanner).BeginInit();
            boxRadio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { passwordToolStripMenuItem, relatorioToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1273, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // passwordToolStripMenuItem
            // 
            passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            passwordToolStripMenuItem.Size = new Size(94, 27);
            passwordToolStripMenuItem.Text = "Password";
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(92, 27);
            relatorioToolStripMenuItem.Text = "Relatório";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(31, 477);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(322, 57);
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
            PainelEntradaSaida.Location = new Point(31, 389);
            PainelEntradaSaida.Name = "PainelEntradaSaida";
            PainelEntradaSaida.Size = new Size(322, 53);
            PainelEntradaSaida.TabIndex = 6;
            // 
            // rdSaida
            // 
            rdSaida.AutoSize = true;
            rdSaida.Location = new Point(181, 5);
            rdSaida.Name = "rdSaida";
            rdSaida.Size = new Size(104, 42);
            rdSaida.TabIndex = 6;
            rdSaida.Text = "Saída";
            rdSaida.UseVisualStyleBackColor = true;
            rdSaida.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdEntrada
            // 
            rdEntrada.AutoSize = true;
            rdEntrada.BackColor = Color.Transparent;
            rdEntrada.Checked = true;
            rdEntrada.ForeColor = Color.Black;
            rdEntrada.Location = new Point(34, 5);
            rdEntrada.Name = "rdEntrada";
            rdEntrada.Size = new Size(131, 42);
            rdEntrada.TabIndex = 5;
            rdEntrada.TabStop = true;
            rdEntrada.Text = "Entrada";
            rdEntrada.UseVisualStyleBackColor = false;
            // 
            // DateOfEntryOrExit
            // 
            DateOfEntryOrExit.CalendarForeColor = SystemColors.ActiveBorder;
            DateOfEntryOrExit.CalendarTitleForeColor = SystemColors.ActiveBorder;
            DateOfEntryOrExit.Location = new Point(31, 299);
            DateOfEntryOrExit.Name = "DateOfEntryOrExit";
            DateOfEntryOrExit.Size = new Size(323, 43);
            DateOfEntryOrExit.TabIndex = 4;
            DateOfEntryOrExit.Validating += DateOfEntryOrExit_Validating;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(66, 19);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(314, 31);
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
            PainelFundoBranco.Location = new Point(6, 39);
            PainelFundoBranco.Name = "PainelFundoBranco";
            PainelFundoBranco.Padding = new Padding(5);
            PainelFundoBranco.Size = new Size(1267, 816);
            PainelFundoBranco.TabIndex = 3;
            PainelFundoBranco.Paint += panel2_Paint;
            // 
            // BoxFooter
            // 
            BoxFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BoxFooter.AutoSize = true;
            BoxFooter.BackColor = SystemColors.ActiveBorder;
            BoxFooter.BorderRadius = 40;
            BoxFooter.Controls.Add(dataGridView1);
            BoxFooter.Controls.Add(label3);
            BoxFooter.Controls.Add(lblCurrentTime);
            BoxFooter.Controls.Add(label2);
            BoxFooter.Location = new Point(8, 652);
            BoxFooter.Name = "BoxFooter";
            BoxFooter.Size = new Size(1251, 156);
            BoxFooter.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { totalEntrada, totalSaida, totalRestante });
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(783, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(461, 59);
            dataGridView1.TabIndex = 4;
            // 
            // totalEntrada
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0,00";
            totalEntrada.DefaultCellStyle = dataGridViewCellStyle1;
            totalEntrada.HeaderText = "Entrada";
            totalEntrada.MinimumWidth = 6;
            totalEntrada.Name = "totalEntrada";
            totalEntrada.ReadOnly = true;
            // 
            // totalSaida
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0,00";
            totalSaida.DefaultCellStyle = dataGridViewCellStyle2;
            totalSaida.HeaderText = "Saida";
            totalSaida.MinimumWidth = 6;
            totalSaida.Name = "totalSaida";
            totalSaida.ReadOnly = true;
            // 
            // totalRestante
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0,00";
            totalRestante.DefaultCellStyle = dataGridViewCellStyle3;
            totalRestante.HeaderText = "Saldo";
            totalRestante.MinimumWidth = 6;
            totalRestante.Name = "totalRestante";
            totalRestante.ReadOnly = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(899, 23);
            label3.Name = "label3";
            label3.Size = new Size(227, 48);
            label3.TabIndex = 3;
            label3.Text = "Controle:";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentTime.ForeColor = SystemColors.Control;
            lblCurrentTime.Location = new Point(17, 52);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(347, 91);
            lblCurrentTime.TabIndex = 1;
            lblCurrentTime.Text = "22:35:00";
            lblCurrentTime.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(56, 11);
            label2.Name = "label2";
            label2.Size = new Size(277, 48);
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
            BoxPrencher.Location = new Point(8, 57);
            BoxPrencher.Name = "BoxPrencher";
            BoxPrencher.Padding = new Padding(5);
            BoxPrencher.Size = new Size(397, 589);
            BoxPrencher.TabIndex = 1;
            // 
            // num_amount
            // 
            num_amount.DecimalPlaces = 2;
            num_amount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            num_amount.Location = new Point(31, 119);
            num_amount.Margin = new Padding(3, 4, 3, 4);
            num_amount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            num_amount.Name = "num_amount";
            num_amount.Size = new Size(327, 43);
            num_amount.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(31, 43);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Descrição";
            txtDescription.Size = new Size(322, 43);
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
            btnExcluir.Location = new Point(355, 209);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(27, 45);
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
            btnAdd.Location = new Point(319, 209);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 45);
            btnAdd.TabIndex = 9;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(31, 209);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(281, 45);
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
            BoxPlanner.Controls.Add(dvPlanner);
            BoxPlanner.Location = new Point(411, 57);
            BoxPlanner.Name = "BoxPlanner";
            BoxPlanner.Padding = new Padding(5);
            BoxPlanner.Size = new Size(851, 589);
            BoxPlanner.TabIndex = 0;
            // 
            // dvPlanner
            // 
            dvPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvPlanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvPlanner.BorderStyle = BorderStyle.Fixed3D;
            dvPlanner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvPlanner.Columns.AddRange(new DataGridViewColumn[] { Descricao, Valor, Data, Tipo, Categoria, btnDeleteTransaction });
            dvPlanner.Location = new Point(10, 13);
            dvPlanner.Name = "dvPlanner";
            dvPlanner.ReadOnly = true;
            dvPlanner.RowHeadersVisible = false;
            dvPlanner.RowHeadersWidth = 51;
            dvPlanner.Size = new Size(831, 564);
            dvPlanner.TabIndex = 0;
            dvPlanner.TabStop = false;
            dvPlanner.CellEndEdit += dvPlanner_CellEndEdit;
            dvPlanner.CellValueChanged += dvPlanner_CellValueChanged;
            // 
            // Descricao
            // 
            Descricao.FillWeight = 30F;
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.FillWeight = 10F;
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Data
            // 
            Data.FillWeight = 20F;
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.FillWeight = 15F;
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 20F;
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // btnDeleteTransaction
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            btnDeleteTransaction.DefaultCellStyle = dataGridViewCellStyle4;
            btnDeleteTransaction.FillWeight = 5F;
            btnDeleteTransaction.FlatStyle = FlatStyle.Flat;
            btnDeleteTransaction.HeaderText = "Deletar";
            btnDeleteTransaction.MinimumWidth = 6;
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.ReadOnly = true;
            btnDeleteTransaction.Text = "X";
            btnDeleteTransaction.UseColumnTextForButtonValue = true;
            // 
            // boxRadio1
            // 
            boxRadio1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            boxRadio1.BackColor = SystemColors.ActiveBorder;
            boxRadio1.BorderRadius = 40;
            boxRadio1.Controls.Add(label4);
            boxRadio1.Controls.Add(comboBox1);
            boxRadio1.Controls.Add(btnFilter);
            boxRadio1.Controls.Add(dateFilter);
            boxRadio1.Location = new Point(515, 8);
            boxRadio1.Name = "boxRadio1";
            boxRadio1.Size = new Size(744, 43);
            boxRadio1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 7);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 10;
            label4.Text = "Filtro";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(281, 28);
            comboBox1.TabIndex = 9;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = AnchorStyles.None;
            btnFilter.Location = new Point(628, 8);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(87, 29);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Aplicar";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // dateFilter
            // 
            dateFilter.Anchor = AnchorStyles.None;
            dateFilter.Format = DateTimePickerFormat.Short;
            dateFilter.Location = new Point(369, 8);
            dateFilter.Name = "dateFilter";
            dateFilter.Size = new Size(250, 27);
            dateFilter.TabIndex = 6;
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
            // Planner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1279, 861);
            Controls.Add(PainelFundoBranco);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimumSize = new Size(1180, 895);
            Name = "Planner";
            Padding = new Padding(3);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            BoxPrencher.ResumeLayout(false);
            BoxPrencher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_amount).EndInit();
            BoxPlanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvPlanner).EndInit();
            boxRadio1.ResumeLayout(false);
            boxRadio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
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
        private DateTimePicker dateFilter;
        private BoxRadio boxRadio1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewButtonColumn btnDeleteTransaction;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn totalEntrada;
        private DataGridViewTextBoxColumn totalSaida;
        private DataGridViewTextBoxColumn totalRestante;
    }
}