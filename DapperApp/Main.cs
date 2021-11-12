using DapperApp.Models;
using DapperApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperApp
{
    public partial class Main : Form
    {
        Category Cat = new Category();
        List<Category> Cats = new List<Category>();
        public Main()
        {
            InitializeComponent();
            LoadCats();
        }

        void LoadCats()
        {
            Cats = Cat.GetAll();
            LoadDGV(Cats);
        }
        void LoadDGV(List<Category> cats)
        {
            dgv_cats.DataSource = cats;
        }

        private void btn_save_cat_Click(object sender, EventArgs e)
        {
            var cat = new Category() 
            {
                Name = txt_cat.Text.Trim()
            };
            cat.Save(cat);
            LoadCats();
        }

        private void btn_prods_Click(object sender, EventArgs e)
        {
            var prods = new ProductsView();
            prods.Show();
        }
    }
}
