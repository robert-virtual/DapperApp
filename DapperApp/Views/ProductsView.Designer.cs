
namespace DapperApp.Views
{
    partial class ProductsView
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
            this.dgv_prods = new System.Windows.Forms.DataGridView();
            this.txt_prod_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_cats = new System.Windows.Forms.ComboBox();
            this.n_price = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_prods
            // 
            this.dgv_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prods.Location = new System.Drawing.Point(50, 62);
            this.dgv_prods.Name = "dgv_prods";
            this.dgv_prods.RowHeadersWidth = 51;
            this.dgv_prods.RowTemplate.Height = 29;
            this.dgv_prods.Size = new System.Drawing.Size(490, 326);
            this.dgv_prods.TabIndex = 0;
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Location = new System.Drawing.Point(587, 62);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.PlaceholderText = "Product Name";
            this.txt_prod_name.Size = new System.Drawing.Size(153, 27);
            this.txt_prod_name.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(615, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 29);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_cats
            // 
            this.cb_cats.FormattingEnabled = true;
            this.cb_cats.Location = new System.Drawing.Point(587, 143);
            this.cb_cats.Name = "cb_cats";
            this.cb_cats.Size = new System.Drawing.Size(151, 28);
            this.cb_cats.TabIndex = 3;
            // 
            // n_price
            // 
            this.n_price.Location = new System.Drawing.Point(587, 218);
            this.n_price.Name = "n_price";
            this.n_price.Size = new System.Drawing.Size(150, 27);
            this.n_price.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_price);
            this.Controls.Add(this.cb_cats);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_prod_name);
            this.Controls.Add(this.dgv_prods);
            this.Name = "ProductsView";
            this.Text = "ProductsView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prods;
        private System.Windows.Forms.TextBox txt_prod_name;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cb_cats;
        private System.Windows.Forms.NumericUpDown n_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}