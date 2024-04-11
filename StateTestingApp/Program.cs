namespace StateTestingApp
{   

    /// <summary>
    /// Προσθετει τους 10 πρωτους ακεραιος απο το 1 εως το 10
    /// με επαναληπτικο τροπο (while) και εμφανιζει το αποτελεσμα.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //decimal num1 = 0m;
            decimal num2 = 0m;
            decimal sum = 0m;

            Console.WriteLine("Please insert two numberss");

            if (!decimal.TryParse(Console.ReadLine(), out decimal num1))
            {
                Console.WriteLine("Error in decimal reading");
            }

            if (!decimal.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Error in decimal reading");
            }

            sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} = {sum}");
        }
    }
}
