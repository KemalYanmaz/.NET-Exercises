namespace ConsoleApp1
{
    public class Program
    {
        public delegate int MyDelegate();
        public delegate void MyDelegate2(string text);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate selamVer = customerManager.SendMessage;
            selamVer += customerManager.ShowAlert;
            Console.WriteLine(selamVer());
            MyDelegate2 selamVer2 = customerManager.SendMessage;
            selamVer2("Kemal");
        }
    }

    public class CustomerManager
    {
        public void SendMessage(string isim)
        {
            Console.WriteLine($"Hoşgeldin {isim}!");
        }
        public int SendMessage()
        {
            Console.WriteLine("Hello");
            return 1;
        }

        public int ShowAlert()
        {
            Console.WriteLine("Be careful!");
            return 2;
        }
    }
}