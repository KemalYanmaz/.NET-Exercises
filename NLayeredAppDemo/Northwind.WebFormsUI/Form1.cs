using Northwind.Business.Concrete;
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
        private ProductManager _productManager;
        public Form1()
        {
            _productManager = new ProductManager();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productManager.GetAll();
        }
    }
}
