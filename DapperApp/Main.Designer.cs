
namespace DapperApp
{
    partial class Main
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
            this.dgv_cats = new System.Windows.Forms.DataGridView();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.btn_save_cat = new System.Windows.Forms.Button();
            this.btn_prods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cats
            // 
            this.dgv_cats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cats.Location = new System.Drawing.Point(45, 125);
            this.dgv_cats.Name = "dgv_cats";
            this.dgv_cats.RowHeadersWidth = 51;
            this.dgv_cats.RowTemplate.Height = 29;
            this.dgv_cats.Size = new System.Drawing.Size(520, 259);
            this.dgv_cats.TabIndex = 0;
            // 
            // txt_cat
            // 
            this.txt_cat.Location = new System.Drawing.Point(649, 125);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.PlaceholderText = "Category Name";
            this.txt_cat.Size = new System.Drawing.Size(125, 27);
            this.txt_cat.TabIndex = 1;
            // 
            // btn_save_cat
            // 
            this.btn_save_cat.Location = new System.Drawing.Point(679, 173);
            this.btn_save_cat.Name = "btn_save_cat";
            this.btn_save_cat.Size = new System.Drawing.Size(94, 29);
            this.btn_save_cat.TabIndex = 2;
            this.btn_save_cat.Text = "Save";
            this.btn_save_cat.UseVisualStyleBackColor = true;
            this.btn_save_cat.Click += new System.EventHandler(this.btn_save_cat_Click);
            // 
            // btn_prods
            // 
            this.btn_prods.Location = new System.Drawing.Point(680, 355);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(94, 29);
            this.btn_prods.TabIndex = 2;
            this.btn_prods.Text = "Products";
            this.btn_prods.UseVisualStyleBackColor = true;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_prods);
            this.Controls.Add(this.btn_save_cat);
            this.Controls.Add(this.txt_cat);
            this.Controls.Add(this.dgv_cats);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cats;
        private System.Windows.Forms.TextBox txt_cat;
        private System.Windows.Forms.Button btn_save_cat;
        private System.Windows.Forms.Button btn_prods;
    }
}

