namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("please insert a num");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine(num);

                    if (num == 0) break;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("error in input format" + ex.Message);
                    throw;
                }
            }


        }
    }
}
