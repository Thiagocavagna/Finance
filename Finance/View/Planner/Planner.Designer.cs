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
            boxRadio1 = new BoxRadio();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            boxRadio5 = new BoxRadio();
            boxRadio4 = new BoxRadio();
            comboBox1 = new ComboBox();
            boxRadio2 = new BoxRadio();
            label4 = new Label();
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
            boxRadio1.SuspendLayout();
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
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 31);
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
            // boxRadio1
            // 
            boxRadio1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            boxRadio1.AutoSize = true;
            boxRadio1.BackColor = SystemColors.ControlDark;
            boxRadio1.BorderRadius = 20;
            boxRadio1.Controls.Add(label3);
            boxRadio1.Controls.Add(label2);
            boxRadio1.Location = new Point(45, 24);
            boxRadio1.Name = "boxRadio1";
            boxRadio1.Size = new Size(285, 150);
            boxRadio1.TabIndex = 8;
            boxRadio1.Paint += boxRadio1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkCn BT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(23, 54);
            label3.Name = "label3";
            label3.Size = new Size(235, 96);
            label3.TabIndex = 1;
            label3.Text = "22:35";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(5, 11);
            label2.Name = "label2";
            label2.Size = new Size(277, 48);
            label2.TabIndex = 0;
            label2.Text = "Hora Atual:";
            // 
            // button1
            // 
            button1.Location = new Point(17, 408);
            button1.Name = "button1";
            button1.Size = new Size(347, 47);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(radioButton2);
            panel4.Controls.Add(radioButton1);
            panel4.Location = new Point(17, 320);
            panel4.Name = "panel4";
            panel4.Size = new Size(347, 45);
            panel4.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(197, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 42);
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
            radioButton1.Location = new Point(43, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 42);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Entrada";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveBorder;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ActiveBorder;
            dateTimePicker1.Location = new Point(17, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(348, 43);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 18);
            label1.Name = "label1";
            label1.Size = new Size(314, 31);
            label1.TabIndex = 1;
            label1.Text = "Preencha os campos abaixo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 52);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Valor";
            textBox1.Size = new Size(347, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(boxRadio5);
            panel2.Controls.Add(boxRadio4);
            panel2.Controls.Add(boxRadio2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(boxRadio3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-7, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(2341, 14316);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // boxRadio5
            // 
            boxRadio5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxRadio5.AutoSize = true;
            boxRadio5.BackColor = SystemColors.ActiveBorder;
            boxRadio5.BorderRadius = 40;
            boxRadio5.Controls.Add(boxRadio1);
            boxRadio5.Location = new Point(22, 603);
            boxRadio5.MaximumSize = new Size(1890, 204);
            boxRadio5.MinimumSize = new Size(1140, 204);
            boxRadio5.Name = "boxRadio5";
            boxRadio5.Size = new Size(1143, 204);
            boxRadio5.TabIndex = 5;
            // 
            // boxRadio4
            // 
            boxRadio4.AccessibleRole = AccessibleRole.TitleBar;
            boxRadio4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            boxRadio4.AutoSize = true;
            boxRadio4.BackColor = SystemColors.ActiveBorder;
            boxRadio4.BorderRadius = 40;
            boxRadio4.Controls.Add(button2);
            boxRadio4.Controls.Add(comboBox1);
            boxRadio4.Controls.Add(textBox1);
            boxRadio4.Controls.Add(button1);
            boxRadio4.Controls.Add(panel4);
            boxRadio4.Controls.Add(dateTimePicker1);
            boxRadio4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxRadio4.Location = new Point(22, 61);
            boxRadio4.MaximumSize = new Size(384, 900);
            boxRadio4.MinimumSize = new Size(384, 536);
            boxRadio4.Name = "boxRadio4";
            boxRadio4.Padding = new Padding(5);
            boxRadio4.Size = new Size(384, 536);
            boxRadio4.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 45);
            comboBox1.TabIndex = 8;
            // 
            // boxRadio2
            // 
            boxRadio2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boxRadio2.AutoSize = true;
            boxRadio2.BackColor = SystemColors.ActiveBorder;
            boxRadio2.BorderRadius = 40;
            boxRadio2.Location = new Point(22, 1050);
            boxRadio2.Name = "boxRadio2";
            boxRadio2.Padding = new Padding(5);
            boxRadio2.Size = new Size(1138, 102);
            boxRadio2.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoEllipsis = true;
            label4.Font = new Font("Geometr415 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(735, 15);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(129, 40);
            label4.TabIndex = 1;
            label4.Text = "Finanças";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
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
            boxRadio3.Location = new Point(412, 61);
            boxRadio3.MaximumSize = new Size(1500, 900);
            boxRadio3.MinimumSize = new Size(750, 536);
            boxRadio3.Name = "boxRadio3";
            boxRadio3.Padding = new Padding(5);
            boxRadio3.Size = new Size(758, 536);
            boxRadio3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Descricao, Valor, Data, Tipo, Categoria, Excluir });
            dataGridView1.Location = new Point(8, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 518);
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
            button2.Location = new Point(309, 140);
            button2.Name = "button2";
            button2.Size = new Size(55, 45);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Planner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1164, 853);
            Controls.Add(menuStrip1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimumSize = new Size(1182, 900);
            Name = "Planner";
            Padding = new Padding(3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planner";
            WindowState = FormWindowState.Maximized;
            MaximizedBoundsChanged += Planner_MaximizedBoundsChanged;
            Load += Planner_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            boxRadio1.ResumeLayout(false);
            boxRadio1.PerformLayout();
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
        private BoxRadio boxRadio1;
        private Label label3;
        private Label label2;
        private BoxRadio boxRadio2;
        private Label label4;
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
        private Button button2;
    }
}