using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public Form1()
        {
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            LoadCategoriesOnSearchBox();
            LoadCategoriesOnNewProduct();
            LoadCategoriesOnUpdateProduct();
        }

        private void LoadCategoriesOnNewProduct()
        {
            cbxCategoryIdNewProduct.DataSource = _categoryService.GetAll();
            cbxCategoryIdNewProduct.DisplayMember = "CategoryName";
            cbxCategoryIdNewProduct.ValueMember = "CategoryId";
        }

        private void LoadCategoriesOnSearchBox()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }
        private void LoadCategoriesOnUpdateProduct()
        {
            cbxCategoryIdUpdateProduct.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdateProduct.DisplayMember = "CategoryName";
            cbxCategoryIdUpdateProduct.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {}
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            string key = tbxProductName.Text;
            if (!String.IsNullOrEmpty(key))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(key);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    ProductName = tbxProductNameNewProduct.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdNewProduct.SelectedValue),
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceNewProduct.Text),
                    UnitsInStock = Convert.ToInt16(tbxStokNewProduct.Text),
                    QuantityPerUnit = tbxQuantityPerUnitNewProduct.Text
                });
                MessageBox.Show("Ürün Eklendi!");
                LoadProducts();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product {
                    ProductId = Convert.ToInt32(tbxProductIdUpdateProduct.Text),
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdateProduct.SelectedValue),
                    ProductName = tbxProductNameUpdateProduct.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdateProduct.Text),
                    QuantityPerUnit = tbxQuantityPerUnitUpdateProduct.Text,
                    UnitsInStock = Convert.ToInt16(tbxStockUpdateProduct.Text),
                });
                MessageBox.Show("Ürün Güncellendi!");
                LoadProducts();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductIdUpdateProduct.Text = row.Cells[0].Value.ToString();
            cbxCategoryIdUpdateProduct.SelectedValue = row.Cells[1].Value;
            tbxProductNameUpdateProduct.Text = row.Cells[2].Value.ToString();
            tbxStockUpdateProduct.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdateProduct.Text = row.Cells[4].Value.ToString();
            tbxUnitPriceUpdateProduct.Text = row.Cells[5].Value.ToString();
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value.ToString())
                });
                MessageBox.Show("Ürün Silindi!");
                LoadProducts();
            }
            catch
            {
                MessageBox.Show("Ürün Silerken Hata Oluştu!");
            }
        }
    }
}
