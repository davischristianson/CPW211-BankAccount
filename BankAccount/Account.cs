﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single customers bank account
    /// </summary>
    internal class Account
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
        /// Add a specified amount of money to the account
        /// </summary>
        /// <param name="amt"> The amount positive amount to deposit </param>
        public void Deposit(double amt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Withdraws a specified amount of money from the balance of the account
        /// </summary>
        /// <param name="amt"> The positive amount of money to be withdrawn from the balance </param>
        public void Withdraw(double amt)
        {
            throw new NotImplementedException();
        }
    }
}
