using System;

namespace BankTransaction
{
    // Represents a simple bank account
    public class BankAccount
    {
        private double balance;

        // Adds money to the account
        public void Deposit(double amount)
        {
            // Validate deposit amount
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be greater than zero.");
            balance += amount;
        }

        // Withdraws money from the account
        public void Withdraw(double amount)
        {
            // Validate withdrawal amount
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be greater than zero.");

            // Ensure sufficient balance
            if (amount > balance)
                throw new InvalidOperationException("Insufficient funds.");

            balance -= amount;
        }

        // Returns the current balance
        public double GetBalance()
        {
            return balance;
        }
    }
}
