namespace Assignment_5_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is a palindrome: ");
            string wordToCheck = Console.ReadLine();

            bool isPalindrome = IsPalindrome(wordToCheck, 0, wordToCheck.Length - 1);

            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        // Recursive method to check if a string is a palindrome
        static bool IsPalindrome(string s, int start, int end)
        {
            if (start >= end)
            {
                return true;
            }
                       
            if (s[start] != s[end])
            {
                return false; 
            }
                       
            return IsPalindrome(s, start + 1, end - 1);
        }
    }
}
 
