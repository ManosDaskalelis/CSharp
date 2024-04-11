namespace NullConditionalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(GetUpperString());
        }

        public static string? GetUpperString() 
        {
            string? s;

            Console.WriteLine("Please insert a string");
            s = Console.ReadLine();

            return s?.ToUpper();

        }
    }
}
