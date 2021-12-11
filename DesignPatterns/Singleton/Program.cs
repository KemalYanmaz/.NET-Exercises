namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = CustomerManager.GetInstance();
            customerManager.Save("Kemal");
        }
    }

    class CustomerManager
    {
        private static CustomerManager _INSTANCE;
        static object _lockObject = new object();
        private CustomerManager()
        {}

        public static CustomerManager GetInstance()
        {
            lock (_lockObject)
            {
                if (_INSTANCE == null)
                {
                    _INSTANCE = new CustomerManager();
                }
            }
            return _INSTANCE;
        }
        
        public void Save(string customer)
        {
            Console.WriteLine($"Customer {customer} Saved");
        }
    }
}