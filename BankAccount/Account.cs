﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single customers bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with a specific owner and a balance of zero
        /// </summary>
        /// <param name="accOwner"> The customer's full name that owns the account </param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }

        /// <summary>
        /// The account holders full name (first and last)
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// The amount of money currently in the account
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Add a specified amount of money to the account. Returns the new balance
        /// </summary>
        /// <param name="amount"> The amount positive amount to deposit </param>
        /// <returns> The new balance after the deposit </returns>
        public double Deposit(double amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(amount)} must be more than 0");
            }

            Balance += amount;
            return Balance;
        }

        /// <summary>
        /// Withdraws a specified amount of money from the balance of the account
        /// and returns the updated balance
        /// </summary>
        /// <param name="amount"> The positive amount of money to be withdrawn from the balance </param>
        /// <returns> Returns the updated balance after withdrawal </returns>
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
