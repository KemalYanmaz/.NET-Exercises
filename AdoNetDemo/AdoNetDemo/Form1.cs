using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Add(new Product
                {
                    Name = tbxName.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text)
                });
                MessageBox.Show("Product Added");
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Fill All Inputs Correctly");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An Error Occoured: {exception.GetType()}");
            }
            finally
            {
                LoadProducts();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productDal.Update(new Product
                {
                    Id = Convert.ToInt32(tbxIdUpdate.Text),
                    Name = tbxNameUpdate.Text.ToString(),
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
                });
                MessageBox.Show("Product Updated");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Fill All Inputs Correctly");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An Error Occoured: {exception.GetType()}");
            }
            finally
            {
                LoadProducts();
            }

        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxIdUpdate.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value));
            MessageBox.Show("The entry has removed.");
            LoadProducts();
        }
    }
}
