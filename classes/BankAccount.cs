using System.Collections.Generic;
using System;

namespace classes
{
    public class BankAccount    // This line defines the class, or type, we're creating.
    {   /* Everything inside the {} that follows the class declaration defines the BEHAVIOR of the class. There are 5 MEMBERS of the BankAccount class. 
        The first 3 are PROPERTIES. Properties are DATA ELEMENTS and can have code that enforces validation or other rules.*/
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        { 
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                    balance += item.Amount;
                return balance;
            }

        }


        // These 2 members are METHODS. Methods are blocks of code that perform a single function.
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string payee, string note)
        {
        }

        // This is a CONSTRUCTOR. A constructor is a member that has the same name as the class. A constructor is used to initialize objects of that CLASS TYPE.
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;

            // Assign the account number:
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        // This is a data member. It's PRIVATE, so it can only be accessed by code INSIDE the BankAccount.
        private static int accountNumberSeed = 1234567890;

        // This declaration adds a List<T> of Transaction objects to the BankAccount class:
        private List<Transaction> allTransactions = new List<Transaction>();
    }
}