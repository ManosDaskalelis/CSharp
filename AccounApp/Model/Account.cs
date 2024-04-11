using AccounApp.Εxceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccounApp.Εxceptions;

namespace AccounApp.Model
{
    internal class Account
    {

        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public override string? ToString() =>
            $"{{{Id}\t{Iban}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance}}}";

        // Public API

        /// <summary>
        /// Deposits an amount of money to the <see cref="Account"/>
        /// </summary>
        /// <param name="amount">A certain amount of money</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0) throw new NegativeAmountException("Error Amount cannot be negative");
            }
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        ///  Withdraws an amount of money to the <see cref="Account"/>
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="ssn"></param>
        public void Withdraw(decimal amount, string ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException(ssn);
                if (!(Ssn == ssn)) throw new InvalidSsnException(ssn);
                if (amount < 0) throw new NegativeAmountException("Error negative");
                if (amount > Balance) throw new InsufficientAmountExceptions("");
                Balance -= amount;

            }
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            catch (InsufficientAmountExceptions e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            catch (InvalidSsnException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }

}
