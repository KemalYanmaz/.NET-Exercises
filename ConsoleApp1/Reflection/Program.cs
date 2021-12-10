namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type,8,7);
            foreach (var item in instance.GetType().GetMethods())
            {
                string x = String.Empty;
                x += item.Name+"(";
                foreach (var item2 in item.GetParameters())
                {
                    x += ", ";
                    x += item2;
                }
                x+=")";
                Console.WriteLine(x);
            }
        }
    }
    
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem()
        {

        }
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp()
        {
            return _sayi1 * _sayi2;
        }

    }
}