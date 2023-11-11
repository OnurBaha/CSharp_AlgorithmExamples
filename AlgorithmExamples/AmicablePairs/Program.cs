namespace AmicablePairs
{
    internal class Program
    {
        // Write a C# program finds first two amicable pairs. (Output: 1-> 220-284 2: 1184-1210) 

        // Kullanıcıdan alınan 2 sayının kontrolü 

        /*
            static void Main(string[] args)
            {
                Console.WriteLine("Please, enter the first number");
                int number1 = int.Parse(Console.ReadLine());


                Console.WriteLine("Please, enter the second number");
                int number2 = int.Parse(Console.ReadLine());

                getAmicable(number1, number2);

            }


            public static void getAmicable(int number, int number2)
            {
                int numberDivisors = 0, number2Divisors = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        numberDivisors += i;
                    }
                    if (number2 % i == 0)
                    {
                        number2Divisors += i;
                    }
                }

                if (numberDivisors == number2 && number2Divisors == number)
                {
                    Console.WriteLine("{0} and {1} are amicable pairs",number,number2);
                }

            }
        */


        // ilk 2 Arkadaş Sayısının Kontrolü

        static void Main(string[] args)
        {
            int number = 0, number2 = 0;

            List<int> amicableList = new List<int>();

            for (int i = 0; i < 2000; i++)
            {
                number = getAmicable(i);
                number2 = getAmicable(number);

                if (number != i && number2 == i && !amicableList.Contains(number) && !amicableList.Contains(number2))
                {
                    amicableList.Add(number);
                    amicableList.Add(number2);

                    Console.WriteLine(number2 + " - " + number);
                }
            }

        }


        public static int getAmicable(int number)
        {
            int numberDivisors = 0;
            for (int i = 1; i < number; i++)
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
