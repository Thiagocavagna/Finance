using Finance.Data;
using Finance.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finance.View.TCategory
{
    public partial class RegisterCategory : Form
    {
        private readonly CategoryController _controller;
        public event EventHandler CategoryAdded;


        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public RegisterCategory()
        {
            InitializeComponent();
            _controller = new CategoryController();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
            CategoryName = txtNameCategory.Text;
            CategoryDescription = txtDescriptionCategory.Text;
            _controller.AddCategory(CategoryName, CategoryDescription);
            CategoryAdded.Invoke(this, EventArgs.Empty);
            txtDescriptionCategory.Text = "";
            txtNameCategory.Text = "";

            this.Close();
            
        }
    }
}
