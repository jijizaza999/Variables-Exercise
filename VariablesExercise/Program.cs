namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string name = "John";
            int age = 31;
            char middleInitial = 'D';
            bool isOver18 = true;
            double currentTemp = 77.9;
            decimal currentPrice = 29.99m;

            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Midle initial:{middleInitial}");
            Console.WriteLine($"Is Over 18 : {isOver18}");
            Console.WriteLine($"Current tempture:{currentTemp}");
            Console.WriteLine($"Current Price:{currentPrice}");
        }
    }
}
