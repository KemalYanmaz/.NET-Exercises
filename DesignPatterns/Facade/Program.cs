namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface ILogging
    {
        public void Log();
    }
    interface ICaching
    {
        public void Cache();
    }

    interface IAuthorize
    {
        public void CheckUser();
    }
    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked");
        }
    }

    class CustomerManage
    {
        private ILogging _logging;
        private ICaching _caching;
        private IAuthorize _authorize;

        public CustomerManage(ILogging logging, ICaching caching, IAuthorize authorize)
        {
            _logging = logging;
            _caching = caching;
            _authorize = authorize;
        }

        public void Save()
        {
            _logging.Log();
            _caching.Cache();
            _authorize.CheckUser();
        }
    }

    class CrossCuttingConcernsFacade
    {
        public ILogging
    }
}