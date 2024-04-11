namespace FiboLinearApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{fibo(2)}");
        }

        public static int fibo(int n) 
        {
            int a = 0; 
            int b = 1; 
            int c = 1;

            Console.Write("{0} {1}", a, b);

            for (int i = 1;  i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            
            }
            return (n != 0) ? c : 0;   
        
        }
    }
}
