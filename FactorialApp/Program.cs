using System.Numerics;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i}: {FactoLinear(i)}\t");
                Console.Write($"{i}: {FactoRecursive(i)}\t");
            }
        }
        
        public static BigInteger FactoLinear(int n)
        {
            BigInteger result = 1;

            for (int i = 0; i <= n; i++) 
            {
                result *= i;
            }
            return  result;
        }
    
        public static BigInteger FactoRecursive(int n) 
        {
            return (n > 1) ? n * FactoRecursive(n - 1) : FactoRecursive(n);
        }
    
    
    
    
    
    }


}
