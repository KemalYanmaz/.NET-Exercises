namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2());
            customerManager.Save();
        }
    }

    public class CustomerManager
    {
        ILogger _logger;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger();
        }

        public void Save()
        {
            Console.WriteLine("Saved");
            _logger.Log("Logged");
        }
    }
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new ALogger();
        }
    }

    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new BLogger();
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class ALogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message}:Logged by ALogger");
        }
    }

    public class BLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message}:Logged by BLogger");
        }
    }
}