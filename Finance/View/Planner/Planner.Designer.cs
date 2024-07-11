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
            menuStrip1 = new MenuStrip();
            passwordToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            panel4 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            boxRadio5 = new BoxRadio();
            label3 = new Label();
            label2 = new Label();
            boxRadio4 = new BoxRadio();
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            boxRadio2 = new BoxRadio();
            boxRadio3 = new BoxRadio();
            dataGridView1 = new DataGridView();
            Descricao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Excluir = new DataGridViewButtonColumn();
            pageSetupDialog1 = new PageSetupDialog();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            boxRadio5.SuspendLayout();
            boxRadio4.SuspendLayout();
            boxRadio3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // button1
            // 
            button1.Location = new Point(15, 306);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(282, 43);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(radioButton2);
            panel4.Controls.Add(radioButton1);
            panel4.Location = new Point(15, 240);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 40);
            panel4.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(172, 2);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 34);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Saída";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(38, 2);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 34);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Entrada";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveBorder;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ActiveBorder;
            dateTimePicker1.Location = new Point(15, 172);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 36);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 14);
            label1.Name = "label1";
            label1.Size = new Size(262, 25);
            label1.TabIndex = 1;
            label1.Text = "Preencha os campos abaixo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 39);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Valor";
            textBox1.Size = new Size(282, 36);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(boxRadio5);
            panel2.Controls.Add(boxRadio4);
            panel2.Controls.Add(boxRadio2);
            panel2.Controls.Add(boxRadio3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 31);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(1107, 611);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(558, 14);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 6;
            // 
            // boxRadio5
            // 
            boxRadio5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxRadio5.AutoSize = true;
            boxRadio5.BackColor = SystemColors.ActiveBorder;
            boxRadio5.BorderRadius = 40;
            boxRadio5.Controls.Add(label3);
            boxRadio5.Controls.Add(label2);
            boxRadio5.Location = new Point(7, 488);
            boxRadio5.Margin = new Padding(3, 2, 3, 2);
            boxRadio5.Name = "boxRadio5";
            boxRadio5.Size = new Size(1093, 131);
            boxRadio5.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(67, 46);
            label3.Name = "label3";
            label3.Size = new Size(194, 73);
            label3.TabIndex = 1;
            label3.Text = "22:35";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 10);
            label2.Name = "label2";
            label2.Size = new Size(222, 38);
            label2.TabIndex = 0;
            label2.Text = "Hora Atual:";
            // 
            // boxRadio4
            // 
            boxRadio4.AccessibleRole = AccessibleRole.TitleBar;
            boxRadio4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            boxRadio4.AutoSize = true;
            boxRadio4.BackColor = SystemColors.ActiveBorder;
            boxRadio4.BorderRadius = 40;
            boxRadio4.Controls.Add(button2);
            boxRadio4.Controls.Add(btnAdd);
            boxRadio4.Controls.Add(comboBox1);
            boxRadio4.Controls.Add(textBox1);
            boxRadio4.Controls.Add(button1);
            boxRadio4.Controls.Add(panel4);
            boxRadio4.Controls.Add(dateTimePicker1);
            boxRadio4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxRadio4.Location = new Point(7, 43);
            boxRadio4.Margin = new Padding(3, 2, 3, 2);
            boxRadio4.Name = "boxRadio4";
            boxRadio4.Padding = new Padding(4);
            boxRadio4.Size = new Size(347, 441);
            boxRadio4.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveBorder;
            btnAdd.Image = Properties.Resources.iconAdd25x25;
            btnAdd.Location = new Point(260, 105);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(38, 38);
            btnAdd.TabIndex = 9;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 105);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 38);
            comboBox1.TabIndex = 8;
            // 
            // boxRadio2
            // 
            boxRadio2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxRadio2.AutoSize = true;
            boxRadio2.BackColor = SystemColors.ActiveBorder;
            boxRadio2.BorderRadius = 40;
            boxRadio2.Location = new Point(19, 3811);
            boxRadio2.Margin = new Padding(3, 2, 3, 2);
            boxRadio2.Name = "boxRadio2";
            boxRadio2.Padding = new Padding(4);
            boxRadio2.Size = new Size(5009, 76);
            boxRadio2.TabIndex = 4;
            // 
            // boxRadio3
            // 
            boxRadio3.AccessibleRole = AccessibleRole.TitleBar;
            boxRadio3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxRadio3.AutoScroll = true;
            boxRadio3.AutoSize = true;
            boxRadio3.BackColor = SystemColors.ActiveBorder;
            boxRadio3.BorderRadius = 40;
            boxRadio3.Controls.Add(dataGridView1);
            boxRadio3.Location = new Point(360, 43);
            boxRadio3.Margin = new Padding(3, 2, 3, 2);
            boxRadio3.Name = "boxRadio3";
            boxRadio3.Padding = new Padding(4);
            boxRadio3.Size = new Size(740, 441);
            boxRadio3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Descricao, Valor, Data, Tipo, Categoria, Excluir });
            dataGridView1.Location = new Point(9, 10);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(723, 423);
            dataGridView1.TabIndex = 0;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.Width = 125;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.Width = 125;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.Width = 125;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.MinimumWidth = 6;
            Excluir.Name = "Excluir";
            Excluir.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveBorder;
            button2.Image = Properties.Resources.iconRemove24x24;
            button2.Location = new Point(302, 105);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(38, 38);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            // 
            // Planner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1119, 646);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1036, 685);
            Name = "Planner";
            Padding = new Padding(3, 2, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planner";
            WindowState = FormWindowState.Maximized;
            MaximizedBoundsChanged += Planner_MaximizedBoundsChanged;
            Load += Planner_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            boxRadio5.ResumeLayout(false);
            boxRadio5.PerformLayout();
            boxRadio4.ResumeLayout(false);
            boxRadio4.PerformLayout();
            boxRadio3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel4;
        private Button button1;
        private PageSetupDialog pageSetupDialog1;
        private BoxRadio boxRadio2;
        private BoxRadio boxRadio3;
        private BoxRadio boxRadio4;
        private BoxRadio boxRadio5;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewButtonColumn Excluir;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button2;
    }
}