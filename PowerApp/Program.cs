using System.Numerics;

namespace PowerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myBase = 2;
            int myPower = 8;
            BigInteger result = 1;

            for (int i = 0; i <= myPower; i++)
            {
                result *= myBase;
            }
            Console.WriteLine($"{myBase} ^ {myPower} = {result}");


        }
    }
}
