namespace PalindromeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Please insert a string to check if its palindrome");
            s = Console.ReadLine()!;


            Console.WriteLine($"{s} is palindrome: {IsPalindrome(s)}");

        }

        public static bool IsPalindrome(string s) 
        {
            bool palindrome = true;
            int length = s.Length;

            if (s is null) return false;

            for (int i = 0, j = length - 1; i < j; i++, j-- ) 
            {
                if (s[i] != s[j])
                {
                    palindrome = false;
                    break;
                }
            }
        
            return palindrome;
        }
    }
}
