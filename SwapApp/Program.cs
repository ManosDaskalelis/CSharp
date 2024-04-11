namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 7;
            //{
            //    int a = 10; int b = 20;

            //    Console.WriteLine($"{a}, {b}");
            //    Swap(a, b);
            //SwapRef(ref x, ref y);
            Swap(x, y);
            Console.WriteLine($"{x} + {y}");
            SwapRef(ref x, ref y);
            Console.WriteLine($"{x} + {y}");
            ChangeInt(out x);
            Console.WriteLine($"{x}");
            //    Console.WriteLine($"{a}, {b}");
            string? s = "Hello";
            ChangeStr(out s);
            Console.WriteLine(s);
        }

        /// <summary>
        /// Swap gets args by value
        /// </summary>
        /// <param name="a">The first input.</param>
        /// <param name="b">The second input</param>
        public static void Swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        /// <summary>
        /// Swap gets args by ref
        /// </summary>
        /// <param name="a">The first input.</param>
        /// <param name="b">The second input</param>
        public static void SwapRef(ref int x, ref int y)
        {
            //int tmp = x;
            //x = y;
            //y = tmp;
            (x, y) = (y, x);
        }

        public static void ChangeStr(out string s)
        {
            s = "AUEB";
        }
        public static void ChangeInt(out int x)
        {
            x = 20;
        }
    }

}
