
namespace PrimesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20;  i++)
            {
                Console.WriteLine($"{0} is{1}Prime", i, ΙsPrime(i) ? " " : " not ");
            }
        }
        public static bool ΙsPrime(int n)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);

            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0) prime = false;
                {
                    divider++;
                }
            }
            return prime;
        }
    }
}
