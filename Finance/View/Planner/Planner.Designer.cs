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
            panel1 = new Panel();
            boxRadio1 = new BoxRadio();
            button1 = new Button();
            panel4 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            pageSetupDialog1 = new PageSetupDialog();
            label2 = new Label();
            label3 = new Label();
            boxRadio2 = new BoxRadio();
            boxRadio3 = new BoxRadio();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            boxRadio1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { passwordToolStripMenuItem, relatorioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1090, 31);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(boxRadio1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 520);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // boxRadio1
            // 
            boxRadio1.BackColor = SystemColors.ControlDark;
            boxRadio1.BorderRadius = 20;
            boxRadio1.Controls.Add(label3);
            boxRadio1.Controls.Add(label2);
            boxRadio1.Location = new Point(32, 407);
            boxRadio1.Name = "boxRadio1";
            boxRadio1.Size = new Size(250, 87);
            boxRadio1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(94, 277);
            button1.Name = "button1";
            button1.Size = new Size(112, 41);
            button1.TabIndex = 7;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(radioButton2);
            panel4.Controls.Add(radioButton1);
            panel4.Location = new Point(32, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 42);
            panel4.TabIndex = 6;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(143, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 32);
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
            radioButton1.Location = new Point(28, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 32);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Entrada";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveBorder;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ActiveBorder;
            dateTimePicker1.Location = new Point(32, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 34);
            dateTimePicker1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 112);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Categoria";
            textBox2.Size = new Size(259, 34);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 1;
            label1.Text = "Preencha os campos abaixo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Valor";
            textBox1.Size = new Size(259, 34);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(boxRadio3);
            panel2.Location = new Point(325, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 520);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(64, 10);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 0;
            label2.Text = "Hora Atual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkCn BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(68, 38);
            label3.Name = "label3";
            label3.Size = new Size(100, 41);
            label3.TabIndex = 1;
            label3.Text = "22:35";
            // 
            // boxRadio2
            // 
            boxRadio2.BackColor = SystemColors.ActiveBorder;
            boxRadio2.BorderRadius = 40;
            boxRadio2.Location = new Point(331, 441);
            boxRadio2.Name = "boxRadio2";
            boxRadio2.Size = new Size(747, 101);
            boxRadio2.TabIndex = 4;
            // 
            // boxRadio3
            // 
            boxRadio3.BackColor = SystemColors.ActiveBorder;
            boxRadio3.BorderRadius = 40;
            boxRadio3.Location = new Point(6, 56);
            boxRadio3.Name = "boxRadio3";
            boxRadio3.Size = new Size(747, 345);
            boxRadio3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Geometr415 Blk BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(319, 12);
            label4.Name = "label4";
            label4.Size = new Size(125, 34);
            label4.TabIndex = 1;
            label4.Text = "Finanças";
            // 
            // Planner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1090, 554);
            Controls.Add(boxRadio2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Planner";
            Text = "Planner";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            boxRadio1.ResumeLayout(false);
            boxRadio1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
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
    }
}