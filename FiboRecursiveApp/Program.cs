namespace FiboRecursiveApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Fibo(20)}");
        }
        public static int Fibo(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }

        public static int fibonachi(int n) 
        {
            if (n <= 0) return 0;
            return (n < 2) ? fibonachi(n - 1) + fibonachi(n - 2) : 1;
        }
    }
}
