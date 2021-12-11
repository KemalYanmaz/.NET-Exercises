using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
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
        private IEntityService<Product> _entityService;

        public Form1()
        {
            _entityService = new ProductManager(new EfProductDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _entityService.GetAll();
        }
    }
}
