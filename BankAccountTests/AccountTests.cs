using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        private Account acc;

        [TestInitialize]
        public void CreateDefaultAccount()
        {
            acc = new Account("J Doe");
        }

        [TestMethod()]
        [DataRow(100)]
        [DataRow(.01)]
        [DataRow(1.999)]
        [DataRow(9999.999)]
        public void Deposit_APositiveAmount_AddToBalance(double depositAmount)
        {
            acc.Deposit(depositAmount);

            Assert.AreEqual(depositAmount, acc.Balance);
        }

        [TestMethod()]
        public void Deposit_APositiveAmount_ReturnsUpdatedBalance()
        {
            // AAA - Arrange Act Assert
            // Arrange
            double depositAmount = 100;
            double expectedReturn = 100;

            // Act
            double returnValue = acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }

        [TestMethod()]
        [DataRow(-1)]
        [DataRow(0)]
        public void Deposit_ZeroOrLess_ThrowsArgumentException(double invalidDepositAmount)
        {
            // Arrange
            // Nothing to add here, initialized the account

            // Assert ---> Act
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => acc.Deposit(invalidDepositAmount));
        }

        [TestMethod()]
        public void Withdraw_PositiveAmount_DecreaseBalance()
        {
            // Arrange
            double intialDeposit = 100;
            double withdrawalAmount = 50;
            double expectedBalance = intialDeposit - withdrawalAmount;

            // Act
            acc.Deposit(intialDeposit);
            acc.Withdraw(withdrawalAmount);

            double actualBalance = acc.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void Withdraw_PositiveAmount_ReturnsUpdatedBalance()
        {
            Assert.Fail();
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(-0.01)]
        [DataRow(-1000)]
        public void Withdraw_ZeroOrLess_ThrowsArgumentOutOfRangeException()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Withdraw_MoreThanAvailableBalance_ThrowsArgumentException()
        {
            Assert.Fail();
        }
    }
}

// Withdrawing more than available balance - Argument Exception