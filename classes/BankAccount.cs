using System;

namespace classes
{
    public class BankAccount    // This line defines the class, or type, we're creating.
    {   /* Everything inside the {} that follows the class declaration defines the BEHAVIOR of the class. There are 5 MEMBERS of the BankAccount class. 
        The first 3 are PROPERTIES. */
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        // Properties are DATA ELEMENTS and can have code that enforces validation or other rules.



        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string payee, string note)
        {
        }

    }
}