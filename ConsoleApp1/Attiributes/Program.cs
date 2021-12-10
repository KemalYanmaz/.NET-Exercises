namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName ="Yanmaz",
                Age = 24
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"[1]{customer.Id}:\t{customer.FirstName}\t{customer.LastName}\t,{customer.Age}");
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine($"[2]{customer.Id}:\t{customer.FirstName}\t{customer.LastName}\t,{customer.Age}");
        }

    }

    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple = false)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
