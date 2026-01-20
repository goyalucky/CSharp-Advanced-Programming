/* Testing Banking Transactions
Problem:
Create a BankAccount class with:
● Deposit(double amount): Adds money to the balance.
● Withdraw(double amount): Reduces balance.
● GetBalance(): Returns the current balance.
Write unit tests to check correct balance updates. Ensure withdrawals fail if funds are insufficient. */


using NUnit.Framework;
using System;
using BankTransaction;

namespace BankTransaction.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount account;

        // Runs before each test
        [SetUp]
        public void SetUp()
        {
            account = new BankAccount();
        }

        [Test]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            // Act
            account.Deposit(1000);

            // Assert
            Assert.AreEqual(1000, account.GetBalance());
        }

        [Test]
        public void Withdraw_ValidAmount_ReducesBalance()
        {
            // Arrange
            account.Deposit(1000);

            // Act
            account.Withdraw(400);

            // Assert
            Assert.AreEqual(600, account.GetBalance());
        }

        [Test]
        public void Withdraw_AmountGreaterThanBalance_ThrowsException()
        {
            // Arrange
            account.Deposit(500);

            // Assert
            Assert.Throws<InvalidOperationException>(() =>
            {
                account.Withdraw(800);
            });
        }

        [Test]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                account.Deposit(-100);
            });
        }

        [Test]
        public void Withdraw_ZeroAmount_ThrowsException()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                account.Withdraw(0);
            });
        }
    }
}
