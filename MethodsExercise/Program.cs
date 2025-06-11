namespace MethodsExercise
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {

            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }







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


            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Sub(3, 2));
            Console.WriteLine(Mul(3, 2));
            Console.WriteLine(Div(3, 2));



        }
    }
}