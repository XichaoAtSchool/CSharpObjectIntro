using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectIntro.Classes.BankAccount
{
    public class BankAccount
    {
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests

        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 
        // The balance should never go below zero. If it does, the balance should be set to zero and the method should return false
        private double Balance;

        public BankAccount(double balance = 0)
        {
            Balance = balance;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public bool Deposit(DateTime date, double amount, string category, string counterparty, string transactionType, string description = "")
        {
            Balance += amount;
            AddTransaction(date, amount, category, counterparty, transactionType, description);
            return true;
            
        }
        


        // Task Two
        // Give the option to set an overdraft limit
        // Do not allow a withdrawal/payment if the overdraft limit is exceeded. You could return false or throw an exception.

        public bool Withdraw(double overdraft, DateTime date, double amount, string category, string counterparty, string transactionType, string description = "")
        {
            AddTransaction(date, amount, category, counterparty, transactionType, description);
            if (Balance - amount < overdraft)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        // Task Three
        // Create a new class called AccountTransaction.
        // It could contain properties such as
        // date, amount, category, counterparty, transactionType, description (optional)
        // e.g 26/09/2022 16:45, -300, Groceries, Waitrose, Card, Weekly shop
        //     27/09/2022 17:40, 200, Gift, Bob Smith, Cheque, Birthday present
        // You might wish to use enums for category and transactionType
        // Amend your bank account to contain a list of transactions
        // The methods for  deposit and withdraw/make payments should be amended to add transactions

        class AccountTransaction
        {
            public DateTime Date { get; set; }
            public double Amount { get; set; }
            public string Category { get; set; }
            public string Counterparty { get; set; }
            public string TransactionType { get; set; }
            public string Description { get; set; }

            public AccountTransaction(DateTime date, double amount, string category, string counterparty, string transactionType, string description = "")
            {
                Date = date;
                Amount = amount;
                Category = category;
                Counterparty = counterparty;
                TransactionType = transactionType;
                Description = description;
            }
        }

        private List<AccountTransaction> Transactions = new List<AccountTransaction>();

        public void AddTransaction(DateTime date, double amount, string category, string counterparty, string transactionType, string description = "")
        {
            Transactions.Add(new AccountTransaction(date, amount, category, counterparty, transactionType, description));
        }


        // Task Four
        // Now add some new methods to your account
        // - See what the balance was at a previous date
        // - See how much money was spent in a given time period
        // - See how much money was spent in different categories

        public double checkBalanceAtDate(DateTime date)
        {
            foreach (AccountTransaction transaction in Transactions)
            {
                if (transaction.Date == date)
                {
                    return transaction.Amount;
                }
            }
            return 0;
        }

        public double checkSpentInTimePeriod(DateTime startDate, DateTime endDate)
        {
            double total = 0;
            foreach (AccountTransaction transaction in Transactions)
            {
                if (transaction.Date >= startDate && transaction.Date <= endDate)
                {
                    total += transaction.Amount;
                }
            }
            return total;
        }


        // Extension
        // Work out how much interest is payable on your account
        // For the moment make up the interest rates, though later we could look at loading them from a website
        // The interest should be added as transactions to your account





    }
}
