namespace FibonachiApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 20l; i++)
            {
                Console.WriteLine($"{i}: {Fibo(i)}");
            }
        }
        public static int Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <= n; i++)
            {

                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }

    }
}