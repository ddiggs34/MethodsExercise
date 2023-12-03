namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // -----EXERCISE 1  ---------
            Console.WriteLine("What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is  solid choice. What is your favorite food?");
            var food = Console.ReadLine();

            Console.WriteLine($"{food} is delicious");


            //----------------------------EXERCISE 2

            Console.WriteLine($"Add: {Add(2, 3)}");
            Console.WriteLine($"Subtract: {Subtract(10, 6)}");
            Console.WriteLine($"Multiply:{Multiply(3, 9)}");
            Console.WriteLine($"Divide: {Divide(100, 5)}");


        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }



    }
}
