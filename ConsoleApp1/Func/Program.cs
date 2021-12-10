namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            add += Cikar;
            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate
            {
                return new Random().Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
        }
 
        static int Topla(int x,int y)
        {
            return x + y;
        }
        
        static int Cikar(int x,int y)
        {
            return x - y;
        }
    }
}