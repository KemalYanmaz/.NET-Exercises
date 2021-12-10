namespace ConsoleApp1
{
    public class Program
    {
        public delegate void Operations();

        static void Main(string[] args)
        {
            Operations operations = MathManager.AskForDivision;
            HandleException(()=> {
                operations();
            });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        public class MathManager
        {
            public static void AskForDivision()
            {
                Console.WriteLine("Please enter 1st number for division");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter 2nd number for division");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"The division of {number1} to {number2} is: {MathematicalOperations.Divide(number1, number2)}");
            }
        }

        public class MathematicalOperations
        {
            public static double Divide(double n1,double n2)
            {
                if (n2 == 0)
                {
                    throw new DivideByZeroException("The divisor can not be zero");
                }
                return n1 / n2;
            }
        }
    }
}