namespace MeuProjeto
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRegister = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            menuStrip1 = new MenuStrip();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            gastosToolStripMenuItem = new ToolStripMenuItem();
            ganhosToolStripMenuItem = new ToolStripMenuItem();
            controleToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(15, 184);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 258);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(181, 195);
            btnRegister.Margin = new Padding(6);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(146, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(104, 20);
            label6.Name = "label6";
            label6.Size = new Size(128, 48);
            label6.TabIndex = 2;
            label6.Text = "Login";
            label6.Click += label6_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(18, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(309, 44);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 80);
            label2.Name = "label2";
            label2.Size = new Size(249, 36);
            label2.TabIndex = 1;
            label2.Text = "Digite a senha:";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(18, 195);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { perfilToolStripMenuItem, gastosToolStripMenuItem, ganhosToolStripMenuItem, controleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 496);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(977, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(56, 24);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // gastosToolStripMenuItem
            // 
            gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            gastosToolStripMenuItem.Size = new Size(67, 24);
            gastosToolStripMenuItem.Text = "Gastos";
            // 
            // ganhosToolStripMenuItem
            // 
            ganhosToolStripMenuItem.Name = "ganhosToolStripMenuItem";
            ganhosToolStripMenuItem.Size = new Size(72, 24);
            ganhosToolStripMenuItem.Text = "Ganhos";
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(80, 24);
            controleToolStripMenuItem.Text = "Controle";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Menu;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 71);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(898, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(977, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private Label label6;
        private Button btnRegister;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem gastosToolStripMenuItem;
        private ToolStripMenuItem ganhosToolStripMenuItem;
        private ToolStripMenuItem controleToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
