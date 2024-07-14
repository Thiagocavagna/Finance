namespace Finance.View.TCategory
{
    partial class RegisterCategory
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
            label1 = new Label();
            txtNameCategory = new TextBox();
            button1 = new Button();
            btnAddCategory = new Button();
            txtDescriptionCategory = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Categoria:";
            // 
            // txtNameCategory
            // 
            txtNameCategory.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameCategory.Location = new Point(55, 44);
            txtNameCategory.Margin = new Padding(3, 4, 3, 4);
            txtNameCategory.Name = "txtNameCategory";
            txtNameCategory.PlaceholderText = "Nome";
            txtNameCategory.Size = new Size(345, 32);
            txtNameCategory.TabIndex = 1;
            txtNameCategory.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 145);
            button1.Name = "button1";
            button1.Size = new Size(169, 41);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.Location = new Point(230, 145);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(170, 41);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "Adicionar";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtDescriptionCategory
            // 
            txtDescriptionCategory.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescriptionCategory.Location = new Point(55, 95);
            txtDescriptionCategory.Margin = new Padding(3, 4, 3, 4);
            txtDescriptionCategory.Name = "txtDescriptionCategory";
            txtDescriptionCategory.PlaceholderText = "Descrição";
            txtDescriptionCategory.Size = new Size(345, 32);
            txtDescriptionCategory.TabIndex = 4;
            // 
            // RegisterCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 198);
            Controls.Add(txtDescriptionCategory);
            Controls.Add(btnAddCategory);
            Controls.Add(button1);
            Controls.Add(txtNameCategory);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterCategory";
            Text = "RegisterCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNameCategory;
        private Button button1;
        private Button btnAddCategory;
        private TextBox txtDescriptionCategory;
    }
}