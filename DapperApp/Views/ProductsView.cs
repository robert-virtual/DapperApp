using DapperApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DapperApp.Views
{
    public partial class ProductsView : Form
    {
        Category Cat = new Category();
        Product Prod = new Product();
        List<Product> Products = new List<Product>();
        public ProductsView()
        {
            InitializeComponent();
            LoadCats();
            LoadProds();
        }
        void LoadProds()
        {
            Products = Prod.IncludeCats();
            LoadDGV(Products);
        }

        void LoadDGV(List<Product> prods)
        {
            dgv_prods.DataSource = null;
            dgv_prods.DataSource = prods;
        }
        void LoadCats()
        {
            cb_cats.DataSource = Cat.GetAll();
            cb_cats.DisplayMember = "Name";
            cb_cats.ValueMember = "CategoryId";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            var prod = new Product()
            {
                Name = txt_prod_name.Text.Trim(),
                Price = n_price.Value,
                CategoryFk = cb_cats.SelectedValue.GetHashCode()
            };
            prod.Save(prod);
            LoadProds();
        }
    }
}
