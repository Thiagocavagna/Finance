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
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(15, 15);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 310);
            panel1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveCaption;
            btnRegister.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(181, 195);
            btnRegister.Margin = new Padding(6);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(146, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
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
            btnLogin.BackColor = Color.YellowGreen;
            btnLogin.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(18, 195);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Logar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(19F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(375, 340);
            Controls.Add(panel1);
            Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private Button btnRegister;
    }
}
