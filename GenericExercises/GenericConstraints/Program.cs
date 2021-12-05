namespace GenericExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }


        interface IRepository<T> where T : class,IEntity, new() //use "struct" for value types
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
        }

        interface IEntity{}

        class Customer:IEntity{ }
        interface ICustomerDal : IRepository<Customer> { }
        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
        class Product:IEntity{}
        interface IProductDal : IRepository<Product> { }
        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }

    }
}