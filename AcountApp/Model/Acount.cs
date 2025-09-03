using AcountApp.Exceptions;
using System.Security.Cryptography.X509Certificates;

namespace AcountApp.Model
{
    internal class Acount
    {
        public int Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }    
        public decimal Balance { get; set; }

        public Acount() { }

        public Acount(int id, string? iban, string? firstname, string? lastname, string? ssn, decimal balance)
        {
            Id = id;
            Iban = iban;
            Firstname = firstname;
            Lastname = lastname;
            Ssn = ssn;
            Balance = balance;
        }

        public override string? ToString()
        {
            return $"{{ {Id}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance} }}";
        }

        public void Deposit(decimal amount) 
        {
            try
            {
              if (amount < 0) throw new NegativeAmountException("Error. Amount must not be negative");
                Balance += amount;
            }catch (NegativeAmountException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void WithDraw(decimal amount, string? ssn) 
        {
            try 
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException(ssn!);
                if (ssn != Ssn) throw new InvalidSsnException(ssn);
                if (amount < 0) throw new NegativeAmountException("Error. Amount must not be negative");
                if (amount > Balance) throw new InsufficientBalanceException("Error. Insufficient Balance");

                Balance -= amount;
            } catch (NegativeAmountException e) 
            {
                Console.WriteLine(e.Message);
                throw;
            }catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }catch (InvalidSsnException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
        public decimal GetBalance(decimal amount)
        {
            return Balance;
        }
    }
}
