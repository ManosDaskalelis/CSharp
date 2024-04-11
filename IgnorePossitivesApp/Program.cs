namespace IgnorePossitivesApp
{
    /// <summary>
    /// Λαμβανει διαδοχικα ακεραιους απο τον χρηστη
    /// μεσα σε μια while μεχρι ο χρηστης να δωσει 0 και μετραει
    /// μονο τους αρνητικους ενω αγνωοει τους θετικους
    /// 
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int negativeCount = 0;
            
            try
            {
                do
                {
                    Console.WriteLine("Please insert a num");
                    if (num < 0) negativeCount++;

                } while ((num = int.Parse(Console.ReadLine()!)) != 0);

                Console.WriteLine($"Negatives count: {negativeCount}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
