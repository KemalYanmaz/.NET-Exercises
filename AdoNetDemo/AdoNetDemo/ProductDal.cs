using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        static SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            checkConnection();
            SqlCommand command = new SqlCommand("SElect * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                });
            }

            reader.Close();
            closeConnection();
            return products;
        }
        public void Add(Product product)
        {
            RunQuery(() => {
                AddProduct(product);
            });
        }
        public void Update(Product product)
        {
            RunQuery(() =>{
                UpdateProduct(product);
            });
        }
        public void Delete(int id)
        {
            RunQuery(() => {
                DeleteFrom(id);
            });
        }
        private void RunQuery(Action action)
        {
            checkConnection();
            action.Invoke();
            closeConnection();
        }
        private void UpdateProduct(Product product)
        {
            SqlCommand command = new SqlCommand("Update Products Set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount WHERE Id=@id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
        }
        private void AddProduct(Product product)
        {
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();
        }
        private void DeleteFrom(int id)
        {
            SqlCommand command = new SqlCommand("Delete From Products Where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
        private void checkConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        private void closeConnection()
        {
            _connection.Close();
        }
    }
}
