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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            passwordToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            btnSave = new Button();
            PainelEntradaSaida = new Panel();
            rdSaida = new RadioButton();
            rdEntrada = new RadioButton();
            DateOfEntryOrExit = new DateTimePicker();
            Titulo = new Label();
            txtAmount = new TextBox();
            PainelFundoBranco = new Panel();
            BoxFooter = new BoxRadio();
            lblCurrentTime = new Label();
            label2 = new Label();
            BoxPrencher = new BoxRadio();
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
            txtDescription = new TextBox();
            menuStrip1.SuspendLayout();
            PainelEntradaSaida.SuspendLayout();
            PainelFundoBranco.SuspendLayout();
            BoxFooter.SuspendLayout();
            BoxPrencher.SuspendLayout();
            BoxPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvPlanner).BeginInit();
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
            rdSaida.Location = new Point(180, 5);
            rdSaida.Name = "rdSaida";
            rdSaida.Size = new Size(104, 42);
            rdSaida.TabIndex = 5;
            rdSaida.TabStop = true;
            rdSaida.Text = "Saída";
            rdSaida.UseVisualStyleBackColor = true;
            rdSaida.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdEntrada
            // 
            rdEntrada.AutoSize = true;
            rdEntrada.BackColor = Color.Transparent;
            rdEntrada.ForeColor = Color.Black;
            rdEntrada.Location = new Point(34, 5);
            rdEntrada.Name = "rdEntrada";
            rdEntrada.Size = new Size(131, 42);
            rdEntrada.TabIndex = 4;
            rdEntrada.TabStop = true;
            rdEntrada.Text = "Entrada";
            rdEntrada.UseVisualStyleBackColor = false;
            // 
            // DateOfEntryOrExit
            // 
            DateOfEntryOrExit.CalendarForeColor = SystemColors.ActiveBorder;
            DateOfEntryOrExit.CalendarTitleForeColor = SystemColors.ActiveBorder;
            DateOfEntryOrExit.Location = new Point(31, 298);
            DateOfEntryOrExit.Name = "DateOfEntryOrExit";
            DateOfEntryOrExit.Size = new Size(323, 43);
            DateOfEntryOrExit.TabIndex = 0;
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
            // txtAmount
            // 
            txtAmount.Location = new Point(31, 121);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Valor";
            txtAmount.Size = new Size(322, 43);
            txtAmount.TabIndex = 0;
            txtAmount.TextChanged += textBox1_TextChanged;
            // 
            // PainelFundoBranco
            // 
            PainelFundoBranco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PainelFundoBranco.BackColor = SystemColors.Window;
            PainelFundoBranco.Controls.Add(BoxFooter);
            PainelFundoBranco.Controls.Add(BoxPrencher);
            PainelFundoBranco.Controls.Add(BoxPlanner);
            PainelFundoBranco.Controls.Add(Titulo);
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
            BoxFooter.Controls.Add(lblCurrentTime);
            BoxFooter.Controls.Add(label2);
            BoxFooter.Location = new Point(8, 652);
            BoxFooter.Name = "BoxFooter";
            BoxFooter.Size = new Size(1251, 156);
            BoxFooter.TabIndex = 5;
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
            BoxPrencher.Controls.Add(txtDescription);
            BoxPrencher.Controls.Add(btnExcluir);
            BoxPrencher.Controls.Add(btnAdd);
            BoxPrencher.Controls.Add(cmbCategory);
            BoxPrencher.Controls.Add(txtAmount);
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
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ActiveBorder;
            btnExcluir.BackgroundImage = (Image)resources.GetObject("btnExcluir.BackgroundImage");
            btnExcluir.BackgroundImageLayout = ImageLayout.Center;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = SystemColors.ActiveBorder;
            btnExcluir.Location = new Point(355, 209);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(28, 45);
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
            cmbCategory.TabIndex = 8;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
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
            dvPlanner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvPlanner.Columns.AddRange(new DataGridViewColumn[] { Descricao, Valor, Data, Tipo, Categoria, Excluir });
            dvPlanner.Location = new Point(10, 13);
            dvPlanner.Name = "dvPlanner";
            dvPlanner.RowHeadersVisible = false;
            dvPlanner.RowHeadersWidth = 51;
            dvPlanner.Size = new Size(831, 564);
            dvPlanner.TabIndex = 0;
            // 
            // Descricao
            // 
            Descricao.FillWeight = 30F;
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
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
            Data.FillWeight = 20F;
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            // 
            // Tipo
            // 
            Tipo.FillWeight = 15F;
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            // 
            // Categoria
            // 
            Categoria.FillWeight = 20F;
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // Excluir
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            Excluir.DefaultCellStyle = dataGridViewCellStyle2;
            Excluir.FillWeight = 5F;
            Excluir.FlatStyle = FlatStyle.Flat;
            Excluir.HeaderText = "";
            Excluir.MinimumWidth = 6;
            Excluir.Name = "Excluir";
            // 
            // timerCurrentTime
            // 
            timerCurrentTime.Interval = 1000;
            timerCurrentTime.Tick += timerCurrentTime_Tick;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(31, 43);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Descrição";
            txtDescription.Size = new Size(322, 43);
            txtDescription.TabIndex = 11;
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
            MinimumSize = new Size(1181, 898);
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
            BoxPrencher.ResumeLayout(false);
            BoxPrencher.PerformLayout();
            BoxPlanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvPlanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private Panel PainelFundoBranco;
        private TextBox txtAmount;
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
        private ComboBox cmbCategory;
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
    }
}