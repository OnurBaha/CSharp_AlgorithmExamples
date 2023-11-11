namespace PerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program finds first 10 perfect numbers.

            for (int i = 1; i <= 10000; i++)
            {
                int checkPerfectNumber = findPerfectNumber(i);

                if (checkPerfectNumber == (i * 2))
                {
                    Console.WriteLine("{0} is perfect number", i);
                }
            }
        }

        public static int findPerfectNumber(int number)
        {
            int numberDivisors = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    numberDivisors += i;
                }
            }
            return numberDivisors;
        }
    }
}