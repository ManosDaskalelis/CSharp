namespace ReadApp
{
    /// <summary>
    ///  Reads two integers from the std input and
    ///  prints their sum.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 10;
            int num2 = 10;
            int result = 0;

            Console.WriteLine("Please insert two ints");
            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);

            result = num2 + num1;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }
}
