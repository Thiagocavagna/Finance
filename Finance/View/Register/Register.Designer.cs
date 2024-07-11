namespace MeuProjeto
{
    partial class Register
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
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            button2 = new Button();
            errorProvider = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(107, 9);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(188, 32);
            label7.TabIndex = 7;
            label7.Text = "Primeiro Acesso:";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 197);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 30);
            label5.TabIndex = 6;
            label5.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 19);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.AcceptsTab = true;
            txtName.Location = new Point(34, 55);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(306, 35);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 233);
            txtPassword.Margin = new Padding(5, 6, 5, 6);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(306, 35);
            txtPassword.TabIndex = 3;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 142);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 35);
            txtEmail.TabIndex = 2;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(16, 50);
            panel2.Margin = new Padding(10, 12, 10, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 349);
            panel2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 106);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // button2
            // 
            button2.Location = new Point(34, 290);
            button2.Margin = new Padding(10, 12, 10, 12);
            button2.Name = "button2";
            button2.Size = new Size(306, 47);
            button2.TabIndex = 3;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 420);
            Controls.Add(label7);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Panel panel2;
        private Label label4;
        private Button button2;
        private ErrorProvider errorProvider;
    }
}