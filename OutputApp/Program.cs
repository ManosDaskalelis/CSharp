namespace OutputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num1 = 10;

            Console.WriteLine("Hello world");
            Console.Write("Hello");
            Console.WriteLine("");

            Console.WriteLine("Num: " + num);
            Console.WriteLine("Num: {0,02} {1}", num, num1);


            Console.WriteLine($"Num: {num}, {num1}");


        }
    }
}
