namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdNewProduct = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnitNewProduct = new System.Windows.Forms.TextBox();
            this.tbxStokNewProduct = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceNewProduct = new System.Windows.Forms.TextBox();
            this.tbxProductNameNewProduct = new System.Windows.Forms.TextBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStockNewProduct = new System.Windows.Forms.Label();
            this.lblUnitPriceNewProduct = new System.Windows.Forms.Label();
            this.lblCategoryIdNewProduct = new System.Windows.Forms.Label();
            this.lblProductNameNewProduct = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxProductIdUpdateProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCategoryIdUpdateProduct = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnitUpdateProduct = new System.Windows.Forms.TextBox();
            this.tbxStockUpdateProduct = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdateProduct = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdateProduct = new System.Windows.Forms.TextBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(13, 153);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(770, 285);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(13, 13);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(770, 68);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(100, 29);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(48, 32);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.lblProductName);
            this.gbxProduct.Location = new System.Drawing.Point(13, 87);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(770, 60);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(100, 24);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(46, 27);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategoryIdNewProduct);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnitNewProduct);
            this.groupBox1.Controls.Add(this.tbxStokNewProduct);
            this.groupBox1.Controls.Add(this.tbxUnitPriceNewProduct);
            this.groupBox1.Controls.Add(this.tbxProductNameNewProduct);
            this.groupBox1.Controls.Add(this.btnAddNewProduct);
            this.groupBox1.Controls.Add(this.lblQuantityPerUnit);
            this.groupBox1.Controls.Add(this.lblStockNewProduct);
            this.groupBox1.Controls.Add(this.lblUnitPriceNewProduct);
            this.groupBox1.Controls.Add(this.lblCategoryIdNewProduct);
            this.groupBox1.Controls.Add(this.lblProductNameNewProduct);
            this.groupBox1.Location = new System.Drawing.Point(13, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryIdNewProduct
            // 
            this.cbxCategoryIdNewProduct.FormattingEnabled = true;
            this.cbxCategoryIdNewProduct.Location = new System.Drawing.Point(73, 49);
            this.cbxCategoryIdNewProduct.Name = "cbxCategoryIdNewProduct";
            this.cbxCategoryIdNewProduct.Size = new System.Drawing.Size(204, 21);
            this.cbxCategoryIdNewProduct.TabIndex = 11;
            // 
            // tbxQuantityPerUnitNewProduct
            // 
            this.tbxQuantityPerUnitNewProduct.Location = new System.Drawing.Point(73, 132);
            this.tbxQuantityPerUnitNewProduct.Name = "tbxQuantityPerUnitNewProduct";
            this.tbxQuantityPerUnitNewProduct.Size = new System.Drawing.Size(204, 20);
            this.tbxQuantityPerUnitNewProduct.TabIndex = 10;
            // 
            // tbxStokNewProduct
            // 
            this.tbxStokNewProduct.Location = new System.Drawing.Point(73, 105);
            this.tbxStokNewProduct.Name = "tbxStokNewProduct";
            this.tbxStokNewProduct.Size = new System.Drawing.Size(204, 20);
            this.tbxStokNewProduct.TabIndex = 9;
            // 
            // tbxUnitPriceNewProduct
            // 
            this.tbxUnitPriceNewProduct.Location = new System.Drawing.Point(73, 78);
            this.tbxUnitPriceNewProduct.Name = "tbxUnitPriceNewProduct";
            this.tbxUnitPriceNewProduct.Size = new System.Drawing.Size(204, 20);
            this.tbxUnitPriceNewProduct.TabIndex = 8;
            // 
            // tbxProductNameNewProduct
            // 
            this.tbxProductNameNewProduct.Location = new System.Drawing.Point(74, 19);
            this.tbxProductNameNewProduct.Name = "tbxProductNameNewProduct";
            this.tbxProductNameNewProduct.Size = new System.Drawing.Size(203, 20);
            this.tbxProductNameNewProduct.TabIndex = 6;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(73, 158);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(204, 23);
            this.btnAddNewProduct.TabIndex = 5;
            this.btnAddNewProduct.Text = "Ürün Ekle";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(12, 135);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblStockNewProduct
            // 
            this.lblStockNewProduct.AutoSize = true;
            this.lblStockNewProduct.Location = new System.Drawing.Point(12, 108);
            this.lblStockNewProduct.Name = "lblStockNewProduct";
            this.lblStockNewProduct.Size = new System.Drawing.Size(56, 13);
            this.lblStockNewProduct.TabIndex = 3;
            this.lblStockNewProduct.Text = "Stok Adeti";
            // 
            // lblUnitPriceNewProduct
            // 
            this.lblUnitPriceNewProduct.AutoSize = true;
            this.lblUnitPriceNewProduct.Location = new System.Drawing.Point(38, 81);
            this.lblUnitPriceNewProduct.Name = "lblUnitPriceNewProduct";
            this.lblUnitPriceNewProduct.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceNewProduct.TabIndex = 2;
            this.lblUnitPriceNewProduct.Text = "Fiyat";
            // 
            // lblCategoryIdNewProduct
            // 
            this.lblCategoryIdNewProduct.AutoSize = true;
            this.lblCategoryIdNewProduct.Location = new System.Drawing.Point(22, 52);
            this.lblCategoryIdNewProduct.Name = "lblCategoryIdNewProduct";
            this.lblCategoryIdNewProduct.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryIdNewProduct.TabIndex = 1;
            this.lblCategoryIdNewProduct.Text = "Kategori";
            // 
            // lblProductNameNewProduct
            // 
            this.lblProductNameNewProduct.AutoSize = true;
            this.lblProductNameNewProduct.Location = new System.Drawing.Point(20, 22);
            this.lblProductNameNewProduct.Name = "lblProductNameNewProduct";
            this.lblProductNameNewProduct.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameNewProduct.TabIndex = 0;
            this.lblProductNameNewProduct.Text = "Ürün Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxProductIdUpdateProduct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxCategoryIdUpdateProduct);
            this.groupBox2.Controls.Add(this.tbxQuantityPerUnitUpdateProduct);
            this.groupBox2.Controls.Add(this.tbxStockUpdateProduct);
            this.groupBox2.Controls.Add(this.tbxUnitPriceUpdateProduct);
            this.groupBox2.Controls.Add(this.tbxProductNameUpdateProduct);
            this.groupBox2.Controls.Add(this.btnUpdateProduct);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(338, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // tbxProductIdUpdateProduct
            // 
            this.tbxProductIdUpdateProduct.Location = new System.Drawing.Point(75, 19);
            this.tbxProductIdUpdateProduct.Name = "tbxProductIdUpdateProduct";
            this.tbxProductIdUpdateProduct.ReadOnly = true;
            this.tbxProductIdUpdateProduct.Size = new System.Drawing.Size(205, 20);
            this.tbxProductIdUpdateProduct.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ürün ID";
            // 
            // cbxCategoryIdUpdateProduct
            // 
            this.cbxCategoryIdUpdateProduct.FormattingEnabled = true;
            this.cbxCategoryIdUpdateProduct.Location = new System.Drawing.Point(75, 78);
            this.cbxCategoryIdUpdateProduct.Name = "cbxCategoryIdUpdateProduct";
            this.cbxCategoryIdUpdateProduct.Size = new System.Drawing.Size(206, 21);
            this.cbxCategoryIdUpdateProduct.TabIndex = 22;
            // 
            // tbxQuantityPerUnitUpdateProduct
            // 
            this.tbxQuantityPerUnitUpdateProduct.Location = new System.Drawing.Point(75, 161);
            this.tbxQuantityPerUnitUpdateProduct.Name = "tbxQuantityPerUnitUpdateProduct";
            this.tbxQuantityPerUnitUpdateProduct.Size = new System.Drawing.Size(206, 20);
            this.tbxQuantityPerUnitUpdateProduct.TabIndex = 21;
            // 
            // tbxStockUpdateProduct
            // 
            this.tbxStockUpdateProduct.Location = new System.Drawing.Point(75, 134);
            this.tbxStockUpdateProduct.Name = "tbxStockUpdateProduct";
            this.tbxStockUpdateProduct.Size = new System.Drawing.Size(206, 20);
            this.tbxStockUpdateProduct.TabIndex = 20;
            // 
            // tbxUnitPriceUpdateProduct
            // 
            this.tbxUnitPriceUpdateProduct.Location = new System.Drawing.Point(75, 107);
            this.tbxUnitPriceUpdateProduct.Name = "tbxUnitPriceUpdateProduct";
            this.tbxUnitPriceUpdateProduct.Size = new System.Drawing.Size(206, 20);
            this.tbxUnitPriceUpdateProduct.TabIndex = 19;
            // 
            // tbxProductNameUpdateProduct
            // 
            this.tbxProductNameUpdateProduct.Location = new System.Drawing.Point(76, 48);
            this.tbxProductNameUpdateProduct.Name = "tbxProductNameUpdateProduct";
            this.tbxProductNameUpdateProduct.Size = new System.Drawing.Size(205, 20);
            this.tbxProductNameUpdateProduct.TabIndex = 18;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(75, 187);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(206, 23);
            this.btnUpdateProduct.TabIndex = 17;
            this.btnUpdateProduct.Text = "Ürün Güncelle";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Birim Adedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Stok Adeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün Adı";
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(685, 470);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteProduct.TabIndex = 5;
            this.btn_DeleteProduct.Text = "Ürünü Sil";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 712);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitNewProduct;
        private System.Windows.Forms.TextBox tbxStokNewProduct;
        private System.Windows.Forms.TextBox tbxUnitPriceNewProduct;
        private System.Windows.Forms.TextBox tbxProductNameNewProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStockNewProduct;
        private System.Windows.Forms.Label lblUnitPriceNewProduct;
        private System.Windows.Forms.Label lblCategoryIdNewProduct;
        private System.Windows.Forms.Label lblProductNameNewProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCategoryIdNewProduct;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdateProduct;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdateProduct;
        private System.Windows.Forms.TextBox tbxStockUpdateProduct;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdateProduct;
        private System.Windows.Forms.TextBox tbxProductNameUpdateProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxProductIdUpdateProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DeleteProduct;
    }
}

