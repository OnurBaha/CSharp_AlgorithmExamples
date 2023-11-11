namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to check if the entered number is Armstrong number? 

            Console.WriteLine("Please, enter the number");
            int number = int.Parse(Console.ReadLine());
            Armstrong(number);
        }

        static void Armstrong(int getNumber)
        {
            string strNumber = getNumber.ToString();
            double total = 0;

            for (int i = 0; i < strNumber.Length; i++)
            {
                int number = int.Parse(strNumber[i].ToString());
                double calculate = Math.Pow(number, strNumber.Length);

                total += calculate;
            }

            if (total == getNumber)
            {
                Console.WriteLine("{0} is a Armstrong Number", getNumber);
            }
            else
            {
                Console.WriteLine("{0} is a not Armstrong Number", getNumber);
            }
        }
    }
}
