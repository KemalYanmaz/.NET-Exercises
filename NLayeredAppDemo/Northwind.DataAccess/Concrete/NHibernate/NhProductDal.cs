using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {

            return new List<Product>
            {
                new Product{ProductId=1,ProductName="Laptop",CategoryId=1,QuantityPerUnit="1 in a box",UnitPrice=3000, UnitsInStock=11},
                new Product{ProductId=2,ProductName="iPhone 8",CategoryId=2,QuantityPerUnit="1 in a box",UnitPrice=1700, UnitsInStock=3 },
                new Product{ProductId=3,ProductName="iPhone 11",CategoryId=2, QuantityPerUnit="1 in a box",UnitPrice=2500, UnitsInStock=9},
            };
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
