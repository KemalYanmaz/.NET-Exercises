using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        private ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Product Added!");
            LoadData();
        }

        private void LoadData()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchData(string key)
        {
            dgwProducts.DataSource = _productDal.GetByName(key);
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxIdUpdate.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString()),
                Name = dgwProducts.CurrentRow.Cells[1].Value.ToString(),
                UnitPrice = Convert.ToDecimal(dgwProducts.CurrentRow.Cells[2].Value),
                StockAmount = Convert.ToInt32(dgwProducts.CurrentRow.Cells[3].Value)
            }) ;
            MessageBox.Show("Product Updated!");
            LoadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Product Deleted!");
            LoadData();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(tbxSearch.Text);
        }
    }
}
