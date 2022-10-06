using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObjectIntro.Classes.Diary;
using CSharpObjectIntro.Classes.BankAccount;

namespace CSharpObjectIntro
{
    internal class OOPExercises
    {
        internal static void Run()
        {
            UseDiary();
        }

        internal static void UseDiary()
        {
            // Create a new diary 
            // Diary diary = new Diary("Bob Smith"); 

            // Add some events to your diary

            // Now check how many events you have on a particular day

            // Implement a new method in the Diary class to return the number of morning events on a particular day
            // Call this method
        }

        internal static void UseBankAccount()
        {
            // Implement your bank account class following the instructions in the BankAccount class
            // Create a new bank account
            BankAccount AseemsAccount = new BankAccount(1000);
            // Deposit some money
            AseemsAccount.Deposit(DateTime.Now, 100, "Salary", "Aseem", "Deposit");
            // Withdraw some money
            AseemsAccount.Withdraw(100, DateTime.Now, 100, "Salary", "Aseem", "Withdraw");
            // Check the balance
            Console.WriteLine(AseemsAccount.GetBalance());
            // Check the transactions
            foreach (var transaction in AseemsAccount.GetTransactions())
            {
                Console.WriteLine(transaction);
            }
            

            // Write calling code from here
        }
    }
}

