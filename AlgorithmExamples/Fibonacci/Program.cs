namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# function to print first 100 numbers in Fibonacci series? 

            for (int i = 1; i <= 100; i++)
            {
                int result = Fibonacci(i);
                Console.WriteLine(result);
            }
        }
        static public int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }

    }
}