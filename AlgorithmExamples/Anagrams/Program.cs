namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // How to check if two Strings are anagrams of each other? 

            Console.WriteLine("Please, enter the first word");
            string word = Console.ReadLine().ToUpper();

            Console.WriteLine("Please, enter the second word");
            string word2 = Console.ReadLine().ToUpper();

            char[] wordList = word.ToCharArray();
            char[] wordList2 = word2.ToCharArray();

            bool isAnagram = true;
            Array.Sort(wordList);
            Array.Sort(wordList2);

            for (int i = 0; i < wordList.Length; i++)
            {
                if (wordList[i] != wordList2[i])
                {
                    isAnagram = false;
                    break;
                }
            }

            if (isAnagram)
            {
                Console.WriteLine("{0} and {1} is a Anagram Word.", word, word2);
            }
            else
            {
                Console.WriteLine("{0} and {1} is a not Anagram Word.", word, word2);
            }

            Console.ReadLine();
        }
    }
}