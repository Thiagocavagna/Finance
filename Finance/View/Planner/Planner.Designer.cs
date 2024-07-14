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
            Excluir = new DataGridViewButtonColumn();
            timerCurrentTime = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            PainelEntradaSaida.SuspendLayout();
            PainelFundoBranco.SuspendLayout();
            BoxFooter.SuspendLayout();
            BoxPrencher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_amount).BeginInit();
            BoxPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvPlanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { passwordToolStripMenuItem, relatorioToolStripMenuItem });
            menuStrip1.Location = new Point(3, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1113, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // passwordToolStripMenuItem
            // 
            passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            passwordToolStripMenuItem.Size = new Size(79, 23);
            passwordToolStripMenuItem.Text = "Password";
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(75, 23);
            relatorioToolStripMenuItem.Text = "Relatório";
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
            rdSaida.CheckedChanged += radioButton2_CheckedChanged;
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
            Titulo.Location = new Point(58, 14);
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
            PainelFundoBranco.Location = new Point(5, 29);
            PainelFundoBranco.Margin = new Padding(3, 2, 3, 2);
            PainelFundoBranco.Name = "PainelFundoBranco";
            PainelFundoBranco.Padding = new Padding(4);
            PainelFundoBranco.Size = new Size(1109, 612);
            PainelFundoBranco.TabIndex = 3;
            PainelFundoBranco.Paint += panel2_Paint;
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
            lblCurrentTime.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(49, 8);
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
            BoxPlanner.Controls.Add(dvPlanner);
            BoxPlanner.Location = new Point(360, 43);
            BoxPlanner.Margin = new Padding(3, 2, 3, 2);
            BoxPlanner.Name = "BoxPlanner";
            BoxPlanner.Padding = new Padding(4);
            BoxPlanner.Size = new Size(745, 442);
            BoxPlanner.TabIndex = 0;
            // 
            // dvPlanner
            // 
            dvPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvPlanner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvPlanner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvPlanner.Columns.AddRange(new DataGridViewColumn[] { Descricao, Valor, Data, Tipo, Categoria, Excluir });
            dvPlanner.Location = new Point(9, 10);
            dvPlanner.Margin = new Padding(3, 2, 3, 2);
            dvPlanner.Name = "dvPlanner";
            dvPlanner.ReadOnly = true;
            dvPlanner.RowHeadersVisible = false;
            dvPlanner.RowHeadersWidth = 51;
            dvPlanner.Size = new Size(727, 423);
            dvPlanner.TabIndex = 0;
            dvPlanner.TabStop = false;
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
            // Excluir
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            Excluir.DefaultCellStyle = dataGridViewCellStyle1;
            Excluir.FillWeight = 5F;
            Excluir.FlatStyle = FlatStyle.Flat;
            Excluir.HeaderText = "";
            Excluir.MinimumWidth = 6;
            Excluir.Name = "Excluir";
            Excluir.ReadOnly = true;
            // 
            // timerCurrentTime
            // 
            timerCurrentTime.Interval = 1000;
            timerCurrentTime.Tick += timerCurrentTime_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
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
            MinimumSize = new Size(1035, 683);
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
            ((System.ComponentModel.ISupportInitialize)dvPlanner).EndInit();
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
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.Timer timerCurrentTime;
        private TextBox txtDescription;
        private ErrorProvider errorProvider1;
        private NumericUpDown num_amount;
        private ComboBox cmbCategory;
    }
}