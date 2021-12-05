namespace GenericExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> cities= utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            List<int> numbers = utilities.BuildList<int>(1, 2, 3, 4);

        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items){
                return new List<T>(items);
            }
        }
    }
}