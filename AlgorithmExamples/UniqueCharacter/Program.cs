namespace UniqueCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to determine if the string has all unique characters. 
            Console.WriteLine("Please, enter the word.");
            string word = Console.ReadLine();
            bool uniqueWord = true;

            foreach (var item in word)

            {
                int count = word.Count(x => x == item);

                if (count != 1)
                {
                    uniqueWord = false;
                }
            }
            if (uniqueWord)
            {
                Console.WriteLine("{0} is unique name");
            }
            else
            {
                Console.WriteLine("{0} is not unique name");
            }
        }
    }
}
