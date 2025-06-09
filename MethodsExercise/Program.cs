namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine(
                $"{name} loves his pet {animal}, which is also called {name}. {name} is a {color} colored {animal} and loves listening to {band} with his owner.");
        }
    }
}