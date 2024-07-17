namespace Finance.View.Password
{
    partial class UpdatePassword
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
            lblSenhaAnterior = new Label();
            txtSenhaAtual = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNovaSenha = new TextBox();
            txtConfirmSenha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            errorPassword = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorPassword).BeginInit();
            SuspendLayout();
            // 
            // lblSenhaAnterior
            // 
            lblSenhaAnterior.AutoSize = true;
            lblSenhaAnterior.Location = new Point(39, 39);
            lblSenhaAnterior.Name = "lblSenhaAnterior";
            lblSenhaAnterior.Size = new Size(167, 31);
            lblSenhaAnterior.TabIndex = 0;
            lblSenhaAnterior.Text = "Senha anterior:";
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenhaAtual.Location = new Point(36, 73);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PasswordChar = '*';
            txtSenhaAtual.Size = new Size(419, 38);
            txtSenhaAtual.TabIndex = 1;
            txtSenhaAtual.UseSystemPasswordChar = true;
            txtSenhaAtual.Validating += txtSenhaAtual_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 121);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 2;
            label1.Text = "Nova senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 209);
            label2.Name = "label2";
            label2.Size = new Size(188, 31);
            label2.TabIndex = 3;
            label2.Text = "Confirmar Senha:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNovaSenha.Location = new Point(36, 155);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.Size = new Size(419, 38);
            txtNovaSenha.TabIndex = 4;
            txtNovaSenha.UseSystemPasswordChar = true;
            txtNovaSenha.Validating += txtNovaSenha_Validating;
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmSenha.Location = new Point(36, 243);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.PasswordChar = '*';
            txtConfirmSenha.Size = new Size(419, 38);
            txtConfirmSenha.TabIndex = 5;
            txtConfirmSenha.UseSystemPasswordChar = true;
            txtConfirmSenha.Validating += txtConfirmSenha_Validating;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Location = new Point(38, 303);
            button1.Name = "button1";
            button1.Size = new Size(168, 46);
            button1.TabIndex = 6;
            button1.Text = "Alterar Senha";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(236, 303);
            button2.Name = "button2";
            button2.Size = new Size(168, 46);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // errorPassword
            // 
            errorPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorPassword.ContainerControl = this;
            errorPassword.RightToLeft = true;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(472, 361);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtConfirmSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenhaAtual);
            Controls.Add(lblSenhaAnterior);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "UpdatePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Senha";
            ((System.ComponentModel.ISupportInitialize)errorPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenhaAnterior;
        private TextBox txtSenhaAtual;
        private Label label1;
        private Label label2;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmSenha;
        private Button button1;
        private Button button2;
        private ErrorProvider errorPassword;
    }
}