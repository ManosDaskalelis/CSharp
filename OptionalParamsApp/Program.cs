namespace OptionalParamsApp
{
    internal class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine(GetDateTime(2024, 4, 5, 7, 19, 56, 24 ));
            Console.WriteLine(GetDateTime());
        }

        public static DateTime GetDateTime(int year = 2024, int month = 1, int day = 1, int hours = 00, int min = 00, int sec = 00, int mill = 00)
        {
            return new DateTime(year, month, day, hours, min, sec, mill, DateTimeKind.Utc);


        }
    }
}
