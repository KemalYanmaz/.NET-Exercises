namespace Attiributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1};
            new CustomerDal().Add(customer);
        }
    }

    class Customer
    {
        public int Id { get; set; }
       // [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id},{customer.FirstName},{customer.LastName},{customer.Age} added");
        }
    }
}