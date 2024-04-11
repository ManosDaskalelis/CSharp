using AccounApp.Model;
using AccounApp.Εxceptions;

namespace AccounApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new()
            {
                Id = 1,
                Iban = "GR123456",
                Firstname = "Nick",
                Lastname = "N.",
                Ssn = "A123",
                Balance = 1123.5m
            };    


            try
            {
                account.Deposit(1000.80m);
                Console.WriteLine(account);
                account.Withdraw(500m, "A123");
                Console.WriteLine(account);
            }
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (InsufficientAmountExceptions e) 
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (InvalidSsnException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
